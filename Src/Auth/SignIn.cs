using MusicPlayer.database;
using MusicPlayer.database.Models;

namespace MusicPlayer.Auth;

public partial class SignIn : Form
{
    private readonly MusicPlayerContext _dbContext;

    public SignIn(MusicPlayerContext dbContext)
    {
        _dbContext = dbContext;
        InitializeComponent();
    }

    private async void SignIn_Load(object sender, EventArgs e)
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
            Console.WriteLine(@$"Error retrieving token: {ex.Message}");
        }
    }

    private async void sign_in_button_Click(object sender, EventArgs e)
    {
        try
        {
            var usernameOrEmail = sign_in_username_email_text_box.Text;
            var password = sign_in_password_text_box.Text;

            if (string.IsNullOrWhiteSpace(usernameOrEmail) || string.IsNullOrWhiteSpace(password))
                throw new InvalidOperationException("Username/Email and Password cannot be empty.");

            var user = await User.FindByUsernameOrEmail(_dbContext, usernameOrEmail)
                       ?? throw new InvalidOperationException("User not found.");

            await user.Login(_dbContext, password);
            var dashboard = new Settings.Settings(_dbContext, user);
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
        var signUpForm = new SignUp(_dbContext);
        signUpForm.Show();
        Hide();
    }
}