using Microsoft.EntityFrameworkCore;
using MusicPlayer.database.Models;

namespace MusicPlayer.database;

public class MusicPlayerContext(DbContextOptions<MusicPlayerContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Playlist> Playlists { get; set; }
    public DbSet<Song> Songs { get; set; }
    public DbSet<SongMetadata> SongMetadata { get; set; }
    public DbSet<SongPlaylist> SongPlaylists { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        ConfigureDatabase(modelBuilder);
    }

    private static void ConfigureDatabase(ModelBuilder modelBuilder)
    {
        // User
        modelBuilder.Entity<User>().ToTable("user");
        modelBuilder.Entity<User>().Property(u => u.Id).HasColumnName("_id").ValueGeneratedOnAdd();
        modelBuilder.Entity<User>().Property(u => u.Email).HasColumnName("email");
        modelBuilder.Entity<User>().Property(u => u.Password).HasColumnName("password");
        modelBuilder.Entity<User>().Property(u => u.Token).HasColumnName("token").HasDefaultValue(null);
        modelBuilder.Entity<User>().Property(u => u.Username).HasColumnName("username");

        // Playlist
        modelBuilder.Entity<Playlist>().ToTable("playlist");
        modelBuilder.Entity<Playlist>().Property(p => p.Id).HasColumnName("_id").ValueGeneratedOnAdd();
        modelBuilder.Entity<Playlist>().Property(p => p.Title).HasColumnName("title");

        // Song
        modelBuilder.Entity<Song>().ToTable("song");
        modelBuilder.Entity<Song>().Property(s => s.Id).HasColumnName("_id").ValueGeneratedOnAdd();
        modelBuilder.Entity<Song>().Property(s => s.Path).HasColumnName("path");

        // SongMetadata
        modelBuilder.Entity<SongMetadata>().ToTable("song_metadata");
        modelBuilder.Entity<SongMetadata>().Property(sm => sm.Id).HasColumnName("_id").ValueGeneratedOnAdd();
        modelBuilder.Entity<SongMetadata>().Property(sm => sm.SongId).HasColumnName("song_id");
        modelBuilder.Entity<SongMetadata>().Property(sm => sm.Artist).HasColumnName("artist");
        modelBuilder.Entity<SongMetadata>().Property(sm => sm.Album).HasColumnName("album");
        modelBuilder.Entity<SongMetadata>().Property(sm => sm.Year).HasColumnName("year");

        // One-to-One relationship: Song -> SongMetadata
        modelBuilder.Entity<Song>()
            .HasOne(s => s.Metadata)
            .WithOne(m => m.Song)
            .HasForeignKey<SongMetadata>(m => m.SongId)
            .OnDelete(DeleteBehavior.Cascade);

        // SongPlaylist
        modelBuilder.Entity<SongPlaylist>().ToTable("song_playlist");
        modelBuilder.Entity<SongPlaylist>().Property(sp => sp.Id).HasColumnName("_id").ValueGeneratedOnAdd();
        modelBuilder.Entity<SongPlaylist>().Property(sp => sp.PlaylistId).HasColumnName("playlist_id");
        modelBuilder.Entity<SongPlaylist>().Property(sp => sp.SongId).HasColumnName("song_id");

        // Foreign key relationship: SongPlaylist -> Playlist
        modelBuilder.Entity<SongPlaylist>()
            .HasOne<Playlist>()
            .WithMany()
            .HasForeignKey(sp => sp.PlaylistId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}