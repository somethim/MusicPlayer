using System;
using System.Drawing;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            this.Text = "Music Player Dashboard";
            this.Size = new Size(400, 700);
            this.BackColor = Color.FromArgb(30, 30, 50);

            Label welcomeLabel = new Label
            {
                Text = "Welcome, Sara!",
                Location = new Point(20, 20),
                AutoSize = true,
                ForeColor = Color.White,
                Font = new Font("Arial", 16, FontStyle.Bold)
            };

            PictureBox profilePic = new PictureBox
            {
                BackColor = Color.Gray,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(40, 40),
                Location = new Point(320, 20)
            };
            TextBox searchBox = new TextBox
            {
                Location = new Point(20, 80),
                Size = new Size(340, 30),
                PlaceholderText = "Search for songs, artists...",
                BackColor = Color.FromArgb(50, 50, 70),
                ForeColor = Color.Gray,
                BorderStyle = BorderStyle.None
            };
            Panel featuredPanel = new Panel
            {
                Size = new Size(340, 150),
                Location = new Point(20, 120),
                BackColor = Color.FromArgb(70, 70, 100)
            };
            PictureBox featuredImage = new PictureBox
            {
                Size = new Size(340, 150),
                Location = new Point(0, 0),
                BackColor = Color.FromArgb(50, 50, 80),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            Label featuredTitle = new Label
            {
                Text = "Go find your favourites.",
                ForeColor = Color.White,
                Font = new Font("Arial", 12, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            Label featuredSubtitle = new Label
            {
                Text = "Top songs being discovered around the world right now.",
                ForeColor = Color.LightGray,
                Font = new Font("Arial", 8),
                Location = new Point(10, 40),
                AutoSize = true
            };


            Button nextButton = new Button
            {
                Text = ">",
                Size = new Size(40, 40),
                Location = new Point(290, 55),
                BackColor = Color.FromArgb(100, 50, 200),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            nextButton.FlatAppearance.BorderSize = 0;

            featuredPanel.Controls.AddRange(new Control[]
            {
                featuredImage,
                featuredTitle,
                featuredSubtitle,
                nextButton
            });

            Label discoverLabel = new Label
            {
                Text = "Discover New Songs",
                ForeColor = Color.White,
                Font = new Font("Arial", 14, FontStyle.Bold),
                Location = new Point(20, 290),
                AutoSize = true
            };
            FlowLayoutPanel songList = new FlowLayoutPanel
            {
                Size = new Size(340, 300),
                Location = new Point(20, 320),
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown
            };
            Panel songPanel = new Panel
            {
                Size = new Size(320, 60),
                BackColor = Color.FromArgb(50, 50, 70)
            };
            PictureBox songArtwork = new PictureBox
            {
                Size = new Size(50, 50),
                Location = new Point(5, 5),
                BackColor = Color.Gray,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            Label songTitle = new Label
            {
                Text = "Heartless",
                ForeColor = Color.White,
                Font = new Font("Arial", 10, FontStyle.Bold),
                Location = new Point(60, 10),
                AutoSize = true
            };
            Label songArtist = new Label
            {
                Text = "The Weeknd",
                ForeColor = Color.LightGray,
                Font = new Font("Arial", 8),
                Location = new Point(60, 30),
                AutoSize = true
            };
            songPanel.Controls.AddRange(new Control[]
            { songArtwork,
                songTitle,
                songArtist
            });
            songList.Controls.Add(songPanel);

            Panel playerPanel = new Panel
            {
                Size = new Size(340, 70),
                Location = new Point(20, 620),
                BackColor = Color.FromArgb(70, 70, 100)
            };
            PictureBox playerArtwork = new PictureBox
            {
                Size = new Size(50, 50),
                Location = new Point(5, 10),
                BackColor = Color.Gray,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            Label playerSong = new Label
            {
                Text = "Stay - The Kid LAROI, Justin Bieber",
                ForeColor = Color.White,
                Font = new Font("Arial", 10),
                Location = new Point(60, 25),
                AutoSize = true
            };

            Button playButton = new Button
            {
                Text = " ",
                Size = new Size(30, 30),
                Location = new Point(280, 20),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            Button likeButton = new Button
            {
                Text = " ",
                Size = new Size(30, 30),
                Location = new Point(310, 20),
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(150, 100, 200),
                FlatStyle = FlatStyle.Flat
            };

            ProgressBar progressBar = new ProgressBar
            {
                Size = new Size(320, 5),
                Location = new Point(5, 0),
                Value = 50
            };

            playerPanel.Controls.AddRange(new Control[] {
            playerArtwork,
            playerSong,
            playButton,
            likeButton,
            progressBar
        });


            this.Controls.AddRange(new Control[] {
            welcomeLabel,
            profilePic,
            searchBox,
            featuredPanel,
            discoverLabel,
            songList,
            playerPanel
        });

        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboard());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
