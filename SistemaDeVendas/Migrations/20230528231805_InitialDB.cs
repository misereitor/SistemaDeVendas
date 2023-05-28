using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SistemaDeVendas.Migrations
{
    /// <inheritdoc />
    public partial class InitialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Senha = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    Funcao = table.Column<string>(type: "text", nullable: false),
                    Ativo = table.Column<bool>(type: "boolean", nullable: true),
                    Perfil = table.Column<int>(type: "integer", nullable: false),
                    PDV = table.Column<bool>(type: "boolean", nullable: false),
                    ADMPDV = table.Column<bool>(type: "boolean", nullable: false),
                    Vendedor = table.Column<bool>(type: "boolean", nullable: false),
                    Comissao = table.Column<float>(type: "real", nullable: true),
                    Telefone = table.Column<decimal>(type: "numeric", nullable: true),
                    CPF = table.Column<decimal>(type: "numeric", nullable: false),
                    Foto = table.Column<byte[]>(type: "bytea", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "empresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeFantasia = table.Column<string>(type: "text", nullable: false),
                    RazaoSocial = table.Column<string>(type: "text", nullable: false),
                    Logo = table.Column<byte[]>(type: "bytea", nullable: false),
                    CNPJ = table.Column<decimal>(type: "numeric", nullable: false),
                    Ativo = table.Column<bool>(type: "boolean", nullable: false),
                    AreaDeAtuacao = table.Column<string>(type: "text", nullable: false),
                    Telefone = table.Column<decimal>(type: "numeric", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    IE = table.Column<string>(type: "text", nullable: false),
                    IM = table.Column<string>(type: "text", nullable: false),
                    EnderecoEntregaId = table.Column<int>(type: "integer", nullable: false),
                    EnderecoFaturamentoId = table.Column<int>(type: "integer", nullable: false),
                    EnderecoCorrespondenciaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empresa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmpresaUsuario",
                columns: table => new
                {
                    Usuarios = table.Column<int>(type: "integer", nullable: false),
                    Empresas = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaUsuario", x => new { x.Usuarios, x.Empresas });
                    table.ForeignKey(
                        name: "FK_EmpresaUsuario_empresa_Empresas",
                        column: x => x.Empresas,
                        principalTable: "empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpresaUsuario_usuario_Usuarios",
                        column: x => x.Usuarios,
                        principalTable: "usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "endereco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Rua = table.Column<string>(type: "text", nullable: false),
                    Cidade = table.Column<string>(type: "text", nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: false),
                    CEP = table.Column<string>(type: "text", nullable: false),
                    EmpresaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_endereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_endereco_empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioEmpresa",
                columns: table => new
                {
                    Empresas = table.Column<int>(type: "integer", nullable: false),
                    Usuarios = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioEmpresa", x => new { x.Empresas, x.Usuarios });
                    table.ForeignKey(
                        name: "FK_UsuarioEmpresa_empresa_Empresas",
                        column: x => x.Empresas,
                        principalTable: "empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioEmpresa_usuario_Usuarios",
                        column: x => x.Usuarios,
                        principalTable: "usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "EmpresaUsuario",
                columns: new[] { "Empresas", "Usuarios" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "UsuarioEmpresa",
                columns: new[] { "Empresas", "Usuarios" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_empresa_EnderecoCorrespondenciaId",
                table: "empresa",
                column: "EnderecoCorrespondenciaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_empresa_EnderecoEntregaId",
                table: "empresa",
                column: "EnderecoEntregaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_empresa_EnderecoFaturamentoId",
                table: "empresa",
                column: "EnderecoFaturamentoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaUsuario_Empresas",
                table: "EmpresaUsuario",
                column: "Empresas");

            migrationBuilder.CreateIndex(
                name: "IX_endereco_EmpresaId",
                table: "endereco",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioEmpresa_Usuarios",
                table: "UsuarioEmpresa",
                column: "Usuarios");

            migrationBuilder.AddForeignKey(
                name: "FK_empresa_endereco_EnderecoCorrespondenciaId",
                table: "empresa",
                column: "EnderecoCorrespondenciaId",
                principalTable: "endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_empresa_endereco_EnderecoEntregaId",
                table: "empresa",
                column: "EnderecoEntregaId",
                principalTable: "endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_empresa_endereco_EnderecoFaturamentoId",
                table: "empresa",
                column: "EnderecoFaturamentoId",
                principalTable: "endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_empresa_endereco_EnderecoCorrespondenciaId",
                table: "empresa");

            migrationBuilder.DropForeignKey(
                name: "FK_empresa_endereco_EnderecoEntregaId",
                table: "empresa");

            migrationBuilder.DropForeignKey(
                name: "FK_empresa_endereco_EnderecoFaturamentoId",
                table: "empresa");

            migrationBuilder.DropTable(
                name: "EmpresaUsuario");

            migrationBuilder.DropTable(
                name: "UsuarioEmpresa");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "endereco");

            migrationBuilder.DropTable(
                name: "empresa");
        }
    }
}
