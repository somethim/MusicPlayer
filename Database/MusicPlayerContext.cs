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
        SeedDatabase(modelBuilder);
    }

    private static void SeedDatabase(ModelBuilder modelBuilder)
    {
        var userId = Guid.NewGuid();
        var playlistId = Guid.NewGuid();
        var songId = Guid.NewGuid();
        var songMetadataId = Guid.NewGuid();
        var songPlaylistId = Guid.NewGuid();

        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = userId,
                Email = "user@email.com",
                Password = "password",
                Username = "xX_Beast_Master_69_Xx"
            });

        modelBuilder.Entity<Playlist>().HasData(
            new Playlist
            {
                Id = playlistId,
                Title = "My First Playlist"
            });

        modelBuilder.Entity<SongMetadata>().HasData(
            new SongMetadata
            {
                Id = songMetadataId,
                SongId = songId,
                Artist = "Artist Name",
                Album = "Album Name",
                Year = 2023
            });

        modelBuilder.Entity<SongPlaylist>().HasData(
            new SongPlaylist
            {
                Id = songPlaylistId,
                PlaylistId = playlistId,
                SongId = songId.ToString()
            });
    }

    private static void ConfigureDatabase(ModelBuilder modelBuilder)
    {
        // User
        modelBuilder.Entity<User>().ToTable("user");
        modelBuilder.Entity<User>().Property(u => u.Id).HasColumnName("_id")
            .HasDefaultValue(Guid.NewGuid())
            .ValueGeneratedOnAdd();
        modelBuilder.Entity<User>().Property(u => u.Email).HasColumnName("email");
        modelBuilder.Entity<User>().Property(u => u.Password).HasColumnName("password");
        modelBuilder.Entity<User>().Property(u => u.Token).HasColumnName("token").HasDefaultValue(null);
        modelBuilder.Entity<User>().Property(u => u.Username).HasColumnName("username");
        modelBuilder.Entity<User>().Property(u => u.CreatedAt).HasColumnName("_createdAt")
            .HasDefaultValue(DateTime.Now)
            .ValueGeneratedOnAdd();
        modelBuilder.Entity<User>().Property(u => u.UpdatedAt).HasColumnName("_updatedAt")
            .HasDefaultValue(DateTime.Now);
        modelBuilder.Entity<User>().Property(u => u.DeletedAt).HasColumnName("_deletedAt").HasDefaultValue(null);

        // Playlist
        modelBuilder.Entity<Playlist>().ToTable("playlist");
        modelBuilder.Entity<Playlist>().Property(p => p.Id).HasColumnName("_id")
            .HasDefaultValue(Guid.NewGuid())
            .ValueGeneratedOnAdd();
        modelBuilder.Entity<Playlist>().Property(p => p.Title).HasColumnName("title");
        modelBuilder.Entity<Playlist>().Property(p => p.CreatedAt).HasColumnName("_createdAt")
            .HasDefaultValue(DateTime.Now)
            .ValueGeneratedOnAdd();
        modelBuilder.Entity<Playlist>().Property(p => p.UpdatedAt).HasColumnName("_updatedAt")
            .HasDefaultValue(DateTime.Now);
        modelBuilder.Entity<Playlist>().Property(p => p.DeletedAt).HasColumnName("_deletedAt").HasDefaultValue(null);

        // Song
        modelBuilder.Entity<Song>().ToTable("song");
        modelBuilder.Entity<Song>().Property(s => s.Id).HasColumnName("_id")
            .HasDefaultValue(Guid.NewGuid())
            .ValueGeneratedOnAdd();
        modelBuilder.Entity<Song>().Property(s => s.Path).HasColumnName("path");
        modelBuilder.Entity<Song>().Property(s => s.CreatedAt).HasColumnName("_createdAt")
            .HasDefaultValue(DateTime.Now)
            .ValueGeneratedOnAdd();
        modelBuilder.Entity<Song>().Property(s => s.UpdatedAt).HasColumnName("_updatedAt")
            .HasDefaultValue(DateTime.Now);
        modelBuilder.Entity<Song>().Property(s => s.DeletedAt).HasColumnName("_deletedAt").HasDefaultValue(null);

        // SongMetadata
        modelBuilder.Entity<SongMetadata>().ToTable("song_metadata");
        modelBuilder.Entity<SongMetadata>().Property(sm => sm.Id).HasColumnName("_id")
            .HasDefaultValue(Guid.NewGuid())
            .ValueGeneratedOnAdd();
        modelBuilder.Entity<SongMetadata>().Property(sm => sm.SongId).HasColumnName("song_id");
        modelBuilder.Entity<SongMetadata>().Property(sm => sm.Artist).HasColumnName("artist");
        modelBuilder.Entity<SongMetadata>().Property(sm => sm.Album).HasColumnName("album");
        modelBuilder.Entity<SongMetadata>().Property(sm => sm.Year).HasColumnName("year");
        modelBuilder.Entity<SongMetadata>().Property(sm => sm.CreatedAt).HasColumnName("_createdAt")
            .HasDefaultValue(DateTime.Now)
            .ValueGeneratedOnAdd();
        modelBuilder.Entity<SongMetadata>().Property(sm => sm.UpdatedAt).HasColumnName("_updatedAt")
            .HasDefaultValue(DateTime.Now);
        modelBuilder.Entity<SongMetadata>().Property(sm => sm.DeletedAt).HasColumnName("_deletedAt")
            .HasDefaultValue(null);

        // One-to-One relationship: Song -> SongMetadata
        modelBuilder.Entity<Song>()
            .HasOne(s => s.Metadata)
            .WithOne(m => m.Song)
            .HasForeignKey<SongMetadata>(m => m.SongId)
            .OnDelete(DeleteBehavior.Cascade);

        // SongPlaylist
        modelBuilder.Entity<SongPlaylist>().ToTable("song_playlist");
        modelBuilder.Entity<SongPlaylist>().Property(sp => sp.Id).HasColumnName("_id")
            .HasDefaultValue(Guid.NewGuid())
            .ValueGeneratedOnAdd();
        modelBuilder.Entity<SongPlaylist>().Property(sp => sp.PlaylistId).HasColumnName("playlist_id");
        modelBuilder.Entity<SongPlaylist>().Property(sp => sp.SongId).HasColumnName("song_id");
        modelBuilder.Entity<SongPlaylist>().Property(sp => sp.CreatedAt).HasColumnName("_createdAt")
            .HasDefaultValue(DateTime.Now)
            .ValueGeneratedOnAdd();
        modelBuilder.Entity<SongPlaylist>().Property(sp => sp.UpdatedAt).HasColumnName("_updatedAt")
            .HasDefaultValue(DateTime.Now);
        modelBuilder.Entity<SongPlaylist>().Property(sp => sp.DeletedAt).HasColumnName("_deletedAt")
            .HasDefaultValue(null);

        // Foreign key relationship: SongPlaylist -> Playlist
        modelBuilder.Entity<SongPlaylist>()
            .HasOne<Playlist>()
            .WithMany()
            .HasForeignKey(sp => sp.PlaylistId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}