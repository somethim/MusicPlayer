using System.Security.Cryptography;
using System.Text;
using MusicPlayer.database.Models;

namespace MusicPlayer.Utils;

public static class PasswordValidator
{
    public static bool CheckPassword(User user, string providedPassword)
    {
        try
        {
            var parts = user.Password.Split(':');
            if (parts.Length != 2)
                return false;

            var storedSalt = Convert.FromBase64String(parts[0]);
            var storedHash = Convert.FromBase64String(parts[1]);

            return CheckHash(providedPassword, storedSalt, storedHash);
        }
        catch
        {
            return false;
        }
    }

    public static string HashPassword(string password)
    {
        using var hmac = new HMACSHA512();
        var salt = hmac.Key;
        var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

        return Convert.ToBase64String(salt) + ":" + Convert.ToBase64String(hash);
    }

    private static bool CheckHash(string password, byte[] storedSalt, byte[] storedHash)
    {
        using var hmac = new HMACSHA512(storedSalt);
        var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        return !computedHash.Where((t, i) => t != storedHash[i]).Any();
    }
}