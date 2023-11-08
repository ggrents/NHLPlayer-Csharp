using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NHL_Player.Migrations
{
    /// <inheritdoc />
    public partial class _31jk43 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Hand",
                table: "Players",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hand",
                table: "Players");
        }
    }
}
