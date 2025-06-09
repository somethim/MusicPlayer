#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicPlayer.Database.Migrations.Local;

/// <inheritdoc />
public partial class InitialLocal : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            "songs",
            table => new
            {
                _id = table.Column<Guid>("TEXT", nullable: false),
                title = table.Column<string>("TEXT", nullable: false),
                artist = table.Column<string>("TEXT", nullable: false),
                album = table.Column<string>("TEXT", nullable: false),
                release_date = table.Column<string>("TEXT", nullable: true),
                duration = table.Column<int>("INTEGER", nullable: true),
                album_image = table.Column<string>("TEXT", nullable: false),
                audio_path = table.Column<string>("TEXT", nullable: false),
                audio_download_path = table.Column<string>("TEXT", nullable: true)
            },
            constraints: table => { table.PrimaryKey("PK_songs", x => x._id); });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            "songs");
    }
}