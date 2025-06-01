using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicPlayer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "playlist",
                columns: table => new
                {
                    _id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_playlist", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "song",
                columns: table => new
                {
                    _id = table.Column<Guid>(type: "uuid", nullable: false),
                    path = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_song", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    _id = table.Column<Guid>(type: "uuid", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    username = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    token = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x._id);
                });

            migrationBuilder.CreateTable(
                name: "song_playlist",
                columns: table => new
                {
                    _id = table.Column<Guid>(type: "uuid", nullable: false),
                    playlist_id = table.Column<Guid>(type: "uuid", nullable: false),
                    song_id = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_song_playlist", x => x._id);
                    table.ForeignKey(
                        name: "FK_song_playlist_playlist_playlist_id",
                        column: x => x.playlist_id,
                        principalTable: "playlist",
                        principalColumn: "_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "song_metadata",
                columns: table => new
                {
                    _id = table.Column<Guid>(type: "uuid", nullable: false),
                    song_id = table.Column<Guid>(type: "uuid", nullable: false),
                    artist = table.Column<string>(type: "text", nullable: false),
                    album = table.Column<string>(type: "text", nullable: false),
                    year = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_song_metadata", x => x._id);
                    table.ForeignKey(
                        name: "FK_song_metadata_song_song_id",
                        column: x => x.song_id,
                        principalTable: "song",
                        principalColumn: "_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_song_metadata_song_id",
                table: "song_metadata",
                column: "song_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_song_playlist_playlist_id",
                table: "song_playlist",
                column: "playlist_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "song_metadata");

            migrationBuilder.DropTable(
                name: "song_playlist");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "song");

            migrationBuilder.DropTable(
                name: "playlist");
        }
    }
}
