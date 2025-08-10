using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addMap : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Maps",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BackgroundTitle", "Description", "Name" },
                values: new object[] { "/public/images/Map1.jpg", "d", "Map1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Maps",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BackgroundTitle", "Description", "Name" },
                values: new object[] { "шлях", "опис світу", "TaleWorld" });
        }
    }
}
