using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDeVendas.Migrations
{
    /// <inheritdoc />
    public partial class usuarioRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Master",
                table: "usuario");

            migrationBuilder.AddColumn<int>(
                name: "Roles",
                table: "usuario",
                type: "integer",
                nullable: false,
                defaultValue: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Roles",
                table: "usuario");

            migrationBuilder.AddColumn<bool>(
                name: "Master",
                table: "usuario",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }
    }
}
