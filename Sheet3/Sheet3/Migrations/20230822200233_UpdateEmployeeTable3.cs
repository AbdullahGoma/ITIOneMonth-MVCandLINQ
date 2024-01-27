using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sheet3.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEmployeeTable3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Superssns_SuperssnId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_SuperssnId",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "SuperssnId",
                table: "Departments",
                newName: "MGRSSN");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MGRSSN",
                table: "Departments",
                newName: "SuperssnId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_SuperssnId",
                table: "Departments",
                column: "SuperssnId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Superssns_SuperssnId",
                table: "Departments",
                column: "SuperssnId",
                principalTable: "Superssns",
                principalColumn: "SSSN",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
