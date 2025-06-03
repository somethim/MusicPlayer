using MusicPlayer.database;
using MusicPlayer.database.Models;

namespace MusicPlayer.Auth;

public partial class SignUp : Form
{
    private readonly MusicPlayerContext _dbContext;

    public SignUp(MusicPlayerContext dbContext)
    {
        _dbContext = dbContext;

        InitializeComponent();
    }

    private async void SignUp_Load(object sender, EventArgs e)
    {
        try
        {
            var token = await User.GetStoredToken();
            if (token is null) return;
            var dashboard = new Dashboard(_dbContext, await User.FindByToken(_dbContext, token));
            dashboard.Show();
            Hide();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error retrieving token: {ex.Message}");
        }
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

            var user = await User.Register(_dbContext, username, email, password);
            var dashboard = new Dashboard(_dbContext, user);
            dashboard.Show();
            Hide();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}");
        }
    }

    private void sign_in_redirect_label_Click(object sender, EventArgs e)
    {
        var signInForm = new SignIn(_dbContext);
        signInForm.Show();
        Hide();
    }
}