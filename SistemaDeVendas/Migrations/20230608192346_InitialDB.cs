using System;
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
                name: "empresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeFantasia = table.Column<string>(type: "text", nullable: false),
                    RazaoSocial = table.Column<string>(type: "text", nullable: false),
                    Logo = table.Column<byte[]>(type: "bytea", nullable: false),
                    CNPJ = table.Column<string>(type: "text", nullable: false),
                    Ativo = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    AreaDeAtuacao = table.Column<int>(type: "integer", nullable: false),
                    Telefone = table.Column<decimal>(type: "numeric", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    IE = table.Column<string>(type: "text", nullable: false),
                    IM = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empresa", x => x.Id);
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
                    EmpresaModel_EnderecoCorrespondenciaId = table.Column<int>(type: "integer", nullable: true),
                    EmpresaModel_EnderecoEntregaId = table.Column<int>(type: "integer", nullable: true),
                    EmpresaModel_EnderecoFaturamentoId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_endereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_endereco_empresa_EmpresaModel_EnderecoCorrespondenciaId",
                        column: x => x.EmpresaModel_EnderecoCorrespondenciaId,
                        principalTable: "empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_endereco_empresa_EmpresaModel_EnderecoEntregaId",
                        column: x => x.EmpresaModel_EnderecoEntregaId,
                        principalTable: "empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_endereco_empresa_EmpresaModel_EnderecoFaturamentoId",
                        column: x => x.EmpresaModel_EnderecoFaturamentoId,
                        principalTable: "empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "parametrosdevendas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    ValidadeOrcamentoCompra = table.Column<int>(type: "integer", nullable: false),
                    ValidadeEntregaPedidoCompra = table.Column<int>(type: "integer", nullable: false),
                    ValidadeEntregaorcamentoCompra = table.Column<int>(type: "integer", nullable: false),
                    ValidadeOrcamentoVenda = table.Column<int>(type: "integer", nullable: false),
                    ValidadeEntregaDePedidoVenda = table.Column<int>(type: "integer", nullable: false),
                    ValidadeEntregaDeOrcamentoVenda = table.Column<int>(type: "integer", nullable: false),
                    LimiteDeCreditoNovosCliente = table.Column<float>(type: "real", nullable: false),
                    UtilizarLimiteCredito = table.Column<bool>(type: "boolean", nullable: false),
                    MaxDescontoPOS = table.Column<float>(type: "real", nullable: false),
                    MaxDescontoPedido = table.Column<float>(type: "real", nullable: false),
                    FechamentoCegoPDV = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    LimiteNumerarioCaixa = table.Column<float>(type: "real", nullable: false),
                    CupomTroca = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    PrasoCupomTroca = table.Column<int>(type: "integer", nullable: false),
                    BloqVendaEstoqueNegativo = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    BloqProducaoEstoqueNegativo = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    MovimentacaoEstoqViaXML = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    CadastroDeProdutoViaPedidoCompra = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    CadastroDeProdutoViaPedidoVenda = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    ValorizacaoEstoque = table.Column<int>(type: "integer", nullable: false),
                    TipoImpressao = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parametrosdevendas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_parametrosdevendas_empresa_Id",
                        column: x => x.Id,
                        principalTable: "empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Usuario = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    Senha = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    Sexo = table.Column<int>(type: "integer", nullable: false),
                    EnderecoId = table.Column<int>(type: "integer", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Site = table.Column<string>(type: "text", nullable: false),
                    Observacao = table.Column<string>(type: "text", nullable: false),
                    Ativo = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    Master = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    OperadorPDV = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    ADMPDV = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    Vendedor = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    Comprador = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    Comissao = table.Column<float>(type: "real", nullable: false),
                    Telefone = table.Column<decimal>(type: "numeric", nullable: false),
                    Celular = table.Column<decimal>(type: "numeric", nullable: false),
                    CPF = table.Column<decimal>(type: "numeric", nullable: false),
                    CNPJ = table.Column<decimal>(type: "numeric", nullable: false),
                    RG = table.Column<decimal>(type: "numeric", nullable: false),
                    Foto = table.Column<byte[]>(type: "bytea", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_usuario_endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dados_bancarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    bancos = table.Column<int>(type: "integer", nullable: false),
                    agencia = table.Column<decimal>(type: "numeric", nullable: false),
                    digito_agencia = table.Column<decimal>(type: "numeric", nullable: false),
                    conta = table.Column<decimal>(type: "numeric", nullable: false),
                    digito_conta = table.Column<decimal>(type: "numeric", nullable: false),
                    UsuarioModel_DadosBancariosId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dados_bancarios", x => x.id);
                    table.ForeignKey(
                        name: "FK_dados_bancarios_usuario_UsuarioModel_DadosBancariosId",
                        column: x => x.UsuarioModel_DadosBancariosId,
                        principalTable: "usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DocumentoUsuariosModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Tipo = table.Column<int>(type: "integer", nullable: false),
                    FotoDocumento = table.Column<byte[]>(type: "bytea", nullable: false),
                    UsuarioModel_DocumentosId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentoUsuariosModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentoUsuariosModel_usuario_UsuarioModel_DocumentosId",
                        column: x => x.UsuarioModel_DocumentosId,
                        principalTable: "usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmpresaUsuario",
                columns: table => new
                {
                    EmpresasId = table.Column<int>(type: "integer", nullable: false),
                    UsuariosId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaUsuario", x => new { x.EmpresasId, x.UsuariosId });
                    table.ForeignKey(
                        name: "FK_EmpresaUsuario_empresa_EmpresasId",
                        column: x => x.EmpresasId,
                        principalTable: "empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpresaUsuario_usuario_UsuariosId",
                        column: x => x.UsuariosId,
                        principalTable: "usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_dados_bancarios_UsuarioModel_DadosBancariosId",
                table: "dados_bancarios",
                column: "UsuarioModel_DadosBancariosId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentoUsuariosModel_UsuarioModel_DocumentosId",
                table: "DocumentoUsuariosModel",
                column: "UsuarioModel_DocumentosId");

            migrationBuilder.CreateIndex(
                name: "IX_empresa_CNPJ",
                table: "empresa",
                column: "CNPJ",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaUsuario_UsuariosId",
                table: "EmpresaUsuario",
                column: "UsuariosId");

            migrationBuilder.CreateIndex(
                name: "IX_endereco_EmpresaModel_EnderecoCorrespondenciaId",
                table: "endereco",
                column: "EmpresaModel_EnderecoCorrespondenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_endereco_EmpresaModel_EnderecoEntregaId",
                table: "endereco",
                column: "EmpresaModel_EnderecoEntregaId");

            migrationBuilder.CreateIndex(
                name: "IX_endereco_EmpresaModel_EnderecoFaturamentoId",
                table: "endereco",
                column: "EmpresaModel_EnderecoFaturamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_EnderecoId",
                table: "usuario",
                column: "EnderecoId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dados_bancarios");

            migrationBuilder.DropTable(
                name: "DocumentoUsuariosModel");

            migrationBuilder.DropTable(
                name: "EmpresaUsuario");

            migrationBuilder.DropTable(
                name: "parametrosdevendas");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "endereco");

            migrationBuilder.DropTable(
                name: "empresa");
        }
    }
}
