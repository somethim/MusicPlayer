namespace MusicPlayer.database.Models;

public class User
{
    public Guid Id { get; init; }
    public string Email { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string? Token { get; set; }
}