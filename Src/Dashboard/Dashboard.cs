using MusicPlayer.database;
using MusicPlayer.database.Models;

namespace MusicPlayer.Dashboard;

public partial class Dashboard : Form
{
    private readonly LocalMusicPlayerContext _localDbContext;
    private readonly RemoteMusicPlayerContext _remoteDbContext;
    private readonly User _user;

    public Dashboard(LocalMusicPlayerContext localDbContext, RemoteMusicPlayerContext remoteDbContext, User user)
    {
        _localDbContext = localDbContext;
        _remoteDbContext = remoteDbContext;
        _user = user;
        InitializeComponent();
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