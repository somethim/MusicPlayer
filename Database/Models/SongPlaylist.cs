namespace MusicPlayer.database.Models;

public class SongPlaylist : Timestamps
{
    public Guid Id { get; init; }
    public Guid PlaylistId { get; set; }
    public string SongId { get; set; }
}