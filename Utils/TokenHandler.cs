using System.Security.Cryptography;
using System.Text;
using DotNetEnv;

namespace MusicPlayer.Utils;

public static class TokenHandler
{
    private static readonly Lazy<string> AppKey = new(() =>
    {
        Env.Load();
        var key = Env.GetString("APP_KEY");
        if (string.IsNullOrEmpty(key))
            throw new InvalidOperationException("APP_KEY is not set in .env file");
        return key;
    });

    public static bool ValidateToken(string plainToken, string encryptedDbToken)
    {
        if (string.IsNullOrEmpty(plainToken) || string.IsNullOrEmpty(encryptedDbToken))
            return false;

        try
        {
            // Encrypt the plain token to compare with stored encrypted token
            var calculatedEncryptedToken = EncryptToken(plainToken);

            // Token is valid if encryption matches the stored encrypted token
            if (calculatedEncryptedToken != encryptedDbToken)
                return false;

            // Also verify token hasn't expired
            var parts = plainToken.Split(':');
            if (parts.Length != 2)
                return false;

            if (!DateTime.TryParse(parts[1], out var expiryDate))
                return false;

            return expiryDate > DateTime.UtcNow;
        }
        catch
        {
            return false;
        }
    }

    public static (string PlainToken, string EncryptedToken) GenerateToken(string userId)
    {
        var plainToken = $"{userId}:{DateTime.UtcNow.AddHours(24)}";
        var encryptedToken = EncryptToken(plainToken);

        return (plainToken, encryptedToken);
    }

    // For backward compatibility
    public static bool ValidateToken(string token)
    {
        if (string.IsNullOrEmpty(token))
            return false;

        try
        {
            var parts = token.Split(':');
            if (parts.Length != 2)
                return false;

            if (!DateTime.TryParse(parts[1], out var expiryDate))
                return false;

            return expiryDate > DateTime.UtcNow;
        }
        catch
        {
            return false;
        }
    }

    private static string EncryptToken(string plainText)
    {
        using var aes = Aes.Create();
        aes.Key = DeriveKeyFromPassword(AppKey.Value);
        aes.IV = new byte[16];

        using var encryptor = aes.CreateEncryptor();
        var plainBytes = Encoding.UTF8.GetBytes(plainText);

        using var ms = new MemoryStream();
        using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
        {
            cs.Write(plainBytes, 0, plainBytes.Length);
        }

        return Convert.ToBase64String(ms.ToArray());
    }

    private static byte[] DeriveKeyFromPassword(string password)
    {
        using var deriveBytes = new Rfc2898DeriveBytes(
            password,
            "Ivan Medvedev"u8.ToArray(),
            1000,
            HashAlgorithmName.SHA256);

        return deriveBytes.GetBytes(32); // 256 bits
    }
}