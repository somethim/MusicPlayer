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
            sign_up_redirect_label = new Label();
            label1 = new Label();
            sign_in_password_text_box = new TextBox();
            sign_in_username_email_text_box = new TextBox();
            sign_in_button = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sign_up_redirect_label
            // 
            sign_up_redirect_label.BackColor = Color.Transparent;
            sign_up_redirect_label.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            sign_up_redirect_label.ForeColor = Color.LightSteelBlue;
            sign_up_redirect_label.Location = new Point(309, 306);
            sign_up_redirect_label.Margin = new Padding(2, 0, 2, 0);
            sign_up_redirect_label.Name = "sign_up_redirect_label";
            sign_up_redirect_label.Size = new Size(85, 32);
            sign_up_redirect_label.TabIndex = 3;
            sign_up_redirect_label.Text = "Sign Up";
            sign_up_redirect_label.TextAlign = ContentAlignment.MiddleLeft;
            sign_up_redirect_label.Click += sign_up_redirect_label_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.WhiteSmoke;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(84, 308);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(221, 30);
            label1.TabIndex = 6;
            label1.Text = "Don't have an account?";
            // 
            // sign_in_password_text_box
            // 
            sign_in_password_text_box.Font = new Font("Segoe UI", 12F);
            sign_in_password_text_box.Location = new Point(84, 162);
            sign_in_password_text_box.Margin = new Padding(2);
            sign_in_password_text_box.Name = "sign_in_password_text_box";
            sign_in_password_text_box.PasswordChar = '*';
            sign_in_password_text_box.PlaceholderText = "Password";
            sign_in_password_text_box.Size = new Size(199, 34);
            sign_in_password_text_box.TabIndex = 1;
            //
            // sign_in_username_email_text_box
            // 
            sign_in_username_email_text_box.Font = new Font("Segoe UI", 12F);
            sign_in_username_email_text_box.Location = new Point(84, 80);
            sign_in_username_email_text_box.Margin = new Padding(2);
            sign_in_username_email_text_box.Name = "sign_in_username_email_text_box";
            sign_in_username_email_text_box.PlaceholderText = "Username or Email";
            sign_in_username_email_text_box.Size = new Size(199, 34);
            sign_in_username_email_text_box.TabIndex = 0;
            // 
            // sign_in_button
            // 
            sign_in_button.BackColor = Color.Transparent;
            sign_in_button.BackgroundImage = (Image)resources.GetObject("sign_in_button.BackgroundImage");
            sign_in_button.Font = new Font("Segoe UI", 12F);
            sign_in_button.ForeColor = SystemColors.ControlLight;
            sign_in_button.Location = new Point(84, 243);
            sign_in_button.Margin = new Padding(2);
            sign_in_button.Name = "sign_in_button";
            sign_in_button.Size = new Size(112, 52);
            sign_in_button.TabIndex = 2;
            sign_in_button.Text = "Sign In";
            sign_in_button.UseVisualStyleBackColor = false;
            sign_in_button.Click += sign_in_button_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(sign_up_redirect_label);
            panel1.Controls.Add(sign_in_password_text_box);
            panel1.Controls.Add(sign_in_username_email_text_box);
            panel1.Controls.Add(sign_in_button);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(300, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(687, 431);
            panel1.TabIndex = 7;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 50);
            ClientSize = new Size(1262, 673);
            Controls.Add(panel1);
            Location = new Point(34, 34);
            Name = "SignIn";
            Text = "Sign In";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button sign_in_button;
        private System.Windows.Forms.TextBox sign_in_username_email_text_box;
        private System.Windows.Forms.TextBox sign_in_password_text_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sign_up_redirect_label;

        #endregion

        private Panel panel1;
    }
}