using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorServerCRUD.Api.Migrations
{
    public partial class InitialDBMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    DepartmentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentID", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "HR" },
                    { 3, "Payroll" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "DateOfBirth", "DepartmentID", "EmployeeName", "Gender" },
                values: new object[,]
                {
                    { 1, new DateTime(1989, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "John", 0 },
                    { 2, new DateTime(1989, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Matt", 0 },
                    { 3, new DateTime(1989, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Carol", 1 },
                    { 4, new DateTime(1989, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Tony", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
