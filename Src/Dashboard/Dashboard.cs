using MusicPlayer.database;
using MusicPlayer.database.Models;
using MusicPlayer.Utils;

namespace MusicPlayer.Dashboard;

public partial class Dashboard : Form
{
    private readonly LocalMusicPlayerContext _localDbContext;
    private readonly RemoteMusicPlayerContext _remoteDbContext;
    private readonly SongSearcher _searcher = null!;
    private readonly List<Song> _songs = [];
    private readonly User _user;
    private SongManager _manager = null!;


    public Dashboard(LocalMusicPlayerContext localDbContext, RemoteMusicPlayerContext remoteDbContext, User user)
    {
        _localDbContext = localDbContext;
        _remoteDbContext = remoteDbContext;
        _user = user;
        InitializeComponent();
    }

    private async Task search_button_click(object sender, EventArgs e)
    {
        try
        {
            var searchText = searchBox.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show(@"Please enter a search term.", @"Search Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var searched = await _searcher.SearchSongsOnline(searchText);

            _songs.Clear();
            _songs.AddRange(searched.Results);
            if (_songs.Count == 0)
                MessageBox.Show(@"No songs found for the given search term.", @"Search Result", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            LoadSongs(_songs);
            _manager = new SongManager(_songs);
        }
        catch (Exception ex)
        {
            MessageBox.Show(@$"Error searching songs: {ex.Message}", @"Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private async Task LoadCurrentSong(Song song)
    {
        if (!string.IsNullOrEmpty(song.AlbumImage))
            try
            {
                using var httpClient = new HttpClient();
                var imageBytes = await httpClient.GetByteArrayAsync(song.AlbumImage);
                using var ms = new MemoryStream(imageBytes);
                playerArtwork.Image = Image.FromStream(ms);
            }
            catch
            {
                playerArtwork.Image = null;
            }
        else
            playerArtwork.Image = null;

        dashboardCurrentSongs.Text = song.Title;
        playerSong.Text = song.Artist;

        progressBar.Maximum = song.Duration ?? 0;
        progressBar.Value = 0;
    }

    private void LoadSongs(List<Song> songs)
    {
        // songList1
        if (songs.Count > 0)
            SetSongPanel(songPanel, songArtwork, songTitle, songArtist, songs[0]);
        if (songs.Count > 1)
            SetSongPanel(panel1, pictureBox1, label2, label1, songs[1]);
        if (songs.Count > 2)
            SetSongPanel(panel2, pictureBox2, label4, label3, songs[2]);
        if (songs.Count > 3)
            SetSongPanel(panel3, pictureBox3, label6, label5, songs[3]);

        // songList2
        if (songs.Count > 4)
            SetSongPanel(panel4, pictureBox4, label8, label7, songs[4]);
        if (songs.Count > 5)
            SetSongPanel(panel5, pictureBox5, label10, label9, songs[5]);
        if (songs.Count > 6)
            SetSongPanel(panel6, pictureBox6, label12, label11, songs[6]);
        if (songs.Count > 7)
            SetSongPanel(panel7, pictureBox7, label14, label13, songs[7]);
        return;

        void SetSongPanel(Panel panel, PictureBox artwork, Label title, Label artist, Song song)
        {
            title.Text = song.Title;
            artist.Text = song.Artist;
            try
            {
                if (!string.IsNullOrEmpty(song.AlbumImage))
                    artwork.Load(song.AlbumImage);
                else
                    artwork.Image = null;
            }
            catch
            {
                artwork.Image = null;
            }

            panel.Click -= PanelClick;

            panel.Click += PanelClick;
            return;

            void PanelClick(object? sender, EventArgs e)
            {
                LoadCurrentSong(song);
            }
        }
    }


    private void playButton_Click(object sender, EventArgs e)
    {
        try
        {
            var state = (int)_manager.TogglePlayPause();
            playButton.Text = state switch
            {
                0 => "||",
                1 => "▶",
                _ => "||"
            };
        }
        catch (Exception ex)
        {
            MessageBox.Show(@$"Error playing song: {ex.Message}", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void likeButton_Click(object sender, EventArgs e)
    {
        try
        {
            await new Song().Save(_localDbContext, _songs[_manager.CurrentIndex]);
        }
        catch (Exception ex)
        {
            MessageBox.Show(@$"Error liking song: {ex.Message}", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


    private void dashboard_button_Click(object sender, EventArgs e)
    {
        try
        {
            var dashboard = new Music.Music(_localDbContext, _remoteDbContext, _user);
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