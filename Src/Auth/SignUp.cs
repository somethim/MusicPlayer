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
            var dashboard = new Dashboard();
            dashboard.Show();
            Hide();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error retrieving token: {ex.Message}");
        }
    }

    private void sign_up_button_Click(object sender, EventArgs e)
    {
    }

    private void sign_in_redirect_label_Click(object sender, EventArgs e)
    {
    }
}