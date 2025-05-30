﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicPlayer.database;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MusicPlayer.Migrations
{
    [DbContext(typeof(MusicPlayerContext))]
    partial class MusicPlayerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MusicPlayer.database.Models.Playlist", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("_id");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("playlist", (string)null);
                });

            modelBuilder.Entity("MusicPlayer.database.Models.Song", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("_id");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("path");

                    b.HasKey("Id");

                    b.ToTable("song", (string)null);
                });

            modelBuilder.Entity("MusicPlayer.database.Models.SongMetadata", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("_id");

                    b.Property<string>("Album")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("album");

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("artist");

                    b.Property<Guid>("SongId")
                        .HasColumnType("uuid")
                        .HasColumnName("song_id");

                    b.Property<int?>("Year")
                        .HasColumnType("integer")
                        .HasColumnName("year");

                    b.HasKey("Id");

                    b.HasIndex("SongId")
                        .IsUnique();

                    b.ToTable("song_metadata", (string)null);
                });

            modelBuilder.Entity("MusicPlayer.database.Models.SongPlaylist", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("_id");

                    b.Property<Guid>("PlaylistId")
                        .HasColumnType("uuid")
                        .HasColumnName("playlist_id");

                    b.Property<string>("SongId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("song_id");

                    b.HasKey("Id");

                    b.HasIndex("PlaylistId");

                    b.ToTable("song_playlist", (string)null);
                });

            modelBuilder.Entity("MusicPlayer.database.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("_id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password");

                    b.Property<string>("Token")
                        .HasColumnType("text")
                        .HasColumnName("token");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("MusicPlayer.database.Models.SongMetadata", b =>
                {
                    b.HasOne("MusicPlayer.database.Models.Song", "Song")
                        .WithOne("Metadata")
                        .HasForeignKey("MusicPlayer.database.Models.SongMetadata", "SongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Song");
                });

            modelBuilder.Entity("MusicPlayer.database.Models.SongPlaylist", b =>
                {
                    b.HasOne("MusicPlayer.database.Models.Playlist", null)
                        .WithMany()
                        .HasForeignKey("PlaylistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MusicPlayer.database.Models.Song", b =>
                {
                    b.Navigation("Metadata")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
