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
            featuredTitle = new Label();
            featuredSubtitle = new Label();
            nextButton = new Button();
            discoverLabel = new Label();
            songList = new FlowLayoutPanel();
            songPanel = new Panel();
            songArtwork = new PictureBox();
            songTitle = new Label();
            songArtist = new Label();
            ((System.ComponentModel.ISupportInitialize)profilePic).BeginInit();
            featuredPanel.SuspendLayout();
            songList.SuspendLayout();
            songPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)songArtwork).BeginInit();
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
            welcomeLabel.Location = new Point(20, 20);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(352, 56);
            welcomeLabel.TabIndex = 1;
            welcomeLabel.Text = "Welcome,Sara";
            // 
            // profilePic
            // 
            profilePic.BackColor = Color.Gray;
            profilePic.Location = new Point(366, 36);
            profilePic.Name = "profilePic";
            profilePic.Size = new Size(40, 40);
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
            searchBox.Location = new Point(20, 80);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(340, 36);
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
            featuredPanel.Location = new Point(20, 153);
            featuredPanel.Name = "featuredPanel";
            featuredPanel.Size = new Size(487, 153);
            featuredPanel.TabIndex = 4;
            // 
            // featuredTitle
            // 
            featuredTitle.AutoSize = true;
            featuredTitle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            featuredTitle.ForeColor = Color.White;
            featuredTitle.Location = new Point(3, 13);
            featuredTitle.Name = "featuredTitle";
            featuredTitle.Size = new Size(390, 43);
            featuredTitle.TabIndex = 5;
            featuredTitle.Text = "Go find your favorites";
            // 
            // featuredSubtitle
            // 
            featuredSubtitle.AutoSize = true;
            featuredSubtitle.Font = new Font("Arial Narrow", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            featuredSubtitle.ForeColor = Color.LightGray;
            featuredSubtitle.Location = new Point(0, 78);
            featuredSubtitle.Name = "featuredSubtitle";
            featuredSubtitle.Size = new Size(484, 29);
            featuredSubtitle.TabIndex = 6;
            featuredSubtitle.Text = "Top songs being discoverd around the world right now";
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.FromArgb(100, 50, 200);
            nextButton.FlatAppearance.BorderSize = 0;
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.ForeColor = Color.White;
            nextButton.Location = new Point(421, 110);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(40, 40);
            nextButton.TabIndex = 5;
            nextButton.Text = ">";
            nextButton.UseVisualStyleBackColor = false;
            // 
            // discoverLabel
            // 
            discoverLabel.AutoSize = true;
            discoverLabel.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            discoverLabel.ForeColor = Color.White;
            discoverLabel.Location = new Point(20, 323);
            discoverLabel.Name = "discoverLabel";
            discoverLabel.Size = new Size(437, 49);
            discoverLabel.TabIndex = 5;
            discoverLabel.Text = "Discover New Songs";
            // 
            // songList
            // 
            songList.AutoScroll = true;
            songList.Controls.Add(songPanel);
            songList.FlowDirection = FlowDirection.TopDown;
            songList.Location = new Point(20, 417);
            songList.Name = "songList";
            songList.Size = new Size(511, 316);
            songList.TabIndex = 6;
            // 
            // songPanel
            // 
            songPanel.BackColor = Color.FromArgb(50, 50, 70);
            songPanel.Controls.Add(songArtist);
            songPanel.Controls.Add(songTitle);
            songPanel.Controls.Add(songArtwork);
            songPanel.Location = new Point(3, 3);
            songPanel.Name = "songPanel";
            songPanel.Size = new Size(508, 116);
            songPanel.TabIndex = 0;
            // 
            // songArtwork
            // 
            songArtwork.BackColor = Color.Gray;
            songArtwork.Location = new Point(5, 5);
            songArtwork.Name = "songArtwork";
            songArtwork.Size = new Size(93, 108);
            songArtwork.SizeMode = PictureBoxSizeMode.StretchImage;
            songArtwork.TabIndex = 0;
            songArtwork.TabStop = false;
            // 
            // songTitle
            // 
            songTitle.AutoSize = true;
            songTitle.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            songTitle.ForeColor = Color.White;
            songTitle.Location = new Point(137, 10);
            songTitle.Name = "songTitle";
            songTitle.Size = new Size(152, 35);
            songTitle.TabIndex = 1;
            songTitle.Text = "Heartless";
            // 
            // songArtist
            // 
            songArtist.AutoSize = true;
            songArtist.Font = new Font("Arial Narrow", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            songArtist.ForeColor = Color.LightGray;
            songArtist.Location = new Point(137, 70);
            songArtist.Name = "songArtist";
            songArtist.Size = new Size(125, 29);
            songArtist.TabIndex = 2;
            songArtist.Text = "The Weeknd";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 50);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(560, 745);
            Controls.Add(songList);
            Controls.Add(discoverLabel);
            Controls.Add(featuredPanel);
            Controls.Add(searchBox);
            Controls.Add(profilePic);
            Controls.Add(welcomeLabel);
            Name = "Dashboard";
            Text = "Music Player Dashboard";
            ((System.ComponentModel.ISupportInitialize)profilePic).EndInit();
            featuredPanel.ResumeLayout(false);
            featuredPanel.PerformLayout();
            songList.ResumeLayout(false);
            songPanel.ResumeLayout(false);
            songPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)songArtwork).EndInit();
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
    }
}