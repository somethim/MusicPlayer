namespace MusicPlayer.Settings
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
            panelSettings = new System.Windows.Forms.Panel();
            settings_submit_button = new System.Windows.Forms.Button();
            settings_sign_out_button = new System.Windows.Forms.Button();
            settings_new_password_textbox = new System.Windows.Forms.TextBox();
            settings_current_password_textbox = new System.Windows.Forms.TextBox();
            settings_username_textbox = new System.Windows.Forms.TextBox();
            settings_email_textbox = new System.Windows.Forms.TextBox();
            settings_lbl = new System.Windows.Forms.Label();
            panelSettings.SuspendLayout();
            SuspendLayout();
            // 
            // panelSettings
            // 
            panelSettings.BackColor = System.Drawing.Color.GhostWhite;
            panelSettings.BackgroundImage = ((System.Drawing.Image)resources.GetObject("panelSettings.BackgroundImage"));
            panelSettings.Controls.Add(settings_submit_button);
            panelSettings.Controls.Add(settings_sign_out_button);
            panelSettings.Controls.Add(settings_new_password_textbox);
            panelSettings.Controls.Add(settings_current_password_textbox);
            panelSettings.Controls.Add(settings_username_textbox);
            panelSettings.Controls.Add(settings_email_textbox);
            panelSettings.Controls.Add(settings_lbl);
            panelSettings.Location = new System.Drawing.Point(400, 78);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new System.Drawing.Size(507, 513);
            panelSettings.TabIndex = 0;
            // 
            // settings_submit_button
            // 
            settings_submit_button.BackColor = System.Drawing.Color.LavenderBlush;
            settings_submit_button.BackgroundImage = ((System.Drawing.Image)resources.GetObject("settings_submit_button.BackgroundImage"));
            settings_submit_button.Font = new System.Drawing.Font("Segoe UI", 12F);
            settings_submit_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            settings_submit_button.Location = new System.Drawing.Point(59, 364);
            settings_submit_button.Name = "settings_submit_button";
            settings_submit_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            settings_submit_button.Size = new System.Drawing.Size(133, 57);
            settings_submit_button.TabIndex = 4;
            settings_submit_button.Text = "Submit";
            settings_submit_button.UseCompatibleTextRendering = true;
            settings_submit_button.UseVisualStyleBackColor = false;
            settings_submit_button.Click += settings_submit_button_Click;
            // 
            // settings_sign_out_button
            // 
            settings_sign_out_button.BackgroundImage = ((System.Drawing.Image)resources.GetObject("settings_sign_out_button.BackgroundImage"));
            settings_sign_out_button.Font = new System.Drawing.Font("Segoe UI", 12F);
            settings_sign_out_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            settings_sign_out_button.Location = new System.Drawing.Point(271, 364);
            settings_sign_out_button.Name = "settings_sign_out_button";
            settings_sign_out_button.Size = new System.Drawing.Size(133, 57);
            settings_sign_out_button.TabIndex = 5;
            settings_sign_out_button.Text = "Sign out";
            settings_sign_out_button.UseCompatibleTextRendering = true;
            settings_sign_out_button.UseVisualStyleBackColor = true;
            settings_sign_out_button.Click += settings_sign_out_button_Click;
            // 
            // settings_new_password_textbox
            // 
            settings_new_password_textbox.BackColor = System.Drawing.Color.Lavender;
            settings_new_password_textbox.Font = new System.Drawing.Font("Segoe UI", 12F);
            settings_new_password_textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            settings_new_password_textbox.Location = new System.Drawing.Point(280, 231);
            settings_new_password_textbox.Name = "settings_new_password_textbox";
            settings_new_password_textbox.PasswordChar = '*';
            settings_new_password_textbox.PlaceholderText = "New Password";
            settings_new_password_textbox.Size = new System.Drawing.Size(142, 55);
            settings_new_password_textbox.TabIndex = 3;
            // 
            // settings_current_password_textbox
            // 
            settings_current_password_textbox.BackColor = System.Drawing.Color.Lavender;
            settings_current_password_textbox.Font = new System.Drawing.Font("Segoe UI", 12F);
            settings_current_password_textbox.Location = new System.Drawing.Point(59, 231);
            settings_current_password_textbox.Name = "settings_current_password_textbox";
            settings_current_password_textbox.PasswordChar = '*';
            settings_current_password_textbox.PlaceholderText = "Current Password";
            settings_current_password_textbox.Size = new System.Drawing.Size(165, 55);
            settings_current_password_textbox.TabIndex = 2;
            // 
            // settings_username_textbox
            // 
            settings_username_textbox.BackColor = System.Drawing.Color.Lavender;
            settings_username_textbox.Font = new System.Drawing.Font("Segoe UI", 12F);
            settings_username_textbox.Location = new System.Drawing.Point(59, 149);
            settings_username_textbox.Name = "settings_username_textbox";
            settings_username_textbox.PlaceholderText = "Username";
            settings_username_textbox.Size = new System.Drawing.Size(133, 55);
            settings_username_textbox.TabIndex = 0;
            // 
            // settings_email_textbox
            // 
            settings_email_textbox.BackColor = System.Drawing.Color.Lavender;
            settings_email_textbox.Font = new System.Drawing.Font("Segoe UI", 12F);
            settings_email_textbox.Location = new System.Drawing.Point(280, 149);
            settings_email_textbox.Name = "settings_email_textbox";
            settings_email_textbox.PlaceholderText = "Email";
            settings_email_textbox.Size = new System.Drawing.Size(133, 55);
            settings_email_textbox.TabIndex = 1;
            // 
            // settings_lbl
            // 
            settings_lbl.AutoSize = true;
            settings_lbl.BackColor = System.Drawing.Color.Transparent;
            settings_lbl.Font = new System.Drawing.Font("Segoe UI", 18F);
            settings_lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            settings_lbl.Location = new System.Drawing.Point(59, 46);
            settings_lbl.Name = "settings_lbl";
            settings_lbl.Size = new System.Drawing.Size(222, 72);
            settings_lbl.TabIndex = 6;
            settings_lbl.Text = "Settings";
            // 
            // Settings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Indigo;
            BackgroundImage = ((System.Drawing.Image)resources.GetObject("$this.BackgroundImage"));
            ClientSize = new System.Drawing.Size(1262, 673);
            Controls.Add(panelSettings);
            ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            Margin = new System.Windows.Forms.Padding(6);
            Text = "Settings";
            panelSettings.ResumeLayout(false);
            panelSettings.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Label settings_lbl;
        private System.Windows.Forms.TextBox settings_new_password_textbox;
        private System.Windows.Forms.TextBox settings_current_password_textbox;
        private System.Windows.Forms.TextBox settings_username_textbox;
        private TextBox settings_email_textbox;
        private System.Windows.Forms.Button settings_sign_out_button;
        private System.Windows.Forms.Button settings_submit_button;
    }
}