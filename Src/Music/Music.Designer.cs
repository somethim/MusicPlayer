namespace MusicPlayer.Music
{
    partial class Music
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
            music_playlist_lbl = new Label();
            music_playlist_elements_panel = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            music_listView = new ListView();
            music_play_button = new PictureBox();
            music_next_song_button = new PictureBox();
            music_previous_song_button = new PictureBox();
            music_playlist_elements_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)music_play_button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)music_next_song_button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)music_previous_song_button).BeginInit();
            SuspendLayout();
            // 
            // music_playlist_lbl
            // 
            music_playlist_lbl.AutoSize = true;
            music_playlist_lbl.BackColor = Color.Transparent;
            music_playlist_lbl.Font = new Font("Segoe UI", 18F);
            music_playlist_lbl.ForeColor = SystemColors.ButtonHighlight;
            music_playlist_lbl.Location = new Point(84, 17);
            music_playlist_lbl.Margin = new Padding(6, 0, 6, 0);
            music_playlist_lbl.Name = "music_playlist_lbl";
            music_playlist_lbl.Size = new Size(315, 72);
            music_playlist_lbl.TabIndex = 0;
            music_playlist_lbl.Text = "Your Playlist";
            // 
            // music_playlist_elements_panel
            // 
            music_playlist_elements_panel.Controls.Add(pictureBox2);
            music_playlist_elements_panel.Controls.Add(pictureBox1);
            music_playlist_elements_panel.Controls.Add(music_listView);
            music_playlist_elements_panel.Location = new Point(128, 107);
            music_playlist_elements_panel.Margin = new Padding(6);
            music_playlist_elements_panel.Name = "music_playlist_elements_panel";
            music_playlist_elements_panel.Size = new Size(2134, 938);
            music_playlist_elements_panel.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DimGray;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(159, 416);
            pictureBox2.Margin = new Padding(6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(360, 324);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(-41, -78);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(746, 1010);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // music_listView
            // 
            music_listView.BackColor = Color.FromArgb(220, 220, 240);
            music_listView.Location = new Point(705, 65);
            music_listView.Margin = new Padding(6);
            music_listView.Name = "music_listView";
            music_listView.Size = new Size(1337, 803);
            music_listView.TabIndex = 0;
            music_listView.UseCompatibleStateImageBehavior = false;
            // 
            // music_play_button
            // 
            music_play_button.BackColor = Color.Transparent;
            music_play_button.BackgroundImageLayout = ImageLayout.Stretch;
            music_play_button.Location = new Point(1391, 1056);
            music_play_button.Margin = new Padding(6);
            music_play_button.Name = "music_play_button";
            music_play_button.Size = new Size(212, 204);
            music_play_button.TabIndex = 3;
            music_play_button.TabStop = false;
            music_play_button.Click += music_play_button_Click;
            // 
            // music_next_song_button
            // 
            music_next_song_button.BackColor = Color.Transparent;
            music_next_song_button.BackgroundImageLayout = ImageLayout.Stretch;
            music_next_song_button.Location = new Point(1648, 1056);
            music_next_song_button.Margin = new Padding(6);
            music_next_song_button.Name = "music_next_song_button";
            music_next_song_button.Size = new Size(212, 204);
            music_next_song_button.TabIndex = 4;
            music_next_song_button.TabStop = false;
            music_next_song_button.Click += music_next_song_button_Click;
            // 
            // music_previous_song_button
            // 
            music_previous_song_button.BackColor = Color.Transparent;
            music_previous_song_button.BackgroundImageLayout = ImageLayout.Stretch;
            music_previous_song_button.Location = new Point(1119, 1056);
            music_previous_song_button.Margin = new Padding(6);
            music_previous_song_button.Name = "music_previous_song_button";
            music_previous_song_button.Size = new Size(212, 204);
            music_previous_song_button.TabIndex = 4;
            music_previous_song_button.TabStop = false;
            music_previous_song_button.Click += music_previous_song_button_Click;
            // 
            // Music
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 50);
            ClientSize = new Size(2366, 1245);
            Controls.Add(music_previous_song_button);
            Controls.Add(music_next_song_button);
            Controls.Add(music_play_button);
            Controls.Add(music_playlist_elements_panel);
            Controls.Add(music_playlist_lbl);
            Margin = new Padding(6);
            Name = "Music";
            music_playlist_elements_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)music_play_button).EndInit();
            ((System.ComponentModel.ISupportInitialize)music_next_song_button).EndInit();
            ((System.ComponentModel.ISupportInitialize)music_previous_song_button).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label music_playlist_lbl;
        private Panel music_playlist_elements_panel;
        private ListView music_listView;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox music_play_button;
        private PictureBox music_next_song_button;
        private PictureBox music_previous_song_button;
    }
}