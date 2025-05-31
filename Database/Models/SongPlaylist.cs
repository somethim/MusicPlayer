namespace MusicPlayer.database.Models;

public class SongPlaylist
{
    public Guid Id { get; init; }
    public Guid PlaylistId { get; set; }
    public string SongId { get; set; }
}