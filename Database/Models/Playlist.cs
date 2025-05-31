namespace MusicPlayer.database.Models;

public class Playlist : Timestamps
{
    public Guid Id { get; init; }
    public string Title { get; set; }
}