using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDeVendas.Migrations
{
    /// <inheritdoc />
    public partial class RenameDocumentoUsuariosModelTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
            name: "DocumentoUsuariosModel",
            newName: "DocumentoUsuarios",
            newSchema: "public");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
            name: "DocumentoUsuarios",
            newName: "DocumentoUsuariosModel",
            newSchema: "public");
        }
    }
}
