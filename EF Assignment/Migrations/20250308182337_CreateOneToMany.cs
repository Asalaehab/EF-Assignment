using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Assignment.Migrations
{
    /// <inheritdoc />
    public partial class CreateOneToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InstructorDepartmentId",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "courseTopicId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_InstructorDepartmentId",
                table: "Instructors",
                column: "InstructorDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_courseTopicId",
                table: "Courses",
                column: "courseTopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_courseTopicId",
                table: "Courses",
                column: "courseTopicId",
                principalTable: "Topics",
                principalColumn: "TopicId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_InstructorDepartmentId",
                table: "Instructors",
                column: "InstructorDepartmentId",
                principalTable: "Departments",
                principalColumn: "dept_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_courseTopicId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_InstructorDepartmentId",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_InstructorDepartmentId",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Courses_courseTopicId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "InstructorDepartmentId",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "courseTopicId",
                table: "Courses");
        }
    }
}
