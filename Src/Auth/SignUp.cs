using MusicPlayer.database;
using MusicPlayer.database.Models;

namespace MusicPlayer.Auth;

public partial class SignUp : Form
{
    private readonly RemoteMusicPlayerContext _dbContext;

    public SignUp(RemoteMusicPlayerContext dbContext)
    {
        _dbContext = dbContext;
        InitializeComponent();
    }

    private async void sign_up_button_Click(object sender, EventArgs e)
    {
        try
        {
            var username = sign_up_username_text_box.Text;
            var email = sign_up_email_text_box.Text;
            var password = sign_up_password_text_box.Text;
            var confirmPassword = sign_up_confirm_password_text_box.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
                throw new InvalidOperationException("Username, Email, and Password cannot be empty.");
            if (password != confirmPassword) throw new InvalidOperationException("Passwords do not match.");

            await User.Register(_dbContext, username, email, password);

            var dashboard = new Dashboard();
            dashboard.Show();
            Hide();
        }
        catch (Exception ex)
        {
            MessageBox.Show(@$"An error occurred: {ex.Message}");
        }
    }

    private void sign_in_redirect_label_Click(object sender, EventArgs e)
    {
        var signInForm = new SignIn(_dbContext);
        signInForm.Show();
        Hide();
    }
}