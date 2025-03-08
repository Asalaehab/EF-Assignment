using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Assignment.Migrations
{
    /// <inheritdoc />
    public partial class FluentApISConfigrationClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TopicName",
                table: "Topics",
                newName: "Topic Name");

            migrationBuilder.RenameColumn(
                name: "FName",
                table: "students",
                newName: "First Name");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "students",
                newName: "Student Age");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "students",
                newName: " Student Address");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Instructors",
                newName: "Instructor Name");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Courses",
                newName: "Course Name");

            migrationBuilder.AlterColumn<string>(
                name: "Topic Name",
                table: "Topics",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LName",
                table: "students",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "First Name",
                table: "students",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: " Student Address",
                table: "students",
                type: "varchar(500)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Instructor Name",
                table: "Instructors",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Course Name",
                table: "Courses",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Topic Name",
                table: "Topics",
                newName: "TopicName");

            migrationBuilder.RenameColumn(
                name: "Student Age",
                table: "students",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "First Name",
                table: "students",
                newName: "FName");

            migrationBuilder.RenameColumn(
                name: " Student Address",
                table: "students",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "Instructor Name",
                table: "Instructors",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Course Name",
                table: "Courses",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "TopicName",
                table: "Topics",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "LName",
                table: "students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "FName",
                table: "students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(500)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)");
        }
    }
}
