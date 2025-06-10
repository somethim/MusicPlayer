using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using MusicPlayer.Utils;

namespace MusicPlayer.database.Models;

public class User
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string Email { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string? EncryptedToken { get; set; }
    public string? HashedToken { get; set; }

    public async Task<string> Login(RemoteMusicPlayerContext dbContext, string password)
    {
        if (!PasswordValidator.CheckPassword(this, password))
            throw new InvalidOperationException("Invalid password.");

        var (plainToken, encryptedToken, hashedToken, tokenData) = TokenHandler.GenerateToken();
        EncryptedToken = encryptedToken;
        HashedToken = hashedToken;
        await Update(dbContext);
        await TokenHandler.StoreTokenLocally(tokenData);

        return plainToken;
    }

    public async Task Logout(RemoteMusicPlayerContext dbContext)
    {
        EncryptedToken = null;
        await Update(dbContext);
        TokenHandler.ClearLocalToken();
    }

    public async Task Update(RemoteMusicPlayerContext dbContext)
    {
        dbContext.Users.Update(this);
        await dbContext.SaveChangesAsync();
    }

    public static async Task<User> Register(RemoteMusicPlayerContext dbContext, string username, string email,
        string password)
    {
        var user = await Create(dbContext, username, email, password);
        var token = await user.Login(dbContext, password);

        if (token == null)
            throw new InvalidOperationException("Failed to login after register.");

        return user;
    }

    public static User FindByToken(RemoteMusicPlayerContext dbContext, TokenHandler.TokenData storedToken)
    {
        if (storedToken == null || string.IsNullOrEmpty(storedToken.Token))
            throw new InvalidOperationException("No valid token found in local storage.");

        var tokenJson = JsonSerializer.Serialize(storedToken, TokenHandler.JsonOptions) ??
                        throw new Exception("Token is null");
        var hashedToken = TokenHandler.HashToken(tokenJson);
        return dbContext.Users.FirstOrDefault(u => u.HashedToken == hashedToken) ??
               throw new InvalidOperationException("User not found for the given token.");
    }

    public static async Task<User> FindByUsernameOrEmail(RemoteMusicPlayerContext dbContext, string usernameOrEmail)
    {
        return await dbContext.Users
                   .FirstOrDefaultAsync(u => u.Username == usernameOrEmail || u.Email == usernameOrEmail) ??
               throw new InvalidOperationException("User not found.");
    }

    private static async Task<User> Create(RemoteMusicPlayerContext dbContext, string username, string email,
        string password)
    {
        if (await Exists(dbContext, username, email))
            throw new InvalidOperationException("User with this username or email already exists.");

        var user = new User
        {
            Username = username,
            Email = email,
            Password = PasswordValidator.HashPassword(password)
        };

        dbContext.Users.Add(user);
        await dbContext.SaveChangesAsync();
        return user;
    }

    private static async Task<bool> Exists(RemoteMusicPlayerContext dbContext, string username, string email)
    {
        return await dbContext.Users.AnyAsync(u =>
            u.Username == username || u.Email == email);
    }
}