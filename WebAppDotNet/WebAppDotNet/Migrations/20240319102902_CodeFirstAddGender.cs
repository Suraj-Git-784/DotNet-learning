using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppDotNet.Migrations
{
    /// <inheritdoc />
    public partial class CodeFirstAddGender : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeGender",
                table: "Employees",
                type: "varchar(10)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeGender",
                table: "Employees");
        }
    }
}
