using Microsoft.EntityFrameworkCore;
using MusicPlayer.Utils;

namespace MusicPlayer.database.Models;

public class User
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string Email { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string? Token { get; set; }

    // --- Public Methods ---

    public async Task<string> Login(MusicPlayerContext dbContext, string password)
    {
        if (!PasswordValidator.CheckPassword(this, password))
            throw new InvalidOperationException("Invalid password.");

        var (plainToken, encryptedToken) = TokenHandler.GenerateToken(Id.ToString());
        Token = encryptedToken; // Store encrypted token in DB
        await Update(dbContext);
        await StoreTokenLocally(plainToken); // Store plain token locally

        return plainToken;
    }

    public async Task Logout(MusicPlayerContext dbContext)
    {
        Token = null;
        await Update(dbContext);
        await ClearLocalToken();
    }

    public async Task Update(MusicPlayerContext dbContext)
    {
        dbContext.Users.Update(this);
        await dbContext.SaveChangesAsync();
    }

    public static async Task<User> Register(MusicPlayerContext dbContext, string username, string email,
        string password)
    {
        var user = await Create(dbContext, username, email, password);
        var token = await user.Login(dbContext, password);

        if (token == null)
            throw new InvalidOperationException("Failed to login after register.");

        return user;
    }

    public static async Task<User> FindByToken(MusicPlayerContext dbContext, string token)
    {
        if (!TokenHandler.ValidateToken(token))
            throw new InvalidOperationException("Token is invalid or expired.");

        return await dbContext.Users
                   .FirstOrDefaultAsync(u => u.Token == token) ??
               throw new InvalidOperationException("User not found.");
    }

    public static async Task<User> FindByUsernameOrEmail(MusicPlayerContext dbContext, string usernameOrEmail)
    {
        return await dbContext.Users
                   .FirstOrDefaultAsync(u => u.Username == usernameOrEmail || u.Email == usernameOrEmail) ??
               throw new InvalidOperationException("User not found.");
    }

    public static async Task<User> GetCurrentUser(MusicPlayerContext dbContext)
    {
        var storedToken = await GetStoredToken();
        if (storedToken == null)
            throw new InvalidOperationException("No user is currently logged in.");

        if (TokenHandler.ValidateToken(storedToken)) return await FindByToken(dbContext, storedToken);
        await ClearLocalToken();
        throw new InvalidOperationException("Your session has expired. Please log in again.");
    }

    // --- Private Methods ---

    private static async Task<User> Create(MusicPlayerContext dbContext, string username, string email, string password)
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

    private static async Task<bool> Exists(MusicPlayerContext dbContext, string username, string email)
    {
        return await dbContext.Users.AnyAsync(u =>
            u.Username == username || u.Email == email);
    }

    private static async Task StoreTokenLocally(string token)
    {
        try
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var tokenFilePath = Path.Combine(appDataPath, "MusicPlayer", "user_token.txt");

            Directory.CreateDirectory(Path.GetDirectoryName(tokenFilePath)!);
            await File.WriteAllTextAsync(tokenFilePath, token);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to store token locally: {ex.Message}");
        }
    }

    private static Task ClearLocalToken()
    {
        try
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var tokenFilePath = Path.Combine(appDataPath, "MusicPlayer", "user_token.txt");

            if (File.Exists(tokenFilePath))
                File.Delete(tokenFilePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to clear local token: {ex.Message}");
        }

        return Task.CompletedTask;
    }

    public static async Task<string?> GetStoredToken()
    {
        try
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var tokenFilePath = Path.Combine(appDataPath, "MusicPlayer", "user_token.txt");

            if (File.Exists(tokenFilePath))
                return await File.ReadAllTextAsync(tokenFilePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to retrieve stored token: {ex.Message}");
        }

        return null;
    }
}