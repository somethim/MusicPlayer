namespace MusicPlayer.Models;

public class Song
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Artist { get; set; }
    public SongMetadata Metadata { get; set; } = new();
    public string? SavePath { get; set; }
}

public class SongMetadata
{
    public string Album { get; set; }
    public string Genre { get; set; }
    public TimeSpan Duration { get; set; }
    public int Bitrate { get; set; }
    public int SampleRate { get; set; }
    public int Channels { get; set; }
}