namespace MusicPlayer.Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Music.Music));
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            welcomeLabel = new Label();
            searchBox = new TextBox();
            songList1 = new FlowLayoutPanel();
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label5 = new Label();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            songList2 = new FlowLayoutPanel();
            panel4 = new Panel();
            label7 = new Label();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            panel5 = new Panel();
            label9 = new Label();
            label10 = new Label();
            pictureBox5 = new PictureBox();
            panel6 = new Panel();
            label11 = new Label();
            label12 = new Label();
            pictureBox6 = new PictureBox();
            panel7 = new Panel();
            label13 = new Label();
            label14 = new Label();
            pictureBox7 = new PictureBox();
            settings_button = new Button();
            music_button = new Button();
            songList1.SuspendLayout();
            songPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)songArtwork).BeginInit();
            playerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)playerArtwork).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            songList2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
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
            welcomeLabel.Location = new Point(72, 47);
            welcomeLabel.Margin = new Padding(4, 0, 4, 0);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(352, 56);
            welcomeLabel.TabIndex = 1;
            welcomeLabel.Text = "Welcome to Music Player!";
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.FromArgb(30, 30, 50);
            searchBox.BorderStyle = BorderStyle.None;
            searchBox.ForeColor = Color.BlueViolet;
            searchBox.Location = new Point(72, 138);
            searchBox.Margin = new Padding(4, 5, 4, 5);
            searchBox.Multiline = true;
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(1725, 39);
            searchBox.TabIndex = 3;
            searchBox.Text = "🔍";
            // 
            // songList1
            // 
            songList1.AutoScroll = true;
            songList1.Controls.Add(songPanel);
            songList1.Controls.Add(panel1);
            songList1.Controls.Add(panel2);
            songList1.Controls.Add(panel3);
            songList1.FlowDirection = FlowDirection.TopDown;
            songList1.Location = new Point(78, 226);
            songList1.Margin = new Padding(4, 5, 4, 5);
            songList1.Name = "songList1";
            songList1.Size = new Size(829, 590);
            songList1.TabIndex = 6;
            // 
            // songPanel
            // 
            songPanel.Controls.Add(songArtist);
            songPanel.Controls.Add(songTitle);
            songPanel.Controls.Add(songArtwork);
            songPanel.Location = new Point(4, 5);
            songPanel.Margin = new Padding(4, 5, 4, 5);
            songPanel.Name = "songPanel";
            songPanel.Size = new Size(810, 121);
            songPanel.TabIndex = 0;
            // 
            // songArtist
            // 
            songArtist.AutoSize = true;
            songArtist.Font = new Font("Arial Narrow", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            songArtist.ForeColor = Color.LightGray;
            songArtist.Location = new Point(137, 69);
            songArtist.Margin = new Padding(4, 0, 4, 0);
            songArtist.Name = "songArtist";
            songArtist.Size = new Size(125, 29);
            songArtist.TabIndex = 2;
            songArtist.Text = "The Weeknd";
            // 
            // songTitle
            // 
            songTitle.AutoSize = true;
            songTitle.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            songTitle.ForeColor = Color.White;
            songTitle.Location = new Point(137, 10);
            songTitle.Margin = new Padding(4, 0, 4, 0);
            songTitle.Name = "songTitle";
            songTitle.Size = new Size(152, 35);
            songTitle.TabIndex = 1;
            songTitle.Text = "Heartless";
            // 
            // songArtwork
            // 
            songArtwork.BackColor = Color.Gray;
            songArtwork.Location = new Point(6, 5);
            songArtwork.Margin = new Padding(4, 5, 4, 5);
            songArtwork.Name = "songArtwork";
            songArtwork.Size = new Size(107, 109);
            songArtwork.SizeMode = PictureBoxSizeMode.StretchImage;
            songArtwork.TabIndex = 0;
            songArtwork.TabStop = false;
            // 
            // progressBar
            // 
            progressBar.BackColor = Color.FromArgb(50, 50, 70);
            progressBar.ForeColor = Color.DarkViolet;
            progressBar.Location = new Point(137, 79);
            progressBar.Margin = new Padding(4, 5, 4, 5);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(1506, 25);
            progressBar.TabIndex = 7;
            progressBar.Value = 50;
            // 
            // playerPanel
            // 
            playerPanel.BackColor = Color.FromArgb(30, 30, 50);
            playerPanel.Controls.Add(playButton);
            playerPanel.Controls.Add(likeButton);
            playerPanel.Controls.Add(dashboardCurrentSongs);
            playerPanel.Controls.Add(playerSong);
            playerPanel.Controls.Add(playerArtwork);
            playerPanel.Controls.Add(progressBar);
            playerPanel.Location = new Point(78, 857);
            playerPanel.Margin = new Padding(4, 5, 4, 5);
            playerPanel.Name = "playerPanel";
            playerPanel.Size = new Size(1725, 108);
            playerPanel.TabIndex = 1;
            // 
            // playButton
            // 
            playButton.BackColor = Color.Transparent;
            playButton.FlatStyle = FlatStyle.Flat;
            playButton.Font = new Font("Goudy Stout", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playButton.ForeColor = Color.FromArgb(150, 100, 200);
            playButton.Location = new Point(1423, -2);
            playButton.Margin = new Padding(4, 5, 4, 5);
            playButton.Name = "playButton";
            playButton.Size = new Size(86, 81);
            playButton.TabIndex = 12;
            playButton.Text = "||";
            playButton.UseVisualStyleBackColor = false;
            // 
            // likeButton
            // 
            likeButton.BackColor = Color.Transparent;
            likeButton.FlatStyle = FlatStyle.Flat;
            likeButton.ForeColor = Color.FromArgb(150, 100, 200);
            likeButton.Location = new Point(1554, -2);
            likeButton.Margin = new Padding(4, 5, 4, 5);
            likeButton.Name = "likeButton";
            likeButton.Size = new Size(75, 81);
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
            dashboardCurrentSongs.Location = new Point(212, 0);
            dashboardCurrentSongs.Margin = new Padding(4, 0, 4, 0);
            dashboardCurrentSongs.Name = "dashboardCurrentSongs";
            dashboardCurrentSongs.Size = new Size(78, 35);
            dashboardCurrentSongs.TabIndex = 10;
            dashboardCurrentSongs.Text = "Stay";
            // 
            // playerSong
            // 
            playerSong.AutoSize = true;
            playerSong.Font = new Font("Arial Narrow", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playerSong.ForeColor = Color.White;
            playerSong.Location = new Point(212, 42);
            playerSong.Margin = new Padding(4, 0, 4, 0);
            playerSong.Name = "playerSong";
            playerSong.Size = new Size(260, 29);
            playerSong.TabIndex = 9;
            playerSong.Text = "The Kid LAROI,Justin Bieber";
            // 
            // playerArtwork
            // 
            playerArtwork.BackColor = Color.Gray;
            playerArtwork.Location = new Point(6, 5);
            playerArtwork.Margin = new Padding(4, 5, 4, 5);
            playerArtwork.Name = "playerArtwork";
            playerArtwork.Size = new Size(122, 101);
            playerArtwork.SizeMode = PictureBoxSizeMode.StretchImage;
            playerArtwork.TabIndex = 8;
            playerArtwork.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 50);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(4, 136);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(810, 131);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(137, 69);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 29);
            label1.TabIndex = 2;
            label1.Text = "The Weeknd";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(137, 10);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(152, 35);
            label2.TabIndex = 1;
            label2.Text = "Heartless";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gray;
            pictureBox1.Location = new Point(6, 5);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 30, 50);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(4, 277);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(810, 131);
            panel2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(137, 69);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(125, 29);
            label3.TabIndex = 2;
            label3.Text = "The Weeknd";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(137, 10);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(152, 35);
            label4.TabIndex = 1;
            label4.Text = "Heartless";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Gray;
            pictureBox2.Location = new Point(6, 5);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(107, 109);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 30, 50);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(4, 418);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(810, 129);
            panel3.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(137, 69);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(125, 29);
            label5.TabIndex = 2;
            label5.Text = "The Weeknd";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(137, 10);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(152, 35);
            label6.TabIndex = 1;
            label6.Text = "Heartless";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Gray;
            pictureBox3.Location = new Point(6, 5);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(107, 109);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // songList2
            // 
            songList2.BackgroundImageLayout = ImageLayout.Stretch;
            songList2.Controls.Add(panel4);
            songList2.Controls.Add(panel5);
            songList2.Controls.Add(panel6);
            songList2.Controls.Add(panel7);
            songList2.FlowDirection = FlowDirection.TopDown;
            songList2.Location = new Point(953, 226);
            songList2.Name = "songList2";
            songList2.Size = new Size(830, 590);
            songList2.TabIndex = 7;
            //
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(30, 30, 50);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(pictureBox4);
            panel4.Location = new Point(4, 5);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(810, 121);
            panel4.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.LightGray;
            label7.Location = new Point(137, 69);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(125, 29);
            label7.TabIndex = 2;
            label7.Text = "The Weeknd";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(137, 10);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(152, 35);
            label8.TabIndex = 1;
            label8.Text = "Heartless";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Gray;
            pictureBox4.Location = new Point(6, 5);
            pictureBox4.Margin = new Padding(4, 5, 4, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(107, 109);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(30, 30, 50);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(pictureBox5);
            panel5.Location = new Point(4, 136);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(810, 131);
            panel5.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.LightGray;
            label9.Location = new Point(137, 69);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(125, 29);
            label9.TabIndex = 2;
            label9.Text = "The Weeknd";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(137, 10);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(152, 35);
            label10.TabIndex = 1;
            label10.Text = "Heartless";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Gray;
            pictureBox5.Location = new Point(6, 5);
            pictureBox5.Margin = new Padding(4, 5, 4, 5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(107, 109);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(30, 30, 50);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(pictureBox6);
            panel6.Location = new Point(4, 277);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(810, 131);
            panel6.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Narrow", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.LightGray;
            label11.Location = new Point(137, 69);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(125, 29);
            label11.TabIndex = 2;
            label11.Text = "The Weeknd";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(137, 10);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(152, 35);
            label12.TabIndex = 1;
            label12.Text = "Heartless";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Gray;
            pictureBox6.Location = new Point(6, 5);
            pictureBox6.Margin = new Padding(4, 5, 4, 5);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(107, 109);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(30, 30, 50);
            panel7.Controls.Add(label13);
            panel7.Controls.Add(label14);
            panel7.Controls.Add(pictureBox7);
            panel7.Location = new Point(4, 418);
            panel7.Margin = new Padding(4, 5, 4, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(810, 129);
            panel7.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Narrow", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.LightGray;
            label13.Location = new Point(137, 69);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(125, 29);
            label13.TabIndex = 2;
            label13.Text = "The Weeknd";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(137, 10);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(152, 35);
            label14.TabIndex = 1;
            label14.Text = "Heartless";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Gray;
            pictureBox7.Location = new Point(6, 5);
            pictureBox7.Margin = new Padding(4, 5, 4, 5);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(107, 109);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            //
            // dashboard_button
            //
            music_button.BackgroundImage = (Image)resources.GetObject("music_button.BackgroundImage");
            music_button.Location = new Point(691, 21);
            music_button.Name = "music_button";
            music_button.Size = new Size(94, 29);
            music_button.TabIndex = 5;
            music_button.Text = "Music";
            music_button.UseVisualStyleBackColor = true;
            music_button.Click += dashboard_button_Click;
            //
            // settings_button
            //
            settings_button.BackgroundImage = (Image)resources.GetObject("settings_button.BackgroundImage");
            settings_button.Location = new Point(814, 21);
            settings_button.Name = "settings_button";
            settings_button.Size = new Size(94, 29);
            settings_button.TabIndex = 7;
            settings_button.Text = "Settings";
            settings_button.UseVisualStyleBackColor = true;
            settings_button.Click += settings_button_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 50);
            BackgroundImage = Properties.Resources.xx;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1892, 1001);
            Controls.Add(songList2);
            Controls.Add(playerPanel);
            Controls.Add(songList1);
            Controls.Add(searchBox);
            Controls.Add(welcomeLabel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Dashboard";
            Text = "Music Player Dashboard";
            songList1.ResumeLayout(false);
            songPanel.ResumeLayout(false);
            songPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)songArtwork).EndInit();
            playerPanel.ResumeLayout(false);
            playerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)playerArtwork).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            songList2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Label welcomeLabel;
        private TextBox searchBox;
        private FlowLayoutPanel songList1;
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
        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox3;
        private FlowLayoutPanel songList2;
        private Panel panel4;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox4;
        private Panel panel5;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox5;
        private Panel panel6;
        private Label label11;
        private Label label12;
        private PictureBox pictureBox6;
        private Panel panel7;
        private Label label13;
        private Label label14;
        private PictureBox pictureBox7;
        private Button settings_button;
        private Button music_button;
    }
}