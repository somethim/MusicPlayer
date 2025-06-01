namespace MusicPlayer.database.Models;

public sealed class Song
{
    public Guid Id { get; init; }
    public string Path { get; set; }
    public SongMetadata Metadata { get; set; }
}