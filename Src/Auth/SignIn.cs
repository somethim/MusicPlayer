using MusicPlayer.database;
using MusicPlayer.database.Models;

namespace MusicPlayer.Auth;

public partial class SignIn : Form
{
    private readonly LocalMusicPlayerContext _localDbContext;
    private readonly RemoteMusicPlayerContext _remoteDbContext;

    public SignIn(LocalMusicPlayerContext localDbContext, RemoteMusicPlayerContext remoteDbContext)
    {
        _localDbContext = localDbContext;
        _remoteDbContext = remoteDbContext;
        InitializeComponent();
    }

    private async void sign_in_button_Click(object sender, EventArgs e)
    {
        try
        {
            var usernameOrEmail = sign_in_username_email_text_box.Text;
            var password = sign_in_password_text_box.Text;

            if (string.IsNullOrWhiteSpace(usernameOrEmail) || string.IsNullOrWhiteSpace(password))
                throw new InvalidOperationException("Username/Email and Password cannot be empty.");

            var user = await User.FindByUsernameOrEmail(_remoteDbContext, usernameOrEmail)
                       ?? throw new InvalidOperationException("User not found.");

            await user.Login(_remoteDbContext, password);
            var dashboard = new Dashboard.Dashboard(_localDbContext, _remoteDbContext, user);
            dashboard.Show();
            Hide();
        }
        catch (Exception ex)
        {
            MessageBox.Show(@$"An error occurred: {ex.Message}");
        }
    }

    private void sign_up_redirect_label_Click(object sender, EventArgs e)
    {
        var signUpForm = new SignUp(_localDbContext, _remoteDbContext);
        signUpForm.Show();
        Hide();
    }
}