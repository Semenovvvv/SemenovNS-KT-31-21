using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SemenovNS_31_21.Migrations
{
    /// <inheritdoc />
    public partial class Rename_tables_and_columns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Disciplines_discipline_id",
                table: "Tests");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Students_student_id",
                table: "Tests");

            migrationBuilder.RenameTable(
                name: "Tests",
                newName: "cd_tests");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "cd_students");

            migrationBuilder.RenameTable(
                name: "Marks",
                newName: "cd_marks");

            migrationBuilder.RenameTable(
                name: "Groups",
                newName: "cd_groups");

            migrationBuilder.RenameTable(
                name: "Disciplines",
                newName: "cd_disciplines");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_student_id",
                table: "cd_tests",
                newName: "IX_cd_tests_student_id");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_discipline_id",
                table: "cd_tests",
                newName: "IX_cd_tests_discipline_id");

            migrationBuilder.RenameIndex(
                name: "IX_Groups_name",
                table: "cd_groups",
                newName: "IX_cd_groups_c_name");

            migrationBuilder.AddForeignKey(
                name: "FK_cd_tests_cd_disciplines_discipline_id",
                table: "cd_tests",
                column: "discipline_id",
                principalTable: "cd_disciplines",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cd_tests_cd_students_student_id",
                table: "cd_tests",
                column: "student_id",
                principalTable: "cd_students",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cd_tests_cd_disciplines_discipline_id",
                table: "cd_tests");

            migrationBuilder.DropForeignKey(
                name: "FK_cd_tests_cd_students_student_id",
                table: "cd_tests");

            migrationBuilder.RenameTable(
                name: "cd_tests",
                newName: "Tests");

            migrationBuilder.RenameTable(
                name: "cd_students",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "cd_marks",
                newName: "Marks");

            migrationBuilder.RenameTable(
                name: "cd_groups",
                newName: "Groups");

            migrationBuilder.RenameTable(
                name: "cd_disciplines",
                newName: "Disciplines");

            migrationBuilder.RenameIndex(
                name: "IX_cd_tests_student_id",
                table: "Tests",
                newName: "IX_Tests_student_id");

            migrationBuilder.RenameIndex(
                name: "IX_cd_tests_discipline_id",
                table: "Tests",
                newName: "IX_Tests_discipline_id");

            migrationBuilder.RenameIndex(
                name: "IX_cd_groups_c_name",
                table: "Groups",
                newName: "IX_Groups_name");

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Disciplines_discipline_id",
                table: "Tests",
                column: "discipline_id",
                principalTable: "Disciplines",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Students_student_id",
                table: "Tests",
                column: "student_id",
                principalTable: "Students",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
