namespace MusicPlayer
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            panelSettings = new Panel();
            settings_submit_button = new Button();
            settings_sign_out_button = new Button();
            settings_new_password_textbox = new TextBox();
            settings_current_password_textbox = new TextBox();
            settings_username_textbox = new TextBox();
            settings_email_textbox = new TextBox();
            settings_lbl = new Label();
            panelSettings.SuspendLayout();
            SuspendLayout();
            // 
            // panelSettings
            // 
            panelSettings.BackColor = Color.GhostWhite;
            panelSettings.BackgroundImage = (Image)resources.GetObject("panelSettings.BackgroundImage");
            panelSettings.Controls.Add(settings_submit_button);
            panelSettings.Controls.Add(settings_sign_out_button);
            panelSettings.Controls.Add(settings_new_password_textbox);
            panelSettings.Controls.Add(settings_current_password_textbox);
            panelSettings.Controls.Add(settings_username_textbox);
            panelSettings.Controls.Add(settings_email_textbox);
            panelSettings.Controls.Add(settings_lbl);
            panelSettings.Location = new Point(400, 78);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new Size(507, 513);
            panelSettings.TabIndex = 0;
            panelSettings.Paint += panelSettings_Paint;
            // 
            // settings_submit_button
            // 
            settings_submit_button.BackColor = Color.LavenderBlush;
            settings_submit_button.BackgroundImage = (Image)resources.GetObject("settings_submit_button.BackgroundImage");
            settings_submit_button.Font = new Font("Segoe UI", 12F);
            settings_submit_button.ForeColor = SystemColors.ButtonFace;
            settings_submit_button.Location = new Point(59, 364);
            settings_submit_button.Name = "settings_submit_button";
            settings_submit_button.RightToLeft = RightToLeft.No;
            settings_submit_button.Size = new Size(133, 57);
            settings_submit_button.TabIndex = 6;
            settings_submit_button.Text = "Submit";
            settings_submit_button.UseCompatibleTextRendering = true;
            settings_submit_button.UseVisualStyleBackColor = false;
            // 
            // settings_sign_out_button
            // 
            settings_sign_out_button.BackgroundImage = (Image)resources.GetObject("settings_sign_out_button.BackgroundImage");
            settings_sign_out_button.Font = new Font("Segoe UI", 12F);
            settings_sign_out_button.ForeColor = SystemColors.ButtonFace;
            settings_sign_out_button.Location = new Point(271, 364);
            settings_sign_out_button.Name = "settings_sign_out_button";
            settings_sign_out_button.Size = new Size(133, 57);
            settings_sign_out_button.TabIndex = 5;
            settings_sign_out_button.Text = "Sign out";
            settings_sign_out_button.UseCompatibleTextRendering = true;
            settings_sign_out_button.UseVisualStyleBackColor = true;
            // 
            // settings_new_password_textbox
            // 
            settings_new_password_textbox.BackColor = Color.Lavender;
            settings_new_password_textbox.Font = new Font("Segoe UI", 12F);
            settings_new_password_textbox.ForeColor = SystemColors.WindowText;
            settings_new_password_textbox.Location = new Point(280, 231);
            settings_new_password_textbox.Name = "settings_new_password_textbox";
            settings_new_password_textbox.PlaceholderText = "New Password";
            settings_new_password_textbox.Size = new Size(142, 34);
            settings_new_password_textbox.TabIndex = 4;
            // 
            // settings_current_password_textbox
            // 
            settings_current_password_textbox.BackColor = Color.Lavender;
            settings_current_password_textbox.Font = new Font("Segoe UI", 12F);
            settings_current_password_textbox.Location = new Point(59, 231);
            settings_current_password_textbox.Name = "settings_current_password_textbox";
            settings_current_password_textbox.PlaceholderText = "Current Password";
            settings_current_password_textbox.Size = new Size(165, 34);
            settings_current_password_textbox.TabIndex = 3;
            // 
            // settings_username_textbox
            // 
            settings_username_textbox.BackColor = Color.Lavender;
            settings_username_textbox.Font = new Font("Segoe UI", 12F);
            settings_username_textbox.Location = new Point(59, 149);
            settings_username_textbox.Name = "settings_username_textbox";
            settings_username_textbox.PlaceholderText = "Username";
            settings_username_textbox.Size = new Size(133, 34);
            settings_username_textbox.TabIndex = 2;
            // 
            // settings_email_textbox
            // 
            settings_email_textbox.BackColor = Color.Lavender;
            settings_email_textbox.Font = new Font("Segoe UI", 12F);
            settings_email_textbox.Location = new Point(280, 149);
            settings_email_textbox.Name = "settings_email_textbox";
            settings_email_textbox.PlaceholderText = "Email";
            settings_email_textbox.Size = new Size(133, 34);
            settings_email_textbox.TabIndex = 1;
            // 
            // settings_lbl
            // 
            settings_lbl.AutoSize = true;
            settings_lbl.BackColor = Color.Transparent;
            settings_lbl.Font = new Font("Segoe UI", 18F);
            settings_lbl.ForeColor = SystemColors.ButtonFace;
            settings_lbl.Location = new Point(59, 46);
            settings_lbl.Name = "settings_lbl";
            settings_lbl.Size = new Size(125, 41);
            settings_lbl.TabIndex = 0;
            settings_lbl.Text = "Settings";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1262, 673);
            Controls.Add(panelSettings);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Settings";
            Text = "Settings";
            Load += Settings_Load;
            panelSettings.ResumeLayout(false);
            panelSettings.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSettings;
        private Label settings_lbl;
        private TextBox settings_new_password_textbox;
        private TextBox settings_current_password_textbox;
        private TextBox settings_username_textbox;
        private TextBox settings_email_textbox;
        private Button settings_sign_out_button;
        private Button settings_submit_button;
    }
}