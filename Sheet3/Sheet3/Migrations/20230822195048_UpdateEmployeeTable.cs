using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sheet3.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEmployeeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Superssns_MGRSSN",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Superssns_SuperssnId",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "SuperssnId",
                table: "Employees",
                newName: "EmployeeeSSN");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_SuperssnId",
                table: "Employees",
                newName: "IX_Employees_EmployeeeSSN");

            migrationBuilder.RenameColumn(
                name: "MGRSSN",
                table: "Departments",
                newName: "SuperssnId");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_MGRSSN",
                table: "Departments",
                newName: "IX_Departments_SuperssnId");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Superssns_SuperssnId",
                table: "Departments",
                column: "SuperssnId",
                principalTable: "Superssns",
                principalColumn: "SSSN",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_EmployeeeSSN",
                table: "Employees",
                column: "EmployeeeSSN",
                principalTable: "Employees",
                principalColumn: "SSN",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Superssns_SuperssnId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_EmployeeeSSN",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "EmployeeeSSN",
                table: "Employees",
                newName: "SuperssnId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_EmployeeeSSN",
                table: "Employees",
                newName: "IX_Employees_SuperssnId");

            migrationBuilder.RenameColumn(
                name: "SuperssnId",
                table: "Departments",
                newName: "MGRSSN");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_SuperssnId",
                table: "Departments",
                newName: "IX_Departments_MGRSSN");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Superssns_MGRSSN",
                table: "Departments",
                column: "MGRSSN",
                principalTable: "Superssns",
                principalColumn: "SSSN",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Superssns_SuperssnId",
                table: "Employees",
                column: "SuperssnId",
                principalTable: "Superssns",
                principalColumn: "SSSN",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
