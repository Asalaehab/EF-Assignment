using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Assignment.Migrations
{
    /// <inheritdoc />
    public partial class CreateOneToManyStudentToDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentDepartmentId",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_students_StudentDepartmentId",
                table: "students",
                column: "StudentDepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_students_Departments_StudentDepartmentId",
                table: "students",
                column: "StudentDepartmentId",
                principalTable: "Departments",
                principalColumn: "dept_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_Departments_StudentDepartmentId",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_StudentDepartmentId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "StudentDepartmentId",
                table: "students");
        }
    }
}
