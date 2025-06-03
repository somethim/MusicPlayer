using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;//function to validate the email

namespace MusicPlayer
{
    public partial class Settings : Form
    {
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
        public Settings()
        {
            InitializeComponent();

            settings_submit_button.Click += settings_submit_button_Click;
            settings_current_password_textbox.UseSystemPasswordChar = true;
            settings_new_password_textbox.UseSystemPasswordChar = true; ;
        }
        private void settings_submit_button_Click(object sender, EventArgs e)
        {
            string email = settings_email_textbox.Text.Trim();
            string username = settings_username_textbox.Text.Trim();
            string currentPassword = settings_current_password_textbox.Text.Trim();
            string newPassword = settings_new_password_textbox.Text.Trim();

            if (string.IsNullOrEmpty(email) &&
                string.IsNullOrEmpty(username) &&
                string.IsNullOrEmpty(currentPassword) &&
                string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please fill in at least on field to update.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            if (!string.IsNullOrEmpty(currentPassword) && string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("New password is required when changing the current password", "Incomplete Password Info.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(currentPassword) && !string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Current password is required when changing the password", "Incomplete Password Info.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrEmpty(email) && !IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string updateSummary = "Updated settings:\n";

            if (!string.IsNullOrEmpty(email))
                updateSummary += $"-Email:{email}\n";

            if (!string.IsNullOrEmpty(username))
                updateSummary += $"- Username: {username}\n";

            if (!string.IsNullOrEmpty(currentPassword) && !string.IsNullOrEmpty(newPassword))
                updateSummary += "- Password changed\n";

            MessageBox.Show(updateSummary, "Settings Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void panelSettings_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

