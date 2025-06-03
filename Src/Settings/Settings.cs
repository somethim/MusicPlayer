using System.Text.RegularExpressions;
using MusicPlayer.Auth;
using MusicPlayer.database;
using MusicPlayer.database.Models;
using MusicPlayer.Utils;

namespace MusicPlayer.Settings;

public partial class Settings : Form
{
    private readonly MusicPlayerContext _dbContext;
    private readonly User _user;

    public Settings(MusicPlayerContext dbContext, User user)
    {
        _dbContext = dbContext;
        _user = user;
        InitializeComponent();
    }

    private async void settings_submit_button_Click(object sender, EventArgs e)
    {
        try
        {
            var email = settings_email_textbox.Text;
            var username = settings_username_textbox.Text;
            var currentPassword = settings_current_password_textbox.Text;
            var newPassword = settings_new_password_textbox.Text;

            if (string.IsNullOrEmpty(email) &&
                string.IsNullOrEmpty(username) &&
                string.IsNullOrEmpty(currentPassword) &&
                string.IsNullOrEmpty(newPassword))
                throw new Exception("At least one field must be filled to update settings.");
            if (!string.IsNullOrEmpty(currentPassword) && string.IsNullOrEmpty(newPassword))
                throw new Exception("New password is required when changing the current password.");
            if (string.IsNullOrEmpty(currentPassword) && !string.IsNullOrEmpty(newPassword))
                throw new Exception("Current password is required when changing the password.");
            if (!string.IsNullOrEmpty(email) && !IsValidEmail(email))
                throw new Exception("Invalid email format.");

            var updateSummary = "Updated settings:\n";
            var hasUpdates = false;

            if (!string.IsNullOrEmpty(email) && email != _user.Email)
            {
                _user.Email = email;
                updateSummary += $"- Email: {email}\n";
                hasUpdates = true;
            }

            if (!string.IsNullOrEmpty(username) && username != _user.Username)
            {
                _user.Username = username;
                updateSummary += $"- Username: {username}\n";
                hasUpdates = true;
            }

            if (!string.IsNullOrEmpty(currentPassword) && !string.IsNullOrEmpty(newPassword))
            {
                if (!PasswordValidator.CheckPassword(_user, currentPassword))
                    throw new Exception("Current password is incorrect.");

                // Set new password
                _user.Password = PasswordValidator.HashPassword(newPassword);
                updateSummary += "- Password changed\n";
                hasUpdates = true;
            }

            if (hasUpdates)
            {
                await _user.Update(_dbContext);
                MessageBox.Show(updateSummary, @"Settings Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(@"No changes were made.", @"Settings", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(@$"An error occurred while updating settings: {ex.Message}", @"Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    [GeneratedRegex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$")]
    private static partial Regex RegexPattern();

    private static bool IsValidEmail(string email)
    {
        return RegexPattern().IsMatch(email);
    }

    private async void settings_sign_out_button_Click(object sender, EventArgs e)
    {
        try
        {
            await _user.Logout(_dbContext);
            var loginForm = new SignIn(_dbContext);
            loginForm.Show();
            Hide();
        }
        catch (Exception ex)
        {
            MessageBox.Show(@$"An error occurred while updating settings: {ex.Message}", @"Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}