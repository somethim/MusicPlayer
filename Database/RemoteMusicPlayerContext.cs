using Microsoft.EntityFrameworkCore;
using MusicPlayer.database.Models;

namespace MusicPlayer.database;

public class RemoteMusicPlayerContext(DbContextOptions<RemoteMusicPlayerContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable("users");
        modelBuilder.Entity<User>().Property(u => u.Id).HasColumnName("_id").ValueGeneratedOnAdd();
        modelBuilder.Entity<User>().Property(u => u.Email).HasColumnName("email");
        modelBuilder.Entity<User>().Property(u => u.Password).HasColumnName("password");
        modelBuilder.Entity<User>().Property(u => u.Username).HasColumnName("username");
        modelBuilder.Entity<User>().Property(u => u.EncryptedToken).HasColumnName("encrypted_token")
            .HasDefaultValue(null);
        modelBuilder.Entity<User>().Property(u => u.HashedToken).HasColumnName("hashed_token").HasDefaultValue(null);
    }
}