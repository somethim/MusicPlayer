using System.ComponentModel;

namespace MusicPlayer.Auth;

partial class SignUp
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(SignUp));
        sign_up_email_text_box = new TextBox();
        sign_up_password_text_box = new TextBox();
        sign_up_username_text_box = new TextBox();
        sign_up_confirm_password_text_box = new TextBox();
        sign_up_button = new Button();
        label1 = new Label();
        sign_in_redirect_label = new Label();
        panel1 = new Panel();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // sign_up_email_text_box
        // 
        sign_up_email_text_box.Font = new Font("Segoe UI", 12F);
        sign_up_email_text_box.Location = new Point(92, 79);
        sign_up_email_text_box.Margin = new Padding(2);
        sign_up_email_text_box.Name = "sign_up_email_text_box";
        sign_up_email_text_box.PlaceholderText = "Email";
        sign_up_email_text_box.Size = new Size(199, 34);
        sign_up_email_text_box.TabIndex = 0;
        // 
        // sign_up_password_text_box
        // 
        sign_up_password_text_box.Font = new Font("Segoe UI", 12F);
        sign_up_password_text_box.Location = new Point(92, 162);
        sign_up_password_text_box.Margin = new Padding(2);
        sign_up_password_text_box.Name = "sign_up_password_text_box";
        sign_up_password_text_box.PasswordChar = '*';
        sign_up_password_text_box.PlaceholderText = "Password";
        sign_up_password_text_box.Size = new Size(199, 34);
        sign_up_password_text_box.TabIndex = 2;
        // 
        // sign_up_username_text_box
        // 
        sign_up_username_text_box.Font = new Font("Segoe UI", 12F);
        sign_up_username_text_box.Location = new Point(368, 79);
        sign_up_username_text_box.Margin = new Padding(2);
        sign_up_username_text_box.Name = "sign_up_username_text_box";
        sign_up_username_text_box.PlaceholderText = "Username";
        sign_up_username_text_box.Size = new Size(199, 34);
        sign_up_username_text_box.TabIndex = 1;
        // 
        // sign_up_confirm_password_text_box
        // 
        sign_up_confirm_password_text_box.Font = new Font("Segoe UI", 12F);
        sign_up_confirm_password_text_box.Location = new Point(368, 162);
        sign_up_confirm_password_text_box.Margin = new Padding(2);
        sign_up_confirm_password_text_box.Name = "sign_up_confirm_password_text_box";
        sign_up_confirm_password_text_box.PasswordChar = '*';
        sign_up_confirm_password_text_box.PlaceholderText = "Confirm Password";
        sign_up_confirm_password_text_box.Size = new Size(199, 34);
        sign_up_confirm_password_text_box.TabIndex = 3;
        // 
        // sign_up_button
        // 
        sign_up_button.BackgroundImage = (Image)resources.GetObject("sign_up_button.BackgroundImage");
        sign_up_button.Font = new Font("Segoe UI", 12F);
        sign_up_button.Location = new Point(92, 257);
        sign_up_button.Margin = new Padding(2);
        sign_up_button.Name = "sign_up_button";
        sign_up_button.Size = new Size(112, 52);
        sign_up_button.TabIndex = 4;
        sign_up_button.Text = "Sign Up";
        sign_up_button.UseVisualStyleBackColor = true;
        sign_up_button.Click += sign_up_button_Click;
        // 
        // label1
        // 
        label1.Font = new Font("Segoe UI", 12F);
        label1.ImageAlign = ContentAlignment.MiddleLeft;
        label1.Location = new Point(553, 458);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(237, 30);
        label1.TabIndex = 6;
        label1.Text = "Already have an account?";
        // 
        // sign_in_redirect_label
        // 
        sign_in_redirect_label.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        sign_in_redirect_label.ImageAlign = ContentAlignment.MiddleLeft;
        sign_in_redirect_label.Location = new Point(809, 456);
        sign_in_redirect_label.Margin = new Padding(2, 0, 2, 0);
        sign_in_redirect_label.Name = "sign_in_redirect_label";
        sign_in_redirect_label.Size = new Size(85, 32);
        sign_in_redirect_label.TabIndex = 5;
        sign_in_redirect_label.Text = "Sign In";
        sign_in_redirect_label.Click += sign_in_redirect_label_Click;
        // 
        // panel1
        // 
        panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
        panel1.BackgroundImageLayout = ImageLayout.None;
        panel1.Controls.Add(sign_up_email_text_box);
        panel1.Controls.Add(sign_up_username_text_box);
        panel1.Controls.Add(sign_up_password_text_box);
        panel1.Controls.Add(sign_up_button);
        panel1.Controls.Add(sign_up_confirm_password_text_box);
        panel1.Location = new Point(301, 109);
        panel1.Name = "panel1";
        panel1.Size = new Size(687, 431);
        panel1.TabIndex = 7;
        // 
        // SignUp
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(30, 30, 50);
        ClientSize = new Size(1262, 673);
        Controls.Add(panel1);
        Controls.Add(sign_in_redirect_label);
        Controls.Add(label1);
        Location = new Point(34, 34);
        Margin = new Padding(2);
        Name = "SignUp";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.TextBox sign_up_email_text_box;
    private System.Windows.Forms.TextBox sign_up_password_text_box;
    private System.Windows.Forms.TextBox sign_up_username_text_box;
    private System.Windows.Forms.TextBox sign_up_confirm_password_text_box;
    private System.Windows.Forms.Button sign_up_button;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label sign_in_redirect_label;

    #endregion

    private Panel panel1;
}