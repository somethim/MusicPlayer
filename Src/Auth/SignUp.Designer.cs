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
        sign_up_email_text_box = new System.Windows.Forms.TextBox();
        sign_up_password_text_box = new System.Windows.Forms.TextBox();
        sign_up_username_text_box = new System.Windows.Forms.TextBox();
        sign_up_confirm_password_text_box = new System.Windows.Forms.TextBox();
        sign_up_button = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        sign_in_redirect_label = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // sign_up_email_text_box
        // 
        sign_up_email_text_box.Font = new System.Drawing.Font("Segoe UI", 12F);
        sign_up_email_text_box.Location = new System.Drawing.Point(125, 88);
        sign_up_email_text_box.Name = "sign_up_email_text_box";
        sign_up_email_text_box.PlaceholderText = "Email";
        sign_up_email_text_box.Size = new System.Drawing.Size(370, 55);
        sign_up_email_text_box.TabIndex = 0;
        // 
        // sign_up_password_text_box
        // 
        sign_up_password_text_box.Font = new System.Drawing.Font("Segoe UI", 12F);
        sign_up_password_text_box.Location = new System.Drawing.Point(125, 252);
        sign_up_password_text_box.Name = "sign_up_password_text_box";
        sign_up_password_text_box.PasswordChar = '*';
        sign_up_password_text_box.PlaceholderText = "Password";
        sign_up_password_text_box.Size = new System.Drawing.Size(370, 55);
        sign_up_password_text_box.TabIndex = 2;
        // 
        // sign_up_username_text_box
        // 
        sign_up_username_text_box.Font = new System.Drawing.Font("Segoe UI", 12F);
        sign_up_username_text_box.Location = new System.Drawing.Point(125, 167);
        sign_up_username_text_box.Name = "sign_up_username_text_box";
        sign_up_username_text_box.PlaceholderText = "Username";
        sign_up_username_text_box.Size = new System.Drawing.Size(370, 55);
        sign_up_username_text_box.TabIndex = 1;
        // 
        // sign_up_confirm_password_text_box
        // 
        sign_up_confirm_password_text_box.Font = new System.Drawing.Font("Segoe UI", 12F);
        sign_up_confirm_password_text_box.Location = new System.Drawing.Point(125, 330);
        sign_up_confirm_password_text_box.Name = "sign_up_confirm_password_text_box";
        sign_up_confirm_password_text_box.PasswordChar = '*';
        sign_up_confirm_password_text_box.PlaceholderText = "Confirm Password";
        sign_up_confirm_password_text_box.Size = new System.Drawing.Size(370, 55);
        sign_up_confirm_password_text_box.TabIndex = 3;
        // 
        // sign_up_button
        // 
        sign_up_button.Font = new System.Drawing.Font("Segoe UI", 12F);
        sign_up_button.Location = new System.Drawing.Point(125, 453);
        sign_up_button.Name = "sign_up_button";
        sign_up_button.Size = new System.Drawing.Size(133, 57);
        sign_up_button.TabIndex = 4;
        sign_up_button.Text = "Sign Up";
        sign_up_button.UseVisualStyleBackColor = true;
        sign_up_button.Click += sign_up_button_Click;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 12F);
        label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        label1.Location = new System.Drawing.Point(500, 453);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(444, 56);
        label1.TabIndex = 6;
        label1.Text = "Already have an account?";
        // 
        // sign_in_redirect_label
        // 
        sign_in_redirect_label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        sign_in_redirect_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        sign_in_redirect_label.Location = new System.Drawing.Point(924, 453);
        sign_in_redirect_label.Name = "sign_in_redirect_label";
        sign_in_redirect_label.Size = new System.Drawing.Size(159, 60);
        sign_in_redirect_label.TabIndex = 5;
        sign_in_redirect_label.Text = "Sign In";
        sign_in_redirect_label.Click += sign_in_redirect_label_Click;
        // 
        // SignUp
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(1252, 641);
        Controls.Add(sign_in_redirect_label);
        Controls.Add(label1);
        Controls.Add(sign_up_button);
        Controls.Add(sign_up_confirm_password_text_box);
        Controls.Add(sign_up_username_text_box);
        Controls.Add(sign_up_password_text_box);
        Controls.Add(sign_up_email_text_box);
        Location = new System.Drawing.Point(34, 34);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox sign_up_email_text_box;
    private System.Windows.Forms.TextBox sign_up_password_text_box;
    private System.Windows.Forms.TextBox sign_up_username_text_box;
    private System.Windows.Forms.TextBox sign_up_confirm_password_text_box;
    private System.Windows.Forms.Button sign_up_button;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label sign_in_redirect_label;

    #endregion
}