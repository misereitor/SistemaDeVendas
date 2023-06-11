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
                name: "ContatosModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Cargo = table.Column<string>(type: "text", nullable: false),
                    Telefone = table.Column<decimal>(type: "numeric", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContatosModel", x => x.Id);
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
                    CEP = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_endereco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GrupoPermissaoUsuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoPermissaoUsuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParametrosDeVendas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                    table.PrimaryKey("PK_ParametrosDeVendas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PermissaoModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    PodeAcessar = table.Column<bool>(type: "boolean", nullable: false),
                    PodeCriar = table.Column<bool>(type: "boolean", nullable: false),
                    PodeAlterar = table.Column<bool>(type: "boolean", nullable: false),
                    PodeExcluir = table.Column<bool>(type: "boolean", nullable: false),
                    GrupoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissaoModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PermissaoModel_GrupoPermissaoUsuarios_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "GrupoPermissaoUsuarios",
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
                    Usuario = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    Senha = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Sexo = table.Column<int>(type: "integer", nullable: false),
                    EnderecoId = table.Column<int>(type: "integer", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Site = table.Column<string>(type: "text", nullable: true),
                    Observacao = table.Column<string>(type: "text", nullable: true),
                    Ativo = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    Master = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    OperadorPDV = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    ADMPDV = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    Vendedor = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    Comprador = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    GrupoId = table.Column<int>(type: "integer", nullable: true),
                    Comissao = table.Column<float>(type: "real", nullable: true),
                    Telefone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Celular = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    TipoPessoa = table.Column<int>(type: "integer", nullable: false),
                    CPF = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: true),
                    CNPJ = table.Column<string>(type: "character varying(18)", maxLength: 18, nullable: true),
                    RG = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Foto = table.Column<byte[]>(type: "bytea", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_usuario_GrupoPermissaoUsuarios_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "GrupoPermissaoUsuarios",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_usuario_endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "endereco",
                        principalColumn: "Id");
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
                    CNPJ = table.Column<string>(type: "text", nullable: false),
                    Ativo = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    AreaDeAtuacao = table.Column<int>(type: "integer", nullable: false),
                    Telefone = table.Column<decimal>(type: "numeric", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    IE = table.Column<string>(type: "text", nullable: false),
                    IM = table.Column<string>(type: "text", nullable: false),
                    ParametroDeVendaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empresa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_empresa_ParametrosDeVendas_ParametroDeVendaId",
                        column: x => x.ParametroDeVendaId,
                        principalTable: "ParametrosDeVendas",
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
                    UsuarioModelId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dados_bancarios", x => x.id);
                    table.ForeignKey(
                        name: "FK_dados_bancarios_usuario_UsuarioModelId",
                        column: x => x.UsuarioModelId,
                        principalTable: "usuario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DocumentoUsuariosModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Tipo = table.Column<int>(type: "integer", nullable: false),
                    FotoDocumento = table.Column<byte[]>(type: "bytea", nullable: false),
                    UsuarioId = table.Column<int>(type: "integer", nullable: true),
                    UsuarioModelId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentoUsuariosModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentoUsuariosModel_usuario_UsuarioModelId",
                        column: x => x.UsuarioModelId,
                        principalTable: "usuario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmpresaEnderecoCorrespondencia",
                columns: table => new
                {
                    EmpresaId = table.Column<int>(type: "integer", nullable: false),
                    EnderecoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaEnderecoCorrespondencia", x => new { x.EmpresaId, x.EnderecoId });
                    table.ForeignKey(
                        name: "FK_EmpresaEnderecoCorrespondencia_empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpresaEnderecoCorrespondencia_endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmpresaEnderecoEntrega",
                columns: table => new
                {
                    EmpresaId = table.Column<int>(type: "integer", nullable: false),
                    EnderecoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaEnderecoEntrega", x => new { x.EmpresaId, x.EnderecoId });
                    table.ForeignKey(
                        name: "FK_EmpresaEnderecoEntrega_empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpresaEnderecoEntrega_endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmpresaEnderecoFaturamento",
                columns: table => new
                {
                    EmpresaId = table.Column<int>(type: "integer", nullable: false),
                    EnderecoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaEnderecoFaturamento", x => new { x.EmpresaId, x.EnderecoId });
                    table.ForeignKey(
                        name: "FK_EmpresaEnderecoFaturamento_empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpresaEnderecoFaturamento_endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmpresaModelUsuarioModel",
                columns: table => new
                {
                    EmpresasId = table.Column<int>(type: "integer", nullable: false),
                    UsuariosId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaModelUsuarioModel", x => new { x.EmpresasId, x.UsuariosId });
                    table.ForeignKey(
                        name: "FK_EmpresaModelUsuarioModel_empresa_EmpresasId",
                        column: x => x.EmpresasId,
                        principalTable: "empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpresaModelUsuarioModel_usuario_UsuariosId",
                        column: x => x.UsuariosId,
                        principalTable: "usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_dados_bancarios_UsuarioModelId",
                table: "dados_bancarios",
                column: "UsuarioModelId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentoUsuariosModel_UsuarioModelId",
                table: "DocumentoUsuariosModel",
                column: "UsuarioModelId");

            migrationBuilder.CreateIndex(
                name: "IX_empresa_ParametroDeVendaId",
                table: "empresa",
                column: "ParametroDeVendaId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaEnderecoCorrespondencia_EnderecoId",
                table: "EmpresaEnderecoCorrespondencia",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaEnderecoEntrega_EnderecoId",
                table: "EmpresaEnderecoEntrega",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaEnderecoFaturamento_EnderecoId",
                table: "EmpresaEnderecoFaturamento",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaModelUsuarioModel_UsuariosId",
                table: "EmpresaModelUsuarioModel",
                column: "UsuariosId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissaoModel_GrupoId",
                table: "PermissaoModel",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_EnderecoId",
                table: "usuario",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_GrupoId",
                table: "usuario",
                column: "GrupoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContatosModel");

            migrationBuilder.DropTable(
                name: "dados_bancarios");

            migrationBuilder.DropTable(
                name: "DocumentoUsuariosModel");

            migrationBuilder.DropTable(
                name: "EmpresaEnderecoCorrespondencia");

            migrationBuilder.DropTable(
                name: "EmpresaEnderecoEntrega");

            migrationBuilder.DropTable(
                name: "EmpresaEnderecoFaturamento");

            migrationBuilder.DropTable(
                name: "EmpresaModelUsuarioModel");

            migrationBuilder.DropTable(
                name: "PermissaoModel");

            migrationBuilder.DropTable(
                name: "empresa");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "ParametrosDeVendas");

            migrationBuilder.DropTable(
                name: "GrupoPermissaoUsuarios");

            migrationBuilder.DropTable(
                name: "endereco");
        }
    }
}
