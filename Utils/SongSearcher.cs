using System.Text.Json;
using System.Web;
using DotNetEnv;
using MusicPlayer.database.Models;

namespace MusicPlayer.Utils;

public sealed class SongSearcher : IDisposable
{
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNameCaseInsensitive = true
    };

    private readonly HttpClient _client = new();
    private string? _currentUrl;
    private bool _disposed;
    private string? _nextPageUrl;
    private string? _previousPageUrl;

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public async Task<SearchResult> SearchSongsOnline(string query)
    {
        if (string.IsNullOrWhiteSpace(query))
            throw new ArgumentException(@"Search query cannot be null or empty.", nameof(query));

        var baseUrl = Env.GetString("JAMENDO_CLIENT_URL");
        if (string.IsNullOrEmpty(baseUrl))
            throw new InvalidOperationException("JAMENDO_CLIENT_URL environment variable is not set.");

        _currentUrl = $"{baseUrl}&search={Uri.EscapeDataString(query)}";
        return await FetchSongs(_currentUrl);
    }

    public async Task<SearchResult> GetNextPage()
    {
        if (string.IsNullOrEmpty(_nextPageUrl))
            throw new InvalidOperationException(
                "No next page available. Call SearchSongsOnline() first or reached end of results.");

        _currentUrl = _nextPageUrl;
        return await FetchSongs(_currentUrl);
    }

    public async Task<SearchResult> GetPreviousPage()
    {
        if (string.IsNullOrEmpty(_previousPageUrl))
            throw new InvalidOperationException("No previous page available.");

        _currentUrl = _previousPageUrl;
        return await FetchSongs(_currentUrl);
    }

    private async Task<SearchResult> FetchSongs(string url)
    {
        try
        {
            using var response = await _client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var jamendoResponse = JsonSerializer.Deserialize<JamendoResponse>(content, JsonOptions);

            if (jamendoResponse?.Results == null || jamendoResponse.Results.Count == 0)
            {
                _nextPageUrl = null;
                _previousPageUrl = null;
                return new SearchResult([], null, null);
            }

            UpdatePaginationUrls();
            return new SearchResult(jamendoResponse.Results, _nextPageUrl, _previousPageUrl);
        }
        catch (HttpRequestException ex)
        {
            throw new InvalidOperationException($"Network error while fetching songs: {ex.Message}", ex);
        }
        catch (JsonException ex)
        {
            throw new InvalidOperationException($"Error parsing API response: {ex.Message}", ex);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Unexpected error while searching songs: {ex.Message}", ex);
        }
    }

    private void UpdatePaginationUrls()
    {
        if (_currentUrl == null) return;

        var currentOffset = GetOffsetFromUrl(_currentUrl);
        var nextOffset = currentOffset + 10;
        var prevOffset = Math.Max(currentOffset - 10, 0);

        _nextPageUrl = UpdateUrlOffset(_currentUrl, nextOffset);
        _previousPageUrl = currentOffset > 0 ? UpdateUrlOffset(_currentUrl, prevOffset) : null;
    }

    private static int GetOffsetFromUrl(string url)
    {
        var uri = new Uri(url);
        var query = HttpUtility.ParseQueryString(uri.Query);
        return int.TryParse(query["offset"], out var offset) ? offset : 0;
    }

    private static string UpdateUrlOffset(string url, int newOffset)
    {
        var uri = new Uri(url);
        var query = HttpUtility.ParseQueryString(uri.Query);
        query["offset"] = newOffset.ToString();

        var uriBuilder = new UriBuilder(uri)
        {
            Query = query.ToString()
        };
        return uriBuilder.ToString();
    }

    private void Dispose(bool disposing)
    {
        if (_disposed || !disposing) return;

        _client?.Dispose();
        _disposed = true;
    }

    ~SongSearcher()
    {
        Dispose(false);
    }
}

public record SearchResult(
    List<Song> Results,
    string? NextPageUrl,
    string? PreviousPageUrl
);

public class JamendoResponse
{
    public List<Song> Results { get; init; } = [];
}