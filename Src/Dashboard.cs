using MusicPlayer.Utils;

namespace MusicPlayer;

public partial class Dashboard : Form
{
    public Dashboard()
    {
        LoadSongs();
        InitializeComponent();
    }

    private static async void LoadSongs()
    {
        try
        {
            var searcher = new SongSearcher();
            var songs = await searcher.SearchSongsOnline("rats");

            foreach (var song in songs.Results)
            {
                Console.WriteLine($@"Artist: {song.Artist}");
                Console.WriteLine($@"Title: {song.Title}");
                Console.WriteLine($@"Duration: {song.Duration}");
                Console.WriteLine($@"Download from: {song.AudioDownloadPath}");
                Console.WriteLine($@"Stream from: {song.AudioPath}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}