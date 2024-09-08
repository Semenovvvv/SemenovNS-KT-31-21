using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SemenovNS_31_21.Migrations
{
    /// <inheritdoc />
    public partial class AddCheckConstraints : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddCheckConstraint(
                name: "CK_Tests_Result",
                table: "Tests",
                sql: "\"Result\" IN ('Зачет', 'Незачет')");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Marks_Result",
                table: "Marks",
                sql: "\"Result\" IN (5, 4, 3, 2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Tests_Result",
                table: "Tests");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Marks_Result",
                table: "Marks");
        }
    }
}
