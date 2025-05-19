using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Photo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CoursePhoto",
                table: "courses",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CoursePhoto",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoursePhoto",
                table: "courses");
        }
    }
}
