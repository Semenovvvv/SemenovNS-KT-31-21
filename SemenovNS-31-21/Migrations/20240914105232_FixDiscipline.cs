using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SemenovNS_31_21.Migrations
{
    /// <inheritdoc />
    public partial class FixDiscipline : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_discipline_id",
                table: "Marks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Disciplinces_discipline_id",
                table: "Tests");

            migrationBuilder.DropTable(
                name: "Disciplinces");

            migrationBuilder.CreateTable(
                name: "Disciplines",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, comment: "Идентификатор дисциплины")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "Название дисциплины")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_disciplines_id", x => x.id);
                });

            migrationBuilder.AddForeignKey(
                name: "fk_discipline_id",
                table: "Marks",
                column: "discipline_id",
                principalTable: "Disciplines",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Disciplines_discipline_id",
                table: "Tests",
                column: "discipline_id",
                principalTable: "Disciplines",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_discipline_id",
                table: "Marks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Disciplines_discipline_id",
                table: "Tests");

            migrationBuilder.DropTable(
                name: "Disciplines");

            migrationBuilder.CreateTable(
                name: "Disciplinces",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, comment: "Идентификатор дисциплины")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "Название дисциплины")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_disciplines_id", x => x.id);
                });

            migrationBuilder.AddForeignKey(
                name: "fk_discipline_id",
                table: "Marks",
                column: "discipline_id",
                principalTable: "Disciplinces",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Disciplinces_discipline_id",
                table: "Tests",
                column: "discipline_id",
                principalTable: "Disciplinces",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
