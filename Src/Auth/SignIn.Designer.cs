namespace MusicPlayer.Auth
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            sign_up_redirect_label = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            sign_in_password_text_box = new System.Windows.Forms.TextBox();
            sign_in_username_email_text_box = new System.Windows.Forms.TextBox();
            sign_in_button = new System.Windows.Forms.Button();
            sign_in_panel = new System.Windows.Forms.Panel();
            SuspendLayout();
            // 
            // sign_up_redirect_label
            // 
            sign_up_redirect_label.BackColor = System.Drawing.Color.Transparent;
            sign_up_redirect_label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            sign_up_redirect_label.ForeColor = System.Drawing.SystemColors.WindowText;
            sign_up_redirect_label.Location = new System.Drawing.Point(921, 438);
            sign_up_redirect_label.Name = "sign_up_redirect_label";
            sign_up_redirect_label.Size = new System.Drawing.Size(159, 60);
            sign_up_redirect_label.TabIndex = 3;
            sign_up_redirect_label.Text = "Sign Up";
            sign_up_redirect_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            sign_up_redirect_label.Click += sign_up_redirect_label_Click;
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label1.Location = new System.Drawing.Point(500, 443);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(415, 56);
            label1.TabIndex = 6;
            label1.Text = "Don\'t have an account?";
            // 
            // sign_in_password_text_box
            // 
            sign_in_password_text_box.Font = new System.Drawing.Font("Segoe UI", 12F);
            sign_in_password_text_box.Location = new System.Drawing.Point(131, 326);
            sign_in_password_text_box.Name = "sign_in_password_text_box";
            sign_in_password_text_box.PasswordChar = '*';
            sign_in_password_text_box.PlaceholderText = "Password";
            sign_in_password_text_box.Size = new System.Drawing.Size(370, 55);
            sign_in_password_text_box.TabIndex = 1;
            // 
            // sign_in_username_email_text_box
            // 
            sign_in_username_email_text_box.Font = new System.Drawing.Font("Segoe UI", 12F);
            sign_in_username_email_text_box.Location = new System.Drawing.Point(251, 108);
            sign_in_username_email_text_box.Name = "sign_in_username_email_text_box";
            sign_in_username_email_text_box.PlaceholderText = "Username or Email";
            sign_in_username_email_text_box.Size = new System.Drawing.Size(370, 55);
            sign_in_username_email_text_box.TabIndex = 0;
            // 
            // sign_in_button
            // 
            sign_in_button.BackColor = System.Drawing.Color.Transparent;
            sign_in_button.BackgroundImage = ((System.Drawing.Image)resources.GetObject("sign_in_button.BackgroundImage"));
            sign_in_button.Font = new System.Drawing.Font("Segoe UI", 12F);
            sign_in_button.Location = new System.Drawing.Point(208, 439);
            sign_in_button.Name = "sign_in_button";
            sign_in_button.Size = new System.Drawing.Size(133, 57);
            sign_in_button.TabIndex = 2;
            sign_in_button.Text = "Sign In";
            sign_in_button.UseVisualStyleBackColor = false;
            sign_in_button.Click += sign_in_button_Click;
            // 
            // sign_in_panel
            // 
            sign_in_panel.BackColor = System.Drawing.Color.Transparent;
            sign_in_panel.BackgroundImage = ((System.Drawing.Image)resources.GetObject("sign_in_panel.BackgroundImage"));
            sign_in_panel.Location = new System.Drawing.Point(368, 57);
            sign_in_panel.Name = "sign_in_panel";
            sign_in_panel.Size = new System.Drawing.Size(510, 510);
            sign_in_panel.TabIndex = 7;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            BackgroundImage = ((System.Drawing.Image)resources.GetObject("$this.BackgroundImage"));
            ClientSize = new System.Drawing.Size(1252, 641);
            Controls.Add(sign_in_panel);
            Controls.Add(sign_in_button);
            Controls.Add(sign_in_username_email_text_box);
            Controls.Add(sign_in_password_text_box);
            Controls.Add(label1);
            Controls.Add(sign_up_redirect_label);
            Location = new System.Drawing.Point(34, 34);
            Margin = new System.Windows.Forms.Padding(6);
            Text = "Sign In";
            Load += SignIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Panel sign_in_panel;

        private System.Windows.Forms.Button sign_in_button;
        private System.Windows.Forms.TextBox sign_in_username_email_text_box;
        private System.Windows.Forms.TextBox sign_in_password_text_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sign_up_redirect_label;

        #endregion
    }
}