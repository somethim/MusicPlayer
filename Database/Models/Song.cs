using System.Text.Json.Serialization;

namespace MusicPlayer.database.Models;

public class Song
{
    [JsonIgnore] public Guid Id { get; set; }
    [JsonPropertyName("name")] public string Title { get; set; } = string.Empty;
    [JsonPropertyName("artist_name")] public string Artist { get; set; } = string.Empty;
    [JsonPropertyName("album_name")] public string Album { get; set; } = string.Empty;
    [JsonPropertyName("releasedate")] public string? Releasedate { get; set; }
    [JsonPropertyName("duration")] public int? Duration { get; set; }
    [JsonPropertyName("album_image")] public string AlbumImage { get; set; } = string.Empty;
    [JsonPropertyName("audio")] public string AudioPath { get; set; } = string.Empty;
    [JsonPropertyName("audiodownload")] public string? AudioDownloadPath { get; set; }

    public string LocalFilePath => GetSongFilePath(this);
    public bool IsDownloaded => File.Exists(LocalFilePath);

    public static List<Song> Index(LocalMusicPlayerContext dbContext, int page = 1, int pageSize = 10)
    {
        if (page < 1) page = 1;
        if (pageSize < 1) pageSize = 10;

        return dbContext.Songs
            .AsEnumerable()
            .Where(song => song.IsDownloaded)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();
    }

    public async Task Save(LocalMusicPlayerContext dbContext, Song song)
    {
        try
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(song.AudioDownloadPath);
            response.EnsureSuccessStatusCode();
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var musicDir = Path.Combine(appDataPath, "MusicPlayer", "Music");
            if (!Path.Exists(musicDir))
                Directory.CreateDirectory(musicDir);

            var filePath = Path.Combine(musicDir,
                $"{SanitizeFileName(song.Artist)} - {SanitizeFileName(song.Title)}.mp3");
            await using var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);
            await response.Content.CopyToAsync(fileStream);

            song.AudioPath = filePath;
            song.Id = Guid.NewGuid();
            Create(dbContext, song).Wait();
            dbContext.Songs.Add(song);
            await dbContext.SaveChangesAsync();
        }
        catch (HttpRequestException ex)
        {
            throw new Exception($"Error downloading song '{Title}': {ex.Message}", ex);
        }
        catch (IOException ex)
        {
            throw new Exception($"Error saving song file '{Title}': {ex.Message}", ex);
        }
    }


    public void Delete(LocalMusicPlayerContext dbContext)
    {
        if (!IsDownloaded) return;
        try
        {
            File.Delete(LocalFilePath);
            dbContext.Songs.Remove(this);
            dbContext.SaveChanges();
        }
        catch (IOException ex)
        {
            throw new Exception($"Error deleting song file '{Title}': {ex.Message}", ex);
        }
    }

    private static string GetSongFilePath(Song song)
    {
        var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        var musicDir = Path.Combine(appDataPath, "MusicPlayer", "Music");
        var sanitizedTitle = SanitizeFileName(song.Title);
        var sanitizedArtist = SanitizeFileName(song.Artist);
        return Path.Combine(musicDir, $"{sanitizedArtist} - {sanitizedTitle}.mp3");
    }

    private static string SanitizeFileName(string fileName)
    {
        if (string.IsNullOrEmpty(fileName))
            return "Unknown";

        var invalidChars = Path.GetInvalidFileNameChars();
        var sanitized = invalidChars.Aggregate(fileName, (current, c) => current.Replace(c, '_'));

        sanitized = sanitized.Replace(":", "_").Replace("?", "_").Replace("*", "_");

        sanitized = sanitized.Trim();
        if (sanitized.Length > 50) sanitized = sanitized[..50];

        return string.IsNullOrEmpty(sanitized) ? "Unknown" : sanitized;
    }


    private static async Task<Song> Create(LocalMusicPlayerContext dbContext, Song song)
    {
        dbContext.Songs.Add(song);
        await dbContext.SaveChangesAsync();
        return song;
    }
}