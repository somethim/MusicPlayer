using MusicPlayer.database;
using MusicPlayer.database.Models;

namespace MusicPlayer;

public partial class Dashboard : Form
{
    private readonly MusicPlayerContext _dbContext;

    public Dashboard(MusicPlayerContext dbContext, User user)
    {
        _dbContext = dbContext;
        InitializeComponent();
    }
}