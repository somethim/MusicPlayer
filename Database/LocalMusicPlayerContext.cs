using Microsoft.EntityFrameworkCore;
using MusicPlayer.database.Models;

namespace MusicPlayer.database;

public class LocalMusicPlayerContext(DbContextOptions<LocalMusicPlayerContext> options) : DbContext(options)
{
    public DbSet<Song> Songs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Song>().ToTable("songs");
        modelBuilder.Entity<Song>().Property(s => s.Id).HasColumnName("_id").ValueGeneratedOnAdd();
        modelBuilder.Entity<Song>().Property(s => s.Title).HasColumnName("title");
        modelBuilder.Entity<Song>().Property(s => s.Artist).HasColumnName("artist");
        modelBuilder.Entity<Song>().Property(s => s.Album).HasColumnName("album");
        modelBuilder.Entity<Song>().Property(s => s.Releasedate).HasColumnName("release_date");
        modelBuilder.Entity<Song>().Property(s => s.Duration).HasColumnName("duration");
        modelBuilder.Entity<Song>().Property(s => s.AlbumImage).HasColumnName("album_image");
        modelBuilder.Entity<Song>().Property(s => s.AudioPath).HasColumnName("audio_path");
        modelBuilder.Entity<Song>().Property(s => s.AudioDownloadPath).HasColumnName("audio_download_path");
    }
}