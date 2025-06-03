namespace MusicPlayer
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            welcomeLabel = new Label();
            profilePic = new PictureBox();
            searchBox = new TextBox();
            featuredPanel = new Panel();
            nextButton = new Button();
            featuredSubtitle = new Label();
            featuredTitle = new Label();
            discoverLabel = new Label();
            songList = new FlowLayoutPanel();
            songPanel = new Panel();
            songArtist = new Label();
            songTitle = new Label();
            songArtwork = new PictureBox();
            progressBar = new ProgressBar();
            playerPanel = new Panel();
            playButton = new Button();
            likeButton = new Button();
            dashboardCurrentSongs = new Label();
            playerSong = new Label();
            playerArtwork = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)profilePic).BeginInit();
            featuredPanel.SuspendLayout();
            songList.SuspendLayout();
            songPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)songArtwork).BeginInit();
            playerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)playerArtwork).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(36, 36);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLabel.ForeColor = Color.White;
            welcomeLabel.Location = new Point(11, 11);
            welcomeLabel.Margin = new Padding(2, 0, 2, 0);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(202, 32);
            welcomeLabel.TabIndex = 1;
            welcomeLabel.Text = "Welcome,Sara";
            // 
            // profilePic
            // 
            profilePic.BackColor = Color.Gray;
            profilePic.Location = new Point(258, 19);
            profilePic.Margin = new Padding(2, 2, 2, 2);
            profilePic.Name = "profilePic";
            profilePic.Size = new Size(18, 22);
            profilePic.SizeMode = PictureBoxSizeMode.StretchImage;
            profilePic.TabIndex = 2;
            profilePic.TabStop = false;
            profilePic.Click += pictureBox1_Click;
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.FromArgb(50, 50, 70);
            searchBox.BorderStyle = BorderStyle.None;
            searchBox.ForeColor = Color.Gray;
            searchBox.Location = new Point(11, 43);
            searchBox.Margin = new Padding(2, 2, 2, 2);
            searchBox.Multiline = true;
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(216, 21);
            searchBox.TabIndex = 3;
            // 
            // featuredPanel
            // 
            featuredPanel.AutoSize = true;
            featuredPanel.BackColor = Color.FromArgb(50, 50, 80);
            featuredPanel.Controls.Add(nextButton);
            featuredPanel.Controls.Add(featuredSubtitle);
            featuredPanel.Controls.Add(featuredTitle);
            featuredPanel.ImeMode = ImeMode.NoControl;
            featuredPanel.Location = new Point(11, 83);
            featuredPanel.Margin = new Padding(2, 2, 2, 2);
            featuredPanel.Name = "featuredPanel";
            featuredPanel.Size = new Size(272, 83);
            featuredPanel.TabIndex = 4;
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.FromArgb(100, 50, 200);
            nextButton.FlatAppearance.BorderSize = 0;
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nextButton.ForeColor = Color.White;
            nextButton.Location = new Point(225, 59);
            nextButton.Margin = new Padding(2, 2, 2, 2);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(18, 22);
            nextButton.TabIndex = 5;
            nextButton.Text = "→";
            nextButton.UseVisualStyleBackColor = false;
            // 
            // featuredSubtitle
            // 
            featuredSubtitle.AutoSize = true;
            featuredSubtitle.Font = new Font("Arial Narrow", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            featuredSubtitle.ForeColor = Color.LightGray;
            featuredSubtitle.Location = new Point(0, 42);
            featuredSubtitle.Margin = new Padding(2, 0, 2, 0);
            featuredSubtitle.Name = "featuredSubtitle";
            featuredSubtitle.Size = new Size(269, 17);
            featuredSubtitle.TabIndex = 6;
            featuredSubtitle.Text = "Top songs being discoverd around the world right now";
            // 
            // featuredTitle
            // 
            featuredTitle.AutoSize = true;
            featuredTitle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            featuredTitle.ForeColor = Color.White;
            featuredTitle.Location = new Point(2, 7);
            featuredTitle.Margin = new Padding(2, 0, 2, 0);
            featuredTitle.Name = "featuredTitle";
            featuredTitle.Size = new Size(218, 24);
            featuredTitle.TabIndex = 5;
            featuredTitle.Text = "Go find your favorites";
            // 
            // discoverLabel
            // 
            discoverLabel.AutoSize = true;
            discoverLabel.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            discoverLabel.ForeColor = Color.White;
            discoverLabel.Location = new Point(11, 175);
            discoverLabel.Margin = new Padding(2, 0, 2, 0);
            discoverLabel.Name = "discoverLabel";
            discoverLabel.Size = new Size(250, 29);
            discoverLabel.TabIndex = 5;
            discoverLabel.Text = "Discover New Songs";
            // 
            // songList
            // 
            songList.AutoScroll = true;
            songList.Controls.Add(songPanel);
            songList.FlowDirection = FlowDirection.TopDown;
            songList.Location = new Point(11, 225);
            songList.Margin = new Padding(2, 2, 2, 2);
            songList.Name = "songList";
            songList.Size = new Size(255, 158);
            songList.TabIndex = 6;
            // 
            // songPanel
            // 
            songPanel.BackColor = Color.FromArgb(50, 50, 70);
            songPanel.Controls.Add(songArtist);
            songPanel.Controls.Add(songTitle);
            songPanel.Controls.Add(songArtwork);
            songPanel.Location = new Point(2, 2);
            songPanel.Margin = new Padding(2, 2, 2, 2);
            songPanel.Name = "songPanel";
            songPanel.Size = new Size(253, 63);
            songPanel.TabIndex = 0;
            // 
            // songArtist
            // 
            songArtist.AutoSize = true;
            songArtist.Font = new Font("Arial Narrow", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            songArtist.ForeColor = Color.LightGray;
            songArtist.Location = new Point(73, 38);
            songArtist.Margin = new Padding(2, 0, 2, 0);
            songArtist.Name = "songArtist";
            songArtist.Size = new Size(71, 17);
            songArtist.TabIndex = 2;
            songArtist.Text = "The Weeknd";
            // 
            // songTitle
            // 
            songTitle.AutoSize = true;
            songTitle.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            songTitle.ForeColor = Color.White;
            songTitle.Location = new Point(73, 5);
            songTitle.Margin = new Padding(2, 0, 2, 0);
            songTitle.Name = "songTitle";
            songTitle.Size = new Size(83, 19);
            songTitle.TabIndex = 1;
            songTitle.Text = "Heartless";
            // 
            // songArtwork
            // 
            songArtwork.BackColor = Color.Gray;
            songArtwork.Location = new Point(3, 3);
            songArtwork.Margin = new Padding(2, 2, 2, 2);
            songArtwork.Name = "songArtwork";
            songArtwork.Size = new Size(32, 58);
            songArtwork.SizeMode = PictureBoxSizeMode.StretchImage;
            songArtwork.TabIndex = 0;
            songArtwork.TabStop = false;
            // 
            // progressBar
            // 
            progressBar.BackColor = Color.FromArgb(50, 50, 70);
            progressBar.ForeColor = Color.DarkViolet;
            progressBar.Location = new Point(9, 46);
            progressBar.Margin = new Padding(2, 2, 2, 2);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(236, 10);
            progressBar.TabIndex = 7;
            progressBar.Value = 50;
            // 
            // playerPanel
            // 
            playerPanel.BackColor = Color.FromArgb(70, 70, 100);
            playerPanel.Controls.Add(playButton);
            playerPanel.Controls.Add(likeButton);
            playerPanel.Controls.Add(dashboardCurrentSongs);
            playerPanel.Controls.Add(playerSong);
            playerPanel.Controls.Add(playerArtwork);
            playerPanel.Controls.Add(progressBar);
            playerPanel.Location = new Point(12, 406);
            playerPanel.Margin = new Padding(2, 2, 2, 2);
            playerPanel.Name = "playerPanel";
            playerPanel.Size = new Size(253, 57);
            playerPanel.TabIndex = 1;
            // 
            // playButton
            // 
            playButton.BackColor = Color.Transparent;
            playButton.FlatStyle = FlatStyle.Flat;
            playButton.Font = new Font("Goudy Stout", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playButton.ForeColor = Color.FromArgb(150, 100, 200);
            playButton.Location = new Point(198, 13);
            playButton.Margin = new Padding(2, 2, 2, 2);
            playButton.Name = "playButton";
            playButton.Size = new Size(18, 24);
            playButton.TabIndex = 12;
            playButton.Text = "||";
            playButton.UseVisualStyleBackColor = false;
            // 
            // likeButton
            // 
            likeButton.BackColor = Color.Transparent;
            likeButton.FlatStyle = FlatStyle.Flat;
            likeButton.ForeColor = Color.FromArgb(150, 100, 200);
            likeButton.Location = new Point(246, 13);
            likeButton.Margin = new Padding(2, 2, 2, 2);
            likeButton.Name = "likeButton";
            likeButton.Size = new Size(18, 24);
            likeButton.TabIndex = 11;
            likeButton.Text = "❤️";
            likeButton.UseVisualStyleBackColor = false;
            // 
            // dashboardCurrentSongs
            // 
            dashboardCurrentSongs.AutoSize = true;
            dashboardCurrentSongs.BackColor = Color.FromArgb(50, 50, 70);
            dashboardCurrentSongs.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardCurrentSongs.ForeColor = Color.White;
            dashboardCurrentSongs.Location = new Point(57, 2);
            dashboardCurrentSongs.Margin = new Padding(2, 0, 2, 0);
            dashboardCurrentSongs.Name = "dashboardCurrentSongs";
            dashboardCurrentSongs.Size = new Size(44, 19);
            dashboardCurrentSongs.TabIndex = 10;
            dashboardCurrentSongs.Text = "Stay";
            // 
            // playerSong
            // 
            playerSong.AutoSize = true;
            playerSong.Font = new Font("Arial Narrow", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playerSong.ForeColor = Color.White;
            playerSong.Location = new Point(57, 22);
            playerSong.Margin = new Padding(2, 0, 2, 0);
            playerSong.Name = "playerSong";
            playerSong.Size = new Size(149, 17);
            playerSong.TabIndex = 9;
            playerSong.Text = "The Kid LAROI,Justin Bieber";
            // 
            // playerArtwork
            // 
            playerArtwork.BackColor = Color.Gray;
            playerArtwork.Location = new Point(3, 2);
            playerArtwork.Margin = new Padding(2, 2, 2, 2);
            playerArtwork.Name = "playerArtwork";
            playerArtwork.Size = new Size(32, 36);
            playerArtwork.SizeMode = PictureBoxSizeMode.StretchImage;
            playerArtwork.TabIndex = 8;
            playerArtwork.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 50);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 673);
            Controls.Add(playerPanel);
            Controls.Add(songList);
            Controls.Add(discoverLabel);
            Controls.Add(featuredPanel);
            Controls.Add(searchBox);
            Controls.Add(profilePic);
            Controls.Add(welcomeLabel);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Dashboard";
            Text = "Music Player Dashboard";
            ((System.ComponentModel.ISupportInitialize)profilePic).EndInit();
            featuredPanel.ResumeLayout(false);
            featuredPanel.PerformLayout();
            songList.ResumeLayout(false);
            songPanel.ResumeLayout(false);
            songPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)songArtwork).EndInit();
            playerPanel.ResumeLayout(false);
            playerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)playerArtwork).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Label welcomeLabel;
        private PictureBox profilePic;
        private TextBox searchBox;
        private Panel featuredPanel;
        private Label featuredTitle;
        private Label featuredSubtitle;
        private Button nextButton;
        private Label discoverLabel;
        private FlowLayoutPanel songList;
        private Panel songPanel;
        private PictureBox songArtwork;
        private Label songArtist;
        private Label songTitle;
        private ProgressBar progressBar;
        private Panel playerPanel;
        private Label playerSong;
        private PictureBox playerArtwork;
        private Label dashboardCurrentSongs;
        private Button likeButton;
        private Button playButton;
    }
}