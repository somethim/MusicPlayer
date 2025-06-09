using MusicPlayer.database.Models;
using NAudio.Wave;

namespace MusicPlayer.Utils;

public class SongManager(List<Song> songs) : IDisposable
{
    private readonly List<Song> _songs = songs ?? throw new ArgumentNullException(nameof(songs));
    private AudioFileReader? _audioFile;
    private bool _disposed;
    private WaveOutEvent? _wavePlayer;

    public Song? CurrentSong { get; private set; }
    public int CurrentIndex { get; private set; } = -1;

    public int SongCount => _songs.Count;
    public bool HasSongs => _songs.Count > 0;
    private bool HasNext => CurrentIndex < _songs.Count - 1;
    private bool HasPrevious => CurrentIndex > 0;

    private PlaybackState PlaybackState => _wavePlayer?.PlaybackState ?? PlaybackState.Stopped;

    public bool IsPlaying => PlaybackState == PlaybackState.Playing;
    public bool IsPaused => PlaybackState == PlaybackState.Paused;
    public bool IsStopped => PlaybackState == PlaybackState.Stopped;

    public TimeSpan CurrentPosition
    {
        get => _audioFile?.CurrentTime ?? TimeSpan.Zero;
        set
        {
            if (_audioFile == null || value < TimeSpan.Zero || value > TotalDuration) return;
            _audioFile.CurrentTime = value;
            PositionChanged?.Invoke(this, value);
        }
    }

    public TimeSpan TotalDuration => _audioFile?.TotalTime ?? TimeSpan.Zero;

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public event EventHandler<Song>? SongChanged;
    public event EventHandler<PlaybackState>? PlaybackStateChanged;
    public event EventHandler<TimeSpan>? PositionChanged;
    public event EventHandler<int>? IndexChanged;

    public void LoadSong(Song song)
    {
        var index = _songs.IndexOf(song);
        if (index == -1)
            throw new ArgumentException(@"Song not found in the playlist", nameof(song));

        LoadSongAtIndex(index);
    }

    public void LoadSongAtIndex(int index)
    {
        if (index < 0 || index >= _songs.Count)
            throw new ArgumentOutOfRangeException(nameof(index), @"Index is out of range");

        try
        {
            Stop();

            var song = _songs[index];
            _audioFile = new AudioFileReader(song.AudioDownloadPath);
            _wavePlayer = new WaveOutEvent();
            _wavePlayer.Init(_audioFile);

            _wavePlayer.PlaybackStopped += OnPlaybackStopped;

            CurrentIndex = index;
            CurrentSong = song;

            SongChanged?.Invoke(this, song);
            IndexChanged?.Invoke(this, index);
        }
        catch (Exception ex)
        {
            throw new Exception($"Error loading song '{_songs[index].Title}': {ex.Message}", ex);
        }
    }

    public void Play()
    {
        if (_wavePlayer == null)
            throw new InvalidOperationException("No song is loaded. Call LoadSong() or LoadSongAtIndex() first.");

        try
        {
            _wavePlayer.Play();
            PlaybackStateChanged?.Invoke(this, PlaybackState.Playing);
        }
        catch (Exception ex)
        {
            throw new Exception($"Error playing song: {ex.Message}", ex);
        }
    }

    public void PlaySong(Song song)
    {
        LoadSong(song);
        Play();
    }

    public void PlaySongAtIndex(int index)
    {
        LoadSongAtIndex(index);
        Play();
    }

    public void PlayNext()
    {
        if (!HasNext)
            throw new InvalidOperationException("No next song available");

        PlaySongAtIndex(CurrentIndex + 1);
    }

    public void PlayPrevious()
    {
        if (!HasPrevious)
            throw new InvalidOperationException("No previous song available");

        PlaySongAtIndex(CurrentIndex - 1);
    }

    private void Pause()
    {
        if (_wavePlayer?.PlaybackState != PlaybackState.Playing) return;
        _wavePlayer.Pause();
        PlaybackStateChanged?.Invoke(this, PlaybackState.Paused);
    }

    public void Resume()
    {
        if (_wavePlayer?.PlaybackState != PlaybackState.Paused) return;
        _wavePlayer.Play();
        PlaybackStateChanged?.Invoke(this, PlaybackState.Playing);
    }

    public PlaybackState TogglePlayPause()
    {
        switch (PlaybackState)
        {
            case PlaybackState.Playing:
                Pause();
                return PlaybackState.Paused;
            case PlaybackState.Paused:
                Resume();
                return PlaybackState.Playing;
            case PlaybackState.Stopped:
            default:
                return PlaybackState;
        }
    }

    public void Stop()
    {
        try
        {
            if (_wavePlayer != null)
            {
                _wavePlayer.PlaybackStopped -= OnPlaybackStopped;
                _wavePlayer.Stop();
                _wavePlayer.Dispose();
                _wavePlayer = null;
            }

            _audioFile?.Dispose();
            _audioFile = null;

            PlaybackStateChanged?.Invoke(this, PlaybackState.Stopped);
        }
        catch (Exception ex)
        {
            Console.WriteLine(@$"Warning: Error stopping playback: {ex.Message}");
        }
    }

    public void Seek(TimeSpan position)
    {
        CurrentPosition = position;
    }

    public void SeekForward(TimeSpan amount)
    {
        CurrentPosition = CurrentPosition.Add(amount);
    }

    public void SeekBackward(TimeSpan amount)
    {
        var newPosition = CurrentPosition.Subtract(amount);
        CurrentPosition = newPosition < TimeSpan.Zero ? TimeSpan.Zero : newPosition;
    }

    public Song? GetSongAtIndex(int index)
    {
        return index >= 0 && index < _songs.Count ? _songs[index] : null;
    }

    public Song? GetNextSong()
    {
        return HasNext ? _songs[CurrentIndex + 1] : null;
    }

    public Song? GetPreviousSong()
    {
        return HasPrevious ? _songs[CurrentIndex - 1] : null;
    }

    public List<Song> GetAllSongs()
    {
        return [.._songs];
    }

    private void OnPlaybackStopped(object? sender, StoppedEventArgs e)
    {
        PlaybackStateChanged?.Invoke(this, PlaybackState.Stopped);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (_disposed || !disposing) return;

        Stop();
        _disposed = true;
    }

    ~SongManager()
    {
        Dispose(false);
    }
}