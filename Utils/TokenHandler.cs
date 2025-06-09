using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using DotNetEnv;

namespace MusicPlayer.Utils;

public static class TokenHandler
{
    private static readonly string AppKey = Env.GetString("APP_KEY");

    public static readonly JsonSerializerOptions JsonOptions = new()
    {
        WriteIndented = true
    };

    public static bool ValidateToken(string encryptedToken)
    {
        var storedToken = GetStoredToken();
        var tokenData = DecryptToken(encryptedToken);

        if (storedToken == null || tokenData == null || string.IsNullOrEmpty(storedToken.Token))
            return false;

        if (storedToken.Token != tokenData.Token)
            return false;

        return DateTime.UtcNow <= tokenData.At.AddDays(7);
    }

    public static (string PlainToken, string EncryptedToken, string HashedToken, TokenData TokenData) GenerateToken()
    {
        var tokenData = new TokenData { Token = Guid.NewGuid().ToString("N"), At = DateTime.UtcNow };
        var jsonToken = JsonSerializer.Serialize(tokenData, JsonOptions);
        var encryptedToken = EncryptToken(jsonToken);
        var hashedToken = HashToken(jsonToken);
        return (tokenData.Token, encryptedToken, hashedToken, tokenData);
    }

    public static string HashToken(string token)
    {
        var tokenBytes = Encoding.UTF8.GetBytes(token);
        var hashBytes = SHA256.HashData(tokenBytes);
        return Convert.ToBase64String(hashBytes);
    }

    private static string EncryptToken(string plainText)
    {
        var key = DeriveKey(AppKey);
        var iv = DeriveIv(AppKey);

        using var aes = Aes.Create();
        aes.Key = key;
        aes.IV = iv;
        aes.Mode = CipherMode.CBC;
        aes.Padding = PaddingMode.PKCS7;

        using var encryptor = aes.CreateEncryptor();
        var plainBytes = Encoding.UTF8.GetBytes(plainText);
        var encryptedBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);

        return Convert.ToBase64String(encryptedBytes);
    }

    private static TokenData? DecryptToken(string encryptedText)
    {
        try
        {
            var key = DeriveKey(AppKey);
            var iv = DeriveIv(AppKey);

            using var aes = Aes.Create();
            aes.Key = key;
            aes.IV = iv;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;

            using var decryptor = aes.CreateDecryptor();
            var encryptedBytes = Convert.FromBase64String(encryptedText);
            var decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);

            var jsonString = Encoding.UTF8.GetString(decryptedBytes);
            return JsonSerializer.Deserialize<TokenData>(jsonString, JsonOptions);
        }
        catch (Exception)
        {
            return null;
        }
    }

    private static byte[] DeriveKey(string password)
    {
        return SHA256.HashData(Encoding.UTF8.GetBytes(password));
    }

    private static byte[] DeriveIv(string password)
    {
        var hash = SHA256.HashData(Encoding.UTF8.GetBytes(password + "IV_SALT"));
        var iv = new byte[16];
        Array.Copy(hash, iv, 16);
        return iv;
    }

    public static async Task StoreTokenLocally(TokenData tokenData)
    {
        try
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var tokenFilePath = Path.Combine(appDataPath, "MusicPlayer", "user_token.json");

            Directory.CreateDirectory(Path.GetDirectoryName(tokenFilePath)!);

            var jsonString = JsonSerializer.Serialize(tokenData, JsonOptions);
            await File.WriteAllTextAsync(tokenFilePath, jsonString);
        }
        catch (Exception ex)
        {
            Console.WriteLine(@$"Failed to store token locally: {ex.Message}");
        }
    }

    public static void ClearLocalToken()
    {
        try
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var tokenFilePath = Path.Combine(appDataPath, "MusicPlayer", "user_token.json");

            if (File.Exists(tokenFilePath))
                File.Delete(tokenFilePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine(@$"Failed to clear local token: {ex.Message}");
        }
    }

    public static TokenData? GetStoredToken()
    {
        try
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var tokenFilePath = Path.Combine(appDataPath, "MusicPlayer", "user_token.json");

            if (File.Exists(tokenFilePath))
            {
                var jsonString = File.ReadAllText(tokenFilePath);
                return JsonSerializer.Deserialize<TokenData>(jsonString, JsonOptions);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(@$"Failed to retrieve stored token: {ex.Message}");
        }

        return null;
    }

    public class TokenData
    {
        public string Token { get; init; } = string.Empty;
        public DateTime At { get; init; }
    }
}