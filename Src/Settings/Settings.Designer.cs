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
            settings_panel = new Panel();
            settings_submit_button = new Button();
            settings_sign_out_button = new Button();
            settings_new_password_text_box = new TextBox();
            settings_current_password_text_box = new TextBox();
            settings_username_text_box = new TextBox();
            settings_email_text_box = new TextBox();
            settings_label = new Label();
            dashboard_button = new Button();
            settings_button = new Button();
            settings_panel.SuspendLayout();
            SuspendLayout();
            // 
            // settings_panel
            // 
            settings_panel.BackColor = Color.GhostWhite;
            settings_panel.BackgroundImage = (Image)resources.GetObject("settings_panel.BackgroundImage");
            settings_panel.Controls.Add(settings_submit_button);
            settings_panel.Controls.Add(settings_sign_out_button);
            settings_panel.Controls.Add(settings_new_password_text_box);
            settings_panel.Controls.Add(settings_current_password_text_box);
            settings_panel.Controls.Add(settings_username_text_box);
            settings_panel.Controls.Add(settings_email_text_box);
            settings_panel.Controls.Add(settings_label);
            settings_panel.Location = new Point(331, 69);
            settings_panel.Margin = new Padding(2);
            settings_panel.Name = "settings_panel";
            settings_panel.Size = new Size(569, 522);
            settings_panel.TabIndex = 0;
            // 
            // settings_submit_button
            // 
            settings_submit_button.BackColor = Color.LavenderBlush;
            settings_submit_button.Font = new Font("Segoe UI", 12F);
            settings_submit_button.ForeColor = Color.Transparent;
            settings_submit_button.Image = (Image)resources.GetObject("settings_submit_button.Image");
            settings_submit_button.Location = new Point(103, 404);
            settings_submit_button.Margin = new Padding(2);
            settings_submit_button.Name = "settings_submit_button";
            settings_submit_button.RightToLeft = RightToLeft.No;
            settings_submit_button.Size = new Size(112, 51);
            settings_submit_button.TabIndex = 4;
            settings_submit_button.Text = "Submit";
            settings_submit_button.UseCompatibleTextRendering = true;
            settings_submit_button.UseVisualStyleBackColor = false;
            settings_submit_button.Click += settings_submit_button_Click;
            // 
            // settings_sign_out_button
            // 
            settings_sign_out_button.Font = new Font("Segoe UI", 12F);
            settings_sign_out_button.ForeColor = SystemColors.ButtonFace;
            settings_sign_out_button.Image = (Image)resources.GetObject("settings_sign_out_button.Image");
            settings_sign_out_button.Location = new Point(328, 403);
            settings_sign_out_button.Margin = new Padding(2);
            settings_sign_out_button.Name = "settings_sign_out_button";
            settings_sign_out_button.Size = new Size(112, 52);
            settings_sign_out_button.TabIndex = 5;
            settings_sign_out_button.Text = "Sign out";
            settings_sign_out_button.UseCompatibleTextRendering = true;
            settings_sign_out_button.UseVisualStyleBackColor = true;
            settings_sign_out_button.Click += settings_sign_out_button_Click;
            // 
            // settings_new_password_text_box
            // 
            settings_new_password_text_box.BackColor = Color.Lavender;
            settings_new_password_text_box.Font = new Font("Segoe UI", 12F);
            settings_new_password_text_box.ForeColor = SystemColors.WindowText;
            settings_new_password_text_box.Location = new Point(311, 237);
            settings_new_password_text_box.Margin = new Padding(2);
            settings_new_password_text_box.Name = "settings_new_password_text_box";
            settings_new_password_text_box.PasswordChar = '*';
            settings_new_password_text_box.PlaceholderText = "New Password";
            settings_new_password_text_box.Size = new Size(162, 34);
            settings_new_password_text_box.TabIndex = 3;
            // 
            // settings_current_password_text_box
            // 
            settings_current_password_text_box.BackColor = Color.Lavender;
            settings_current_password_text_box.Font = new Font("Segoe UI", 12F);
            settings_current_password_text_box.Location = new Point(85, 237);
            settings_current_password_text_box.Margin = new Padding(2);
            settings_current_password_text_box.Name = "settings_current_password_text_box";
            settings_current_password_text_box.PasswordChar = '*';
            settings_current_password_text_box.PlaceholderText = "Current Password";
            settings_current_password_text_box.Size = new Size(162, 34);
            settings_current_password_text_box.TabIndex = 2;
            // 
            // settings_username_text_box
            // 
            settings_username_text_box.BackColor = Color.Lavender;
            settings_username_text_box.Font = new Font("Segoe UI", 12F);
            settings_username_text_box.Location = new Point(85, 140);
            settings_username_text_box.Margin = new Padding(2);
            settings_username_text_box.Name = "settings_username_text_box";
            settings_username_text_box.PlaceholderText = "Username";
            settings_username_text_box.Size = new Size(162, 34);
            settings_username_text_box.TabIndex = 0;
            // 
            // settings_email_text_box
            // 
            settings_email_text_box.BackColor = Color.Lavender;
            settings_email_text_box.Font = new Font("Segoe UI", 12F);
            settings_email_text_box.Location = new Point(311, 140);
            settings_email_text_box.Margin = new Padding(2);
            settings_email_text_box.Name = "settings_email_text_box";
            settings_email_text_box.PlaceholderText = "Email";
            settings_email_text_box.Size = new Size(162, 34);
            settings_email_text_box.TabIndex = 1;
            // 
            // settings_label
            // 
            settings_label.AutoSize = true;
            settings_label.BackColor = Color.Transparent;
            settings_label.Font = new Font("Segoe UI", 20F);
            settings_label.ForeColor = SystemColors.ButtonFace;
            settings_label.Location = new Point(31, 25);
            settings_label.Margin = new Padding(2, 0, 2, 0);
            settings_label.Name = "settings_label";
            settings_label.Size = new Size(141, 46);
            settings_label.TabIndex = 6;
            settings_label.Text = "Settings";
            //
            // dashboard_button
            //
            dashboard_button.BackgroundImage = (Image)resources.GetObject("dashboard_button.BackgroundImage");
            dashboard_button.Location = new Point(691, 21);
            dashboard_button.Name = "dashboard_button";
            dashboard_button.Size = new Size(94, 29);
            dashboard_button.TabIndex = 5;
            dashboard_button.Text = "Dashboard";
            dashboard_button.UseVisualStyleBackColor = true;
            dashboard_button.Click += dashboard_button_Click;
            //
            // settings_button
            //
            settings_button.BackgroundImage = (Image)resources.GetObject("settings_button.BackgroundImage");
            settings_button.Location = new Point(814, 21);
            settings_button.Name = "settings_button";
            settings_button.Size = new Size(94, 29);
            settings_button.TabIndex = 7;
            settings_button.Text = "Settings";
            settings_button.UseVisualStyleBackColor = true;
            settings_button.Click += settings_button_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 50);
            ClientSize = new Size(1262, 673);
            Controls.Add(settings_panel);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Settings";
            Text = "Settings";
            settings_panel.ResumeLayout(false);
            settings_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel settings_panel;
        private System.Windows.Forms.Label settings_label;
        private System.Windows.Forms.TextBox settings_new_password_text_box;
        private System.Windows.Forms.TextBox settings_current_password_text_box;
        private System.Windows.Forms.TextBox settings_username_text_box;
        private TextBox settings_email_text_box;
        private System.Windows.Forms.Button settings_sign_out_button;
        private System.Windows.Forms.Button settings_submit_button;
        private Button dashboard_button;
        private Button settings_button;
    }
}