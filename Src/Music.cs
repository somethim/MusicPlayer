using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Music : Form
    {
        private List<string> songs = new List<string> { "Song 1", "Song 2", "Song 3" };
        private int currentSongIndex = -1;

        public Music()
        {
            InitializeComponent();
        }

        private void Music_Load(object sender, EventArgs e)
        {
            foreach (var song in songs)
            {
                music_listView.Items.Add(song);
            }
        }

        private void music_play_button_Click(object sender, EventArgs e)
        {
            if (music_listView.SelectedIndices.Count > 0)
            {
                currentSongIndex = music_listView.SelectedIndices[0];
                PlaySong(currentSongIndex);
            }
            else if (currentSongIndex != -1)
            {
                PlaySong(currentSongIndex);
            }
            else
            {
                MessageBox.Show("Please select a song to play.");
            }
        }

        private void music_next_song_button_Click(object sender, EventArgs e)
        {
            if (currentSongIndex < songs.Count - 1)
            {
                currentSongIndex++;
                music_listView.Items[currentSongIndex].Selected = true;
                PlaySong(currentSongIndex);
            }
        }

        private void music_previous_song_button_Click(object sender, EventArgs e)
        {
            if (currentSongIndex > 0)
            {
                currentSongIndex--;
                music_listView.Items[currentSongIndex].Selected = true;
                PlaySong(currentSongIndex);
            }
        }

        private void PlaySong(int index)
        {
            string song = songs[index];
            MessageBox.Show($"Now playing: {song}");
        }
    }
}
