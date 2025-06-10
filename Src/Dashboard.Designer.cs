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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            contextMenuStrip1 = new ContextMenuStrip(components);
            welcomeLabel = new Label();
            searchBox = new TextBox();
            featuredPanel = new Panel();
            featuredSubtitle = new Label();
            nextButton = new Button();
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
            welcomeLabel.Location = new Point(425, 9);
            welcomeLabel.Margin = new Padding(2, 0, 2, 0);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(159, 26);
            welcomeLabel.TabIndex = 1;
            welcomeLabel.Text = "Welcome,Sara";
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.FromArgb(50, 50, 70);
            searchBox.BorderStyle = BorderStyle.None;
            searchBox.ForeColor = Color.Gray;
            searchBox.Location = new Point(60, 37);
            searchBox.Margin = new Padding(2);
            searchBox.Multiline = true;
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(805, 16);
            searchBox.TabIndex = 3;
            // 
            // featuredPanel
            // 
            featuredPanel.AutoSize = true;
            featuredPanel.BackColor = Color.FromArgb(50, 50, 80);
            featuredPanel.BackgroundImage = (Image)resources.GetObject("featuredPanel.BackgroundImage");
            featuredPanel.BackgroundImageLayout = ImageLayout.Stretch;
            featuredPanel.Controls.Add(featuredSubtitle);
            featuredPanel.Controls.Add(nextButton);
            featuredPanel.Controls.Add(featuredTitle);
            featuredPanel.Controls.Add(discoverLabel);
            featuredPanel.ImeMode = ImeMode.NoControl;
            featuredPanel.Location = new Point(60, 67);
            featuredPanel.Margin = new Padding(2);
            featuredPanel.Name = "featuredPanel";
            featuredPanel.Size = new Size(805, 246);
            featuredPanel.TabIndex = 4;
            // 
            // featuredSubtitle
            // 
            featuredSubtitle.AutoSize = true;
            featuredSubtitle.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            featuredSubtitle.ForeColor = Color.LightGray;
            featuredSubtitle.Location = new Point(2, 34);
            featuredSubtitle.Margin = new Padding(2, 0, 2, 0);
            featuredSubtitle.Name = "featuredSubtitle";
            featuredSubtitle.Size = new Size(306, 20);
            featuredSubtitle.TabIndex = 6;
            featuredSubtitle.Text = "Top songs being discoverd around the world right now";
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.FromArgb(100, 50, 200);
            nextButton.FlatAppearance.BorderSize = 0;
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.Font = new Font("Arial Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nextButton.ForeColor = Color.White;
            nextButton.Location = new Point(741, 188);
            nextButton.Margin = new Padding(2);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(62, 56);
            nextButton.TabIndex = 5;
            nextButton.Text = "→";
            nextButton.UseVisualStyleBackColor = false;
            // 
            // featuredTitle
            // 
            featuredTitle.AutoSize = true;
            featuredTitle.BackColor = Color.FromArgb(50, 50, 70);
            featuredTitle.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            featuredTitle.ForeColor = Color.White;
            featuredTitle.Location = new Point(11, 0);
            featuredTitle.Margin = new Padding(2, 0, 2, 0);
            featuredTitle.Name = "featuredTitle";
            featuredTitle.Size = new Size(229, 24);
            featuredTitle.TabIndex = 5;
            featuredTitle.Text = "Go find your favorites";
            // 
            // discoverLabel
            // 
            discoverLabel.AutoSize = true;
            discoverLabel.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            discoverLabel.ForeColor = Color.White;
            discoverLabel.Location = new Point(5, 211);
            discoverLabel.Margin = new Padding(2, 0, 2, 0);
            discoverLabel.Name = "discoverLabel";
            discoverLabel.Size = new Size(202, 22);
            discoverLabel.TabIndex = 5;
            discoverLabel.Text = "Discover New Songs";
            // 
            // songList
            // 
            songList.AutoScroll = true;
            songList.Controls.Add(songPanel);
            songList.FlowDirection = FlowDirection.TopDown;
            songList.Location = new Point(60, 314);
            songList.Margin = new Padding(2);
            songList.Name = "songList";
            songList.Size = new Size(803, 132);
            songList.TabIndex = 6;
            // 
            // songPanel
            // 
            songPanel.BackColor = Color.FromArgb(50, 50, 70);
            songPanel.Controls.Add(songArtist);
            songPanel.Controls.Add(songTitle);
            songPanel.Controls.Add(songArtwork);
            songPanel.Location = new Point(2, 2);
            songPanel.Margin = new Padding(2);
            songPanel.Name = "songPanel";
            songPanel.Size = new Size(221, 47);
            songPanel.TabIndex = 0;
            // 
            // songArtist
            // 
            songArtist.AutoSize = true;
            songArtist.Font = new Font("Arial Narrow", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            songArtist.ForeColor = Color.LightGray;
            songArtist.Location = new Point(64, 28);
            songArtist.Margin = new Padding(2, 0, 2, 0);
            songArtist.Name = "songArtist";
            songArtist.Size = new Size(59, 15);
            songArtist.TabIndex = 2;
            songArtist.Text = "The Weeknd";
            // 
            // songTitle
            // 
            songTitle.AutoSize = true;
            songTitle.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            songTitle.ForeColor = Color.White;
            songTitle.Location = new Point(64, 4);
            songTitle.Margin = new Padding(2, 0, 2, 0);
            songTitle.Name = "songTitle";
            songTitle.Size = new Size(74, 16);
            songTitle.TabIndex = 1;
            songTitle.Text = "Heartless";
            // 
            // songArtwork
            // 
            songArtwork.BackColor = Color.Gray;
            songArtwork.Location = new Point(3, 2);
            songArtwork.Margin = new Padding(2);
            songArtwork.Name = "songArtwork";
            songArtwork.Size = new Size(28, 44);
            songArtwork.SizeMode = PictureBoxSizeMode.StretchImage;
            songArtwork.TabIndex = 0;
            songArtwork.TabStop = false;
            // 
            // progressBar
            // 
            progressBar.BackColor = Color.FromArgb(50, 50, 70);
            progressBar.ForeColor = Color.DarkViolet;
            progressBar.Location = new Point(64, 32);
            progressBar.Margin = new Padding(2);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(703, 10);
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
            playerPanel.Location = new Point(60, 451);
            playerPanel.Margin = new Padding(2);
            playerPanel.Name = "playerPanel";
            playerPanel.Size = new Size(805, 43);
            playerPanel.TabIndex = 1;
            // 
            // playButton
            // 
            playButton.BackColor = Color.Transparent;
            playButton.FlatStyle = FlatStyle.Flat;
            playButton.Font = new Font("Goudy Stout", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playButton.ForeColor = Color.FromArgb(150, 100, 200);
            playButton.Location = new Point(664, -1);
            playButton.Margin = new Padding(2);
            playButton.Name = "playButton";
            playButton.Size = new Size(40, 33);
            playButton.TabIndex = 12;
            playButton.Text = "||";
            playButton.UseVisualStyleBackColor = false;
            // 
            // likeButton
            // 
            likeButton.BackColor = Color.Transparent;
            likeButton.FlatStyle = FlatStyle.Flat;
            likeButton.ForeColor = Color.FromArgb(150, 100, 200);
            likeButton.Location = new Point(725, -1);
            likeButton.Margin = new Padding(2);
            likeButton.Name = "likeButton";
            likeButton.Size = new Size(35, 33);
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
            dashboardCurrentSongs.Location = new Point(99, 0);
            dashboardCurrentSongs.Margin = new Padding(2, 0, 2, 0);
            dashboardCurrentSongs.Name = "dashboardCurrentSongs";
            dashboardCurrentSongs.Size = new Size(36, 16);
            dashboardCurrentSongs.TabIndex = 10;
            dashboardCurrentSongs.Text = "Stay";
            // 
            // playerSong
            // 
            playerSong.AutoSize = true;
            playerSong.Font = new Font("Arial Narrow", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playerSong.ForeColor = Color.White;
            playerSong.Location = new Point(99, 17);
            playerSong.Margin = new Padding(2, 0, 2, 0);
            playerSong.Name = "playerSong";
            playerSong.Size = new Size(125, 15);
            playerSong.TabIndex = 9;
            playerSong.Text = "The Kid LAROI,Justin Bieber";
            // 
            // playerArtwork
            // 
            playerArtwork.BackColor = Color.Gray;
            playerArtwork.Location = new Point(3, 2);
            playerArtwork.Margin = new Padding(2);
            playerArtwork.Name = "playerArtwork";
            playerArtwork.Size = new Size(57, 41);
            playerArtwork.SizeMode = PictureBoxSizeMode.StretchImage;
            playerArtwork.TabIndex = 8;
            playerArtwork.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 50);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1104, 505);
            Controls.Add(playerPanel);
            Controls.Add(songList);
            Controls.Add(featuredPanel);
            Controls.Add(searchBox);
            Controls.Add(welcomeLabel);
            Margin = new Padding(2);
            Name = "Dashboard";
            Text = "Music Player Dashboard";
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