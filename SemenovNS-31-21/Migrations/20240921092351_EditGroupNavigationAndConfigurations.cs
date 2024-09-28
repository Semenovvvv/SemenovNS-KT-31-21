using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SemenovNS_31_21.Migrations
{
    /// <inheritdoc />
    public partial class EditGroupNavigationAndConfigurations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cd_tests_Disciplines_discipline_id",
                table: "cd_tests");

            migrationBuilder.DropForeignKey(
                name: "FK_cd_tests_cd_students_student_id",
                table: "cd_tests");

            migrationBuilder.DropColumn(
                name: "age",
                table: "cd_students");

            migrationBuilder.RenameColumn(
                name: "student_id",
                table: "cd_tests",
                newName: "f_student_id");

            migrationBuilder.RenameColumn(
                name: "result",
                table: "cd_tests",
                newName: "c_result");

            migrationBuilder.RenameColumn(
                name: "discipline_id",
                table: "cd_tests",
                newName: "f_discipline_id");

            migrationBuilder.RenameIndex(
                name: "IX_cd_tests_student_id",
                table: "cd_tests",
                newName: "IX_cd_tests_f_student_id");

            migrationBuilder.RenameIndex(
                name: "IX_cd_tests_discipline_id",
                table: "cd_tests",
                newName: "IX_cd_tests_f_discipline_id");

            migrationBuilder.RenameColumn(
                name: "surname",
                table: "cd_students",
                newName: "c_surname");

            migrationBuilder.RenameColumn(
                name: "patronymic",
                table: "cd_students",
                newName: "c_patronymic");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "cd_students",
                newName: "c_name");

            migrationBuilder.RenameColumn(
                name: "group_id",
                table: "cd_students",
                newName: "f_group_id");

            migrationBuilder.RenameColumn(
                name: "student_id",
                table: "cd_marks",
                newName: "f_student_id");

            migrationBuilder.RenameColumn(
                name: "result",
                table: "cd_marks",
                newName: "n_result");

            migrationBuilder.RenameColumn(
                name: "discipline_id",
                table: "cd_marks",
                newName: "f_discipline_id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "cd_groups",
                newName: "c_name");

            //migrationBuilder.RenameIndex(
            //    name: "IX_cd_groups_name",
            //    table: "cd_groups",
            //    newName: "IX_cd_groups_c_name");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Disciplines",
                newName: "c_name");

            migrationBuilder.AlterColumn<string>(
                name: "c_result",
                table: "cd_tests",
                type: "varchar",
                nullable: false,
                comment: "Результат",
                oldClrType: typeof(string),
                oldType: "text",
                oldComment: "Результат");

            migrationBuilder.AlterColumn<string>(
                name: "c_surname",
                table: "cd_students",
                type: "varchar",
                maxLength: 50,
                nullable: false,
                comment: "Фамилия",
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldComment: "Фамилия");

            migrationBuilder.AlterColumn<string>(
                name: "c_patronymic",
                table: "cd_students",
                type: "varchar",
                maxLength: 50,
                nullable: false,
                comment: "Отчество",
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldComment: "Отчество");

            migrationBuilder.AlterColumn<string>(
                name: "c_name",
                table: "cd_students",
                type: "varchar",
                maxLength: 50,
                nullable: false,
                comment: "Имя",
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldComment: "Имя");

            migrationBuilder.AlterColumn<short>(
                name: "n_result",
                table: "cd_marks",
                type: "int2",
                nullable: false,
                comment: "Оценка",
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "Оценка");

            migrationBuilder.AlterColumn<string>(
                name: "c_name",
                table: "cd_groups",
                type: "varchar",
                maxLength: 50,
                nullable: false,
                comment: "Название группы",
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldComment: "Название группы");

            migrationBuilder.AlterColumn<string>(
                name: "c_name",
                table: "Disciplines",
                type: "varchar",
                maxLength: 50,
                nullable: false,
                comment: "Название дисциплины",
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldComment: "Название дисциплины");

            migrationBuilder.AddForeignKey(
                name: "FK_cd_tests_Disciplines_f_discipline_id",
                table: "cd_tests",
                column: "f_discipline_id",
                principalTable: "Disciplines",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cd_tests_cd_students_f_student_id",
                table: "cd_tests",
                column: "f_student_id",
                principalTable: "cd_students",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cd_tests_Disciplines_f_discipline_id",
                table: "cd_tests");

            migrationBuilder.DropForeignKey(
                name: "FK_cd_tests_cd_students_f_student_id",
                table: "cd_tests");

            migrationBuilder.RenameColumn(
                name: "f_student_id",
                table: "cd_tests",
                newName: "student_id");

            migrationBuilder.RenameColumn(
                name: "f_discipline_id",
                table: "cd_tests",
                newName: "discipline_id");

            migrationBuilder.RenameColumn(
                name: "c_result",
                table: "cd_tests",
                newName: "result");

            migrationBuilder.RenameIndex(
                name: "IX_cd_tests_f_student_id",
                table: "cd_tests",
                newName: "IX_cd_tests_student_id");

            migrationBuilder.RenameIndex(
                name: "IX_cd_tests_f_discipline_id",
                table: "cd_tests",
                newName: "IX_cd_tests_discipline_id");

            migrationBuilder.RenameColumn(
                name: "f_group_id",
                table: "cd_students",
                newName: "group_id");

            migrationBuilder.RenameColumn(
                name: "c_surname",
                table: "cd_students",
                newName: "surname");

            migrationBuilder.RenameColumn(
                name: "c_patronymic",
                table: "cd_students",
                newName: "patronymic");

            migrationBuilder.RenameColumn(
                name: "c_name",
                table: "cd_students",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "n_result",
                table: "cd_marks",
                newName: "result");

            migrationBuilder.RenameColumn(
                name: "f_student_id",
                table: "cd_marks",
                newName: "student_id");

            migrationBuilder.RenameColumn(
                name: "f_discipline_id",
                table: "cd_marks",
                newName: "discipline_id");

            migrationBuilder.RenameColumn(
                name: "c_name",
                table: "cd_groups",
                newName: "name");

            //migrationBuilder.RenameIndex(
            //    name: "IX_cd_groups_c_name",
            //    table: "cd_groups",
            //    newName: "IX_cd_groups_name");

            migrationBuilder.RenameColumn(
                name: "c_name",
                table: "Disciplines",
                newName: "name");

            migrationBuilder.AlterColumn<string>(
                name: "result",
                table: "cd_tests",
                type: "text",
                nullable: false,
                comment: "Результат",
                oldClrType: typeof(string),
                oldType: "varchar",
                oldComment: "Результат");

            migrationBuilder.AlterColumn<string>(
                name: "surname",
                table: "cd_students",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                comment: "Фамилия",
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 50,
                oldComment: "Фамилия");

            migrationBuilder.AlterColumn<string>(
                name: "patronymic",
                table: "cd_students",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                comment: "Отчество",
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 50,
                oldComment: "Отчество");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "cd_students",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                comment: "Имя",
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 50,
                oldComment: "Имя");

            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "cd_students",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                comment: "Возраст");

            migrationBuilder.AlterColumn<int>(
                name: "result",
                table: "cd_marks",
                type: "integer",
                nullable: false,
                comment: "Оценка",
                oldClrType: typeof(short),
                oldType: "int2",
                oldComment: "Оценка");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "cd_groups",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                comment: "Название группы",
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 50,
                oldComment: "Название группы");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Disciplines",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                comment: "Название дисциплины",
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 50,
                oldComment: "Название дисциплины");

            migrationBuilder.AddForeignKey(
                name: "FK_cd_tests_Disciplines_discipline_id",
                table: "cd_tests",
                column: "discipline_id",
                principalTable: "Disciplines",
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
    }
}
