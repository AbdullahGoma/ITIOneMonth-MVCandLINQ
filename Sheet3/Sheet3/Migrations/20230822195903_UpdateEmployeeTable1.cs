using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sheet3.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEmployeeTable1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Employees",
                newName: "EmployeeSSN");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeeSSN",
                table: "Employees",
                newName: "EmployeeId");
        }
    }
}
