using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class location : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_TasksQuestions_TaskQuestionId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_TaskQuestionId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "TaskQuestionId",
                table: "Locations");

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Background", "MapId", "TaskQuestionsId", "Text" },
                values: new object[] { 1, "new", 1, 1, "text" });

            migrationBuilder.CreateIndex(
                name: "IX_Locations_TaskQuestionsId",
                table: "Locations",
                column: "TaskQuestionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_TasksQuestions_TaskQuestionsId",
                table: "Locations",
                column: "TaskQuestionsId",
                principalTable: "TasksQuestions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_TasksQuestions_TaskQuestionsId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_TaskQuestionsId",
                table: "Locations");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "TaskQuestionId",
                table: "Locations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_TaskQuestionId",
                table: "Locations",
                column: "TaskQuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_TasksQuestions_TaskQuestionId",
                table: "Locations",
                column: "TaskQuestionId",
                principalTable: "TasksQuestions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
