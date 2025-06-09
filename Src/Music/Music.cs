using MusicPlayer.database;
using MusicPlayer.database.Models;
using MusicPlayer.Utils;

namespace MusicPlayer.Music;

public partial class Music : Form
{
    private readonly LocalMusicPlayerContext _dbContext;
    private SongManager _manager = null!;
    private List<Song> _songs = [];

    public Music(LocalMusicPlayerContext dbContext)
    {
        _dbContext = dbContext;
        LoadSongs();
        InitializeComponent();
    }

    private void LoadSongs()
    {
        try
        {
            var songs = Song.Index(_dbContext);
            if (songs.Count == 0) return;

            _songs = songs;
            _manager = new SongManager(_songs);
        }
        catch (Exception ex)
        {
            MessageBox.Show(@$"Error loading songs: {ex.Message}", @"Error", MessageBoxButtons.AbortRetryIgnore);
        }
    }

    private void music_play_button_Click(object sender, EventArgs e)
    {
        try
        {
            var state = _manager.TogglePlayPause();
            // todo: Update UI based on playback state
        }
        catch (Exception ex)
        {
            MessageBox.Show(@$"Error playing song: {ex.Message}", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void music_next_song_button_Click(object sender, EventArgs e)
    {
        try
        {
            _manager.PlayNext();
        }
        catch (Exception ex)
        {
            MessageBox.Show(@$"Error playing next song: {ex.Message}", @"Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void music_previous_song_button_Click(object sender, EventArgs e)
    {
        try
        {
            _manager.PlayPrevious();
        }
        catch (Exception ex)
        {
            MessageBox.Show(@$"Error playing previous song: {ex.Message}", @"Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}