using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreSession1.Migrations
{
    /// <inheritdoc />
    public partial class AddPasswordColoumnInEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Hamada",
                schema: "dbo",
                table: "Hamada");

            migrationBuilder.RenameTable(
                name: "Hamada",
                schema: "dbo",
                newName: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "EmpId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Employees");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Hamada",
                newSchema: "dbo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hamada",
                schema: "dbo",
                table: "Hamada",
                column: "EmpId");
        }
    }
}
