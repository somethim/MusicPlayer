using MusicPlayer.database;
using MusicPlayer.database.Models;
using MusicPlayer.Utils;

namespace MusicPlayer.Music;

public partial class Music : Form
{
    private readonly LocalMusicPlayerContext _localDbContext;
    private readonly RemoteMusicPlayerContext _remoteDbContext;
    private readonly User _user;
    private SongManager _manager = null!;
    private List<Song> _songs = [];

    public Music(LocalMusicPlayerContext localDbContext, RemoteMusicPlayerContext remoteDbContext, User user)
    {
        _localDbContext = localDbContext;
        _remoteDbContext = remoteDbContext;
        _user = user;
        LoadSongs();
        InitializeComponent();
    }

    private void LoadSongs()
    {
        try
        {
            var songs = Song.Index(_localDbContext);
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
            var state = (int)_manager.TogglePlayPause();
            music_play_button.BackgroundImage = state switch
            {
                0 => Image.FromFile("Assets/play_button.png"),
                1 => Image.FromFile("Assets/pause_button.png"),
                _ => music_play_button.BackgroundImage
            };
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

    private void dashboard_button_Click(object sender, EventArgs e)
    {
        try
        {
            var dashboard = new Dashboard.Dashboard(_localDbContext, _remoteDbContext, _user);
            dashboard.Show();
            Hide();
        }
        catch (Exception ex)
        {
            MessageBox.Show(@$"An error occurred: {ex.Message}");
        }
    }

    private void settings_button_Click(object sender, EventArgs e)
    {
        try
        {
            var settings = new Settings.Settings(_localDbContext, _remoteDbContext, _user);
            settings.Show();
            Hide();
        }
        catch (Exception ex)
        {
            MessageBox.Show($@"An error has occurred: {ex.Message}");
        }
    }
}