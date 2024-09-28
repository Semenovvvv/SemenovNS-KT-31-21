using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SemenovNS_31_21.Migrations
{
    /// <inheritdoc />
    public partial class FixDisciplineNavigation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cd_tests_cd_disciplines_discipline_id",
                table: "cd_tests");

            migrationBuilder.RenameTable(
                name: "cd_disciplines",
                newName: "Disciplines");

            migrationBuilder.AddForeignKey(
                name: "FK_cd_tests_Disciplines_discipline_id",
                table: "cd_tests",
                column: "discipline_id",
                principalTable: "Disciplines",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cd_tests_Disciplines_discipline_id",
                table: "cd_tests");

            migrationBuilder.RenameTable(
                name: "Disciplines",
                newName: "cd_disciplines");

            migrationBuilder.AddForeignKey(
                name: "FK_cd_tests_cd_disciplines_discipline_id",
                table: "cd_tests",
                column: "discipline_id",
                principalTable: "cd_disciplines",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
