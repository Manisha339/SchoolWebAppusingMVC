using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolWebAppusingMVC.Migrations
{
    public partial class ClassTeacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClassModel",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Grade = table.Column<string>(nullable: true),
                    ClassTeacher = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassModel", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TeacherModel",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    DateOfJoining = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherModel", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassModel");

            migrationBuilder.DropTable(
                name: "TeacherModel");
        }
    }
}
