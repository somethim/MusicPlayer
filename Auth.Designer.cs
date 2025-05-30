namespace MusicPlayer
{
    partial class Auth
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
            sign_up_button = new Button();
            SuspendLayout();
            // 
            // sign_up_button
            // 
            sign_up_button.Location = new Point(380, 249);
            sign_up_button.Name = "sign_up_button";
            sign_up_button.Size = new Size(178, 38);
            sign_up_button.TabIndex = 0;
            sign_up_button.Text = "Continue";
            sign_up_button.UseVisualStyleBackColor = true;
            sign_up_button.Click += sign_up_button_Click;
            // 
            // Auth
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sign_up_button);
            Name = "Auth";
            Text = "Sign In";
            Load += Auth_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button sign_up_button;
    }
}