using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Locations",
                type: "character varying(450)",
                maxLength: 450,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Background",
                table: "Locations",
                type: "character varying(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "TaskQuestionId",
                table: "Locations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Lessons",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "MapId", "Title" },
                values: new object[] { 1, 1, 1, "" });

            migrationBuilder.CreateIndex(
                name: "IX_Locations_MapId",
                table: "Locations",
                column: "MapId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_TaskQuestionId",
                table: "Locations",
                column: "TaskQuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Maps_MapId",
                table: "Locations",
                column: "MapId",
                principalTable: "Maps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_TasksQuestions_TaskQuestionId",
                table: "Locations",
                column: "TaskQuestionId",
                principalTable: "TasksQuestions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Maps_MapId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_TasksQuestions_TaskQuestionId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_MapId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_TaskQuestionId",
                table: "Locations");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "TaskQuestionId",
                table: "Locations");

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Locations",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "Background",
                table: "Locations",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Lessons",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);
        }
    }
}
