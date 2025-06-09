using MusicPlayer.database.Models;
using NAudio.Wave;

namespace MusicPlayer.Utils;

public class SongManager(List<Song> songs) : IDisposable
{
    private readonly List<Song> _songs = songs ?? throw new ArgumentNullException(nameof(songs));
    private AudioFileReader? _audioFile;
    private bool _disposed;
    private WaveOutEvent? _wavePlayer;

    private int CurrentIndex { get; set; } = -1;
    private bool HasNext => CurrentIndex < _songs.Count - 1;
    private bool HasPrevious => CurrentIndex > 0;
    private PlaybackState PlaybackState => _wavePlayer?.PlaybackState ?? PlaybackState.Stopped;
    private TimeSpan TotalDuration => _audioFile?.TotalTime ?? TimeSpan.Zero;

    public TimeSpan CurrentPosition
    {
        get => _audioFile?.CurrentTime ?? TimeSpan.Zero;
        set
        {
            if (_audioFile == null || value < TimeSpan.Zero || value > TotalDuration)
                return;

            _audioFile.CurrentTime = value;
        }
    }

    public void Dispose()
    {
        if (_disposed) return;

        DisposeAudioResources();
        _disposed = true;
        GC.SuppressFinalize(this);
    }

    private void LoadSongAtIndex(int index)
    {
        if (index < 0 || index >= _songs.Count)
            throw new ArgumentOutOfRangeException(nameof(index));

        if (index == CurrentIndex && _audioFile != null)
            return;

        try
        {
            DisposeAudioResources();

            var song = _songs[index];
            _audioFile = new AudioFileReader(song.AudioDownloadPath);
            _wavePlayer = new WaveOutEvent();
            _wavePlayer.Init(_audioFile);
            _wavePlayer.PlaybackStopped += OnPlaybackStopped;

            CurrentIndex = index;
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Failed to load song '{_songs[index].Title}': {ex.Message}", ex);
        }
    }


    public PlaybackState TogglePlayPause()
    {
        return PlaybackState switch
        {
            PlaybackState.Playing => SwitchToPaused(),
            PlaybackState.Paused => SwitchToPlaying(),
            _ => PlaybackState
        };
    }

    private PlaybackState SwitchToPaused()
    {
        Pause();
        return PlaybackState.Paused;
    }

    private PlaybackState SwitchToPlaying()
    {
        Play();
        return PlaybackState.Playing;
    }


    private void Play()
    {
        if (_wavePlayer == null)
            throw new InvalidOperationException("No song loaded. Call LoadSongAtIndex() first.");

        if (PlaybackState == PlaybackState.Playing)
            return;

        _wavePlayer.Play();
    }

    private void Pause()
    {
        if (PlaybackState != PlaybackState.Playing)
            return;

        _wavePlayer?.Pause();
    }


    // Convenience methods
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

    public void Seek(TimeSpan position)
    {
        CurrentPosition = position;
    }

    public void SeekForward(TimeSpan? amount)
    {
        CurrentPosition = CurrentPosition.Add(amount ?? TimeSpan.FromSeconds(5));
    }

    public void SeekBackward(TimeSpan? amount)
    {
        var newPosition = CurrentPosition.Subtract(amount ?? TimeSpan.FromSeconds(5));
        CurrentPosition = newPosition < TimeSpan.Zero ? TimeSpan.Zero : newPosition;
    }

    // Query methods
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

    private void OnPlaybackStopped(object? sender, StoppedEventArgs e)
    {
        if (e.Exception != null) throw new InvalidOperationException("Playback stopped due to an error", e.Exception);

        if (HasNext)
            PlayNext();
        else
            DisposeAudioResources();
    }

    private void DisposeAudioResources()
    {
        if (_wavePlayer != null)
        {
            _wavePlayer.PlaybackStopped -= OnPlaybackStopped;
            _wavePlayer.Dispose();
            _wavePlayer = null;
        }

        _audioFile?.Dispose();
        _audioFile = null;
    }
}