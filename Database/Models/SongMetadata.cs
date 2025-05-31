namespace MusicPlayer.database.Models;

public class SongMetadata
{
    public Guid Id { get; set; }
    public Guid SongId { get; set; }
    public string Artist { get; set; }
    public string Album { get; set; }
    public int? Year { get; set; }
    public Song Song { get; set; }
}