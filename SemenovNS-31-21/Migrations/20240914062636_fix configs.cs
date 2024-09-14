using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SemenovNS_31_21.Migrations
{
    /// <inheritdoc />
    public partial class fixconfigs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Marks_Disciplinces_DisciplineId",
                table: "Marks");

            migrationBuilder.DropForeignKey(
                name: "FK_Marks_Students_StudentId",
                table: "Marks");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Disciplinces_DisciplineId",
                table: "Tests");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Students_StudentId",
                table: "Tests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tests",
                table: "Tests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Marks",
                table: "Marks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Groups",
                table: "Groups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Disciplinces",
                table: "Disciplinces");

            migrationBuilder.RenameColumn(
                name: "Result",
                table: "Tests",
                newName: "result");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tests",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Tests",
                newName: "student_id");

            migrationBuilder.RenameColumn(
                name: "DisciplineId",
                table: "Tests",
                newName: "discipline_id");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_StudentId",
                table: "Tests",
                newName: "IX_Tests_student_id");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_DisciplineId",
                table: "Tests",
                newName: "IX_Tests_discipline_id");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Students",
                newName: "surname");

            migrationBuilder.RenameColumn(
                name: "Patronymic",
                table: "Students",
                newName: "patronymic");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Students",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Students",
                newName: "age");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Students",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "Students",
                newName: "group_id");

            migrationBuilder.RenameIndex(
                name: "IX_Students_GroupId",
                table: "Students",
                newName: "idx_students_fk_group_id");

            migrationBuilder.RenameColumn(
                name: "Result",
                table: "Marks",
                newName: "result");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Marks",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Marks",
                newName: "student_id");

            migrationBuilder.RenameColumn(
                name: "DisciplineId",
                table: "Marks",
                newName: "discipline_id");

            migrationBuilder.RenameIndex(
                name: "IX_Marks_StudentId",
                table: "Marks",
                newName: "idx_marks_fk_student_id");

            migrationBuilder.RenameIndex(
                name: "IX_Marks_DisciplineId",
                table: "Marks",
                newName: "idx_marks_fk_discipline_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Groups",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Groups",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Disciplinces",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Disciplinces",
                newName: "id");

            migrationBuilder.AlterColumn<string>(
                name: "result",
                table: "Tests",
                type: "text",
                nullable: false,
                comment: "Результат",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Tests",
                type: "integer",
                nullable: false,
                comment: "Идентификатор зачета",
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "student_id",
                table: "Tests",
                type: "integer",
                nullable: false,
                comment: "Идентификатор студента",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "discipline_id",
                table: "Tests",
                type: "integer",
                nullable: false,
                comment: "Идентификатор дисциплины",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "surname",
                table: "Students",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                comment: "Фамилия",
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "patronymic",
                table: "Students",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                comment: "Отчество",
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Students",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                comment: "Имя",
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "age",
                table: "Students",
                type: "integer",
                nullable: false,
                comment: "Возраст",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Students",
                type: "integer",
                nullable: false,
                comment: "Идентификатор студента",
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "group_id",
                table: "Students",
                type: "integer",
                nullable: false,
                comment: "Идентификатор группы",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "result",
                table: "Marks",
                type: "integer",
                nullable: false,
                comment: "Оценка",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Marks",
                type: "integer",
                nullable: false,
                comment: "Идентфикатор оценки",
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "student_id",
                table: "Marks",
                type: "integer",
                nullable: false,
                comment: "Идентификатор студента",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "discipline_id",
                table: "Marks",
                type: "integer",
                nullable: false,
                comment: "Идентификатор дисциплины",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Groups",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                comment: "Название группы",
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Groups",
                type: "integer",
                nullable: false,
                comment: "Идентификатор группы",
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Disciplinces",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                comment: "Название дисциплины",
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Disciplinces",
                type: "integer",
                nullable: false,
                comment: "Идентификатор дисциплины",
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "pk_tests_id",
                table: "Tests",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_students_id",
                table: "Students",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_marks_id",
                table: "Marks",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_groups_id",
                table: "Groups",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_disciplines_id",
                table: "Disciplinces",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_discipline_id",
                table: "Marks",
                column: "discipline_id",
                principalTable: "Disciplinces",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_student_id",
                table: "Marks",
                column: "student_id",
                principalTable: "Students",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_group_id",
                table: "Students",
                column: "group_id",
                principalTable: "Groups",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Disciplinces_discipline_id",
                table: "Tests",
                column: "discipline_id",
                principalTable: "Disciplinces",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_discipline_id",
                table: "Marks");

            migrationBuilder.DropForeignKey(
                name: "fk_student_id",
                table: "Marks");

            migrationBuilder.DropForeignKey(
                name: "fk_group_id",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Disciplinces_discipline_id",
                table: "Tests");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Students_student_id",
                table: "Tests");

            migrationBuilder.DropPrimaryKey(
                name: "pk_tests_id",
                table: "Tests");

            migrationBuilder.DropPrimaryKey(
                name: "pk_students_id",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "pk_marks_id",
                table: "Marks");

            migrationBuilder.DropPrimaryKey(
                name: "pk_groups_id",
                table: "Groups");

            migrationBuilder.DropPrimaryKey(
                name: "pk_disciplines_id",
                table: "Disciplinces");

            migrationBuilder.RenameColumn(
                name: "result",
                table: "Tests",
                newName: "Result");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Tests",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "student_id",
                table: "Tests",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "discipline_id",
                table: "Tests",
                newName: "DisciplineId");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_student_id",
                table: "Tests",
                newName: "IX_Tests_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_discipline_id",
                table: "Tests",
                newName: "IX_Tests_DisciplineId");

            migrationBuilder.RenameColumn(
                name: "surname",
                table: "Students",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "patronymic",
                table: "Students",
                newName: "Patronymic");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Students",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "age",
                table: "Students",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Students",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "group_id",
                table: "Students",
                newName: "GroupId");

            migrationBuilder.RenameIndex(
                name: "idx_students_fk_group_id",
                table: "Students",
                newName: "IX_Students_GroupId");

            migrationBuilder.RenameColumn(
                name: "result",
                table: "Marks",
                newName: "Result");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Marks",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "student_id",
                table: "Marks",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "discipline_id",
                table: "Marks",
                newName: "DisciplineId");

            migrationBuilder.RenameIndex(
                name: "idx_marks_fk_student_id",
                table: "Marks",
                newName: "IX_Marks_StudentId");

            migrationBuilder.RenameIndex(
                name: "idx_marks_fk_discipline_id",
                table: "Marks",
                newName: "IX_Marks_DisciplineId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Groups",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Groups",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Disciplinces",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Disciplinces",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Result",
                table: "Tests",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldComment: "Результат");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Tests",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "Идентификатор зачета")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Tests",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "Идентификатор студента");

            migrationBuilder.AlterColumn<int>(
                name: "DisciplineId",
                table: "Tests",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "Идентификатор дисциплины");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Students",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldComment: "Фамилия");

            migrationBuilder.AlterColumn<string>(
                name: "Patronymic",
                table: "Students",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldComment: "Отчество");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Students",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldComment: "Имя");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Students",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "Возраст");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Students",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "Идентификатор студента")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "Students",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "Идентификатор группы");

            migrationBuilder.AlterColumn<int>(
                name: "Result",
                table: "Marks",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "Оценка");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Marks",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "Идентфикатор оценки")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Marks",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "Идентификатор студента");

            migrationBuilder.AlterColumn<int>(
                name: "DisciplineId",
                table: "Marks",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "Идентификатор дисциплины");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Groups",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldComment: "Название группы");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Groups",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "Идентификатор группы")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Disciplinces",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldComment: "Название дисциплины");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Disciplinces",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "Идентификатор дисциплины")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tests",
                table: "Tests",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Marks",
                table: "Marks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Groups",
                table: "Groups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Disciplinces",
                table: "Disciplinces",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Marks_Disciplinces_DisciplineId",
                table: "Marks",
                column: "DisciplineId",
                principalTable: "Disciplinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Marks_Students_StudentId",
                table: "Marks",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Disciplinces_DisciplineId",
                table: "Tests",
                column: "DisciplineId",
                principalTable: "Disciplinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Students_StudentId",
                table: "Tests",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
