namespace MusicPlayer.database.Models;

public class Timestamps
{
    public DateTime CreatedAt { get; init; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}