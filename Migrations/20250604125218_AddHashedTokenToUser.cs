using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicPlayer.Migrations
{
    /// <inheritdoc />
    public partial class AddHashedTokenToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "token",
                table: "user",
                newName: "encrypted_token");

            migrationBuilder.AddColumn<string>(
                name: "hashed_token",
                table: "user",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "hashed_token",
                table: "user");

            migrationBuilder.RenameColumn(
                name: "encrypted_token",
                table: "user",
                newName: "token");
        }
    }
}
