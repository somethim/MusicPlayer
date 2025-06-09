#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicPlayer.Database.Migrations.Remote;

/// <inheritdoc />
public partial class InitialRemote : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            "users",
            table => new
            {
                _id = table.Column<Guid>("uuid", nullable: false),
                email = table.Column<string>("text", nullable: false),
                username = table.Column<string>("text", nullable: false),
                password = table.Column<string>("text", nullable: false),
                encrypted_token = table.Column<string>("text", nullable: true),
                hashed_token = table.Column<string>("text", nullable: true)
            },
            constraints: table => { table.PrimaryKey("PK_users", x => x._id); });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            "users");
    }
}