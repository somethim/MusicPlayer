namespace MusicPlayer;

public partial class Music : Form
{
    private readonly List<string> _songs = ["Song 1", "Song 2", "Song 3"];
    private int _currentSongIndex = -1;

    public Music()
    {
        InitializeComponent();
    }

    private void Music_Load(object sender, EventArgs e)
    {
        foreach (var song in _songs) music_listView.Items.Add(song);
    }

    private void music_play_button_Click(object sender, EventArgs e)
    {
        if (music_listView.SelectedIndices.Count > 0)
        {
            _currentSongIndex = music_listView.SelectedIndices[0];
            PlaySong(_currentSongIndex);
        }
        else if (_currentSongIndex != -1)
        {
            PlaySong(_currentSongIndex);
        }
        else
        {
            MessageBox.Show(@"Please select a song to play.");
        }
    }

    private void music_next_song_button_Click(object sender, EventArgs e)
    {
        if (_currentSongIndex >= _songs.Count - 1) return;
        _currentSongIndex++;
        music_listView.Items[_currentSongIndex].Selected = true;
        PlaySong(_currentSongIndex);
    }

    private void music_previous_song_button_Click(object sender, EventArgs e)
    {
        if (_currentSongIndex <= 0) return;
        _currentSongIndex--;
        music_listView.Items[_currentSongIndex].Selected = true;
        PlaySong(_currentSongIndex);
    }

    private void PlaySong(int index)
    {
        var song = _songs[index];
        MessageBox.Show(@$"Now playing: {song}");
    }

    private void dashboard_button_Click(object sender, EventArgs e)
    {

        try
        {
            var dashboard = new Dashboard();
            dashboard.Show();
            Hide();
        }
        catch(Exception ex) {
            MessageBox.Show(@$"An error occurred: {ex.Message}");
        }
    }

    private void settings_button_Click(object sender, EventArgs e)
    {
        try
        {
            var settings =new Settings.Settings();
            settings.Show();
            Hide();
        }
        catch(Exception ex) {
            MessageBox.Show($@"An error has ocurred: {ex.Message}");


    }
}