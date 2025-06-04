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

    public static bool ValidateToken(string plainToken, string hashedToken)
    {
        if (string.IsNullOrEmpty(plainToken) || string.IsNullOrEmpty(hashedToken))
            return false;

        try
        {
            var computedHash = HashToken(plainToken);
            return computedHash == hashedToken;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public static (string PlainToken, string TokenHash) GenerateToken(string userId)
    {
        var plainToken = $"{userId}:{DateTime.UtcNow.AddDays(7):o}";
        var tokenHash = HashToken(plainToken);
        return (plainToken, tokenHash);
    }

    public static string HashToken(string plainText)
    {
        using var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(AppKey.Value));
        var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(plainText));
        return Convert.ToBase64String(hash);
    }
}