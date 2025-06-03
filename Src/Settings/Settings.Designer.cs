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
            settings_panel = new System.Windows.Forms.Panel();
            settings_submit_button = new System.Windows.Forms.Button();
            settings_sign_out_button = new System.Windows.Forms.Button();
            settings_new_password_text_box = new System.Windows.Forms.TextBox();
            settings_current_password_text_box = new System.Windows.Forms.TextBox();
            settings_username_text_box = new System.Windows.Forms.TextBox();
            settings_email_text_box = new System.Windows.Forms.TextBox();
            settings_label = new System.Windows.Forms.Label();
            settings_panel.SuspendLayout();
            SuspendLayout();
            //
            // settings_panel
            //
            settings_panel.BackColor = System.Drawing.Color.GhostWhite;
            settings_panel.BackgroundImage = ((System.Drawing.Image)resources.GetObject("settings_panel.BackgroundImage"));
            settings_panel.Controls.Add(settings_submit_button);
            settings_panel.Controls.Add(settings_sign_out_button);
            settings_panel.Controls.Add(settings_new_password_text_box);
            settings_panel.Controls.Add(settings_current_password_text_box);
            settings_panel.Controls.Add(settings_username_text_box);
            settings_panel.Controls.Add(settings_email_text_box);
            settings_panel.Controls.Add(settings_label);
            settings_panel.Location = new System.Drawing.Point(368, 57);
            settings_panel.Name = "settings_panel";
            settings_panel.Size = new System.Drawing.Size(510, 510);
            settings_panel.TabIndex = 0;
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
            // settings_new_password_text_box
            //
            settings_new_password_text_box.BackColor = System.Drawing.Color.Lavender;
            settings_new_password_text_box.Font = new System.Drawing.Font("Segoe UI", 12F);
            settings_new_password_text_box.ForeColor = System.Drawing.SystemColors.WindowText;
            settings_new_password_text_box.Location = new System.Drawing.Point(280, 231);
            settings_new_password_text_box.Name = "settings_new_password_text_box";
            settings_new_password_text_box.PasswordChar = '*';
            settings_new_password_text_box.PlaceholderText = "New Password";
            settings_new_password_text_box.Size = new System.Drawing.Size(142, 55);
            settings_new_password_text_box.TabIndex = 3;
            //
            // settings_current_password_text_box
            //
            settings_current_password_text_box.BackColor = System.Drawing.Color.Lavender;
            settings_current_password_text_box.Font = new System.Drawing.Font("Segoe UI", 12F);
            settings_current_password_text_box.Location = new System.Drawing.Point(59, 231);
            settings_current_password_text_box.Name = "settings_current_password_text_box";
            settings_current_password_text_box.PasswordChar = '*';
            settings_current_password_text_box.PlaceholderText = "Current Password";
            settings_current_password_text_box.Size = new System.Drawing.Size(165, 55);
            settings_current_password_text_box.TabIndex = 2;
            //
            // settings_username_text_box
            //
            settings_username_text_box.BackColor = System.Drawing.Color.Lavender;
            settings_username_text_box.Font = new System.Drawing.Font("Segoe UI", 12F);
            settings_username_text_box.Location = new System.Drawing.Point(59, 149);
            settings_username_text_box.Name = "settings_username_text_box";
            settings_username_text_box.PlaceholderText = "Username";
            settings_username_text_box.Size = new System.Drawing.Size(133, 55);
            settings_username_text_box.TabIndex = 0;
            //
            // settings_email_text_box
            //
            settings_email_text_box.BackColor = System.Drawing.Color.Lavender;
            settings_email_text_box.Font = new System.Drawing.Font("Segoe UI", 12F);
            settings_email_text_box.Location = new System.Drawing.Point(280, 149);
            settings_email_text_box.Name = "settings_email_text_box";
            settings_email_text_box.PlaceholderText = "Email";
            settings_email_text_box.Size = new System.Drawing.Size(133, 55);
            settings_email_text_box.TabIndex = 1;
            //
            // settings_label
            //
            settings_label.AutoSize = true;
            settings_label.BackColor = System.Drawing.Color.Transparent;
            settings_label.Font = new System.Drawing.Font("Segoe UI", 18F);
            settings_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            settings_label.Location = new System.Drawing.Point(59, 46);
            settings_label.Name = "settings_label";
            settings_label.Size = new System.Drawing.Size(222, 72);
            settings_label.TabIndex = 6;
            settings_label.Text = "Settings";
            //
            // Settings
            //
            AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Indigo;
            BackgroundImage = ((System.Drawing.Image)resources.GetObject("$this.BackgroundImage"));
            ClientSize = new System.Drawing.Size(1252, 641);
            Controls.Add(settings_panel);
            ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            Margin = new System.Windows.Forms.Padding(6);
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
    }
}