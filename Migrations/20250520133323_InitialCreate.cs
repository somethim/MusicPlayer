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
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Artist = table.Column<string>(type: "TEXT", nullable: false),
                    Metadata_Album = table.Column<string>(type: "TEXT", nullable: false),
                    Metadata_Genre = table.Column<string>(type: "TEXT", nullable: false),
                    Metadata_Duration = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    Metadata_Bitrate = table.Column<int>(type: "INTEGER", nullable: false),
                    Metadata_SampleRate = table.Column<int>(type: "INTEGER", nullable: false),
                    Metadata_Channels = table.Column<int>(type: "INTEGER", nullable: false),
                    SavePath = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Songs");
        }
    }
}
