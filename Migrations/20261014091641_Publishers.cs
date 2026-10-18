using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Antoniu_Avram_Lab2.Migrations
{
    /// <inheritdoc />
    public partial class Publishers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Publisher",
                table: "Book",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PublisherID",
                table: "Book",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Publisher",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "PublisherID",
                table: "Book");
        }
    }
}
