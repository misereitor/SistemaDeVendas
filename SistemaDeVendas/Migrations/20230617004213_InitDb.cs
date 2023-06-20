using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SistemaDeVendas.Migrations
{
    /// <inheritdoc />
    public partial class InitDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contatos",
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
                    table.PrimaryKey("PK_Contatos", x => x.Id);
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
                name: "ParametrosdeVendas",
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
                    table.PrimaryKey("PK_ParametrosdeVendas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "permissao",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    pode_acessar = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    pode_criar = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    pode_alterar = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    pode_excluir = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permissao", x => x.id);
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
                    EmpresaId = table.Column<int>(type: "integer", nullable: false),
                    UsuarioId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dados_bancarios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "documento_usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    tipo = table.Column<int>(type: "integer", nullable: false),
                    foto_documento = table.Column<byte[]>(type: "bytea", nullable: false),
                    UsuarioId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_documento_usuarios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "empresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeFantasia = table.Column<string>(type: "text", nullable: false),
                    RazaoSocial = table.Column<string>(type: "text", nullable: false),
                    Logo = table.Column<byte[]>(type: "bytea", nullable: true),
                    CNPJ = table.Column<string>(type: "text", nullable: false),
                    Ativo = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    AreaDeAtuacao = table.Column<int>(type: "integer", nullable: false),
                    Telefone = table.Column<decimal>(type: "numeric", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: false),
                    IE = table.Column<string>(type: "text", nullable: true),
                    IM = table.Column<string>(type: "text", nullable: true),
                    ParametroDeVendaId = table.Column<int>(type: "integer", nullable: true),
                    UsuarioModelId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empresa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_empresa_ParametrosdeVendas_ParametroDeVendaId",
                        column: x => x.ParametroDeVendaId,
                        principalTable: "ParametrosdeVendas",
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
                name: "grupo_permissoes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: false),
                    permissoes_json = table.Column<string>(type: "text", nullable: false),
                    EmpresaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grupo_permissoes", x => x.id);
                    table.ForeignKey(
                        name: "FK_grupo_permissoes_empresa_EmpresaId",
                        column: x => x.EmpresaId,
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
                    Usuario = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    Senha = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Sexo = table.Column<int>(type: "integer", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Site = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Observacao = table.Column<string>(type: "text", nullable: true),
                    Ativo = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    Master = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    OperadorPDV = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    ADMPDV = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    Vendedor = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    Comprador = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    Comissao = table.Column<float>(type: "real", nullable: true),
                    Telefone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Celular = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    TipoPessoa = table.Column<int>(type: "integer", nullable: false),
                    CPF = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    CNPJ = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    IE = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    RG = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Foto = table.Column<byte[]>(type: "bytea", nullable: true),
                    EnderecoId = table.Column<int>(type: "integer", nullable: true),
                    GrupoId = table.Column<int>(type: "integer", nullable: true),
                    EmpresaId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_usuario_empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_usuario_endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "endereco",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_usuario_grupo_permissoes_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "grupo_permissoes",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_dados_bancarios_EmpresaId",
                table: "dados_bancarios",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_dados_bancarios_UsuarioId",
                table: "dados_bancarios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_documento_usuarios_UsuarioId",
                table: "documento_usuarios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_empresa_ParametroDeVendaId",
                table: "empresa",
                column: "ParametroDeVendaId");

            migrationBuilder.CreateIndex(
                name: "IX_empresa_UsuarioModelId",
                table: "empresa",
                column: "UsuarioModelId");

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
                name: "IX_grupo_permissoes_EmpresaId",
                table: "grupo_permissoes",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_EmpresaId",
                table: "usuario",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_EnderecoId",
                table: "usuario",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_GrupoId",
                table: "usuario",
                column: "GrupoId");

            migrationBuilder.AddForeignKey(
                name: "FK_dados_bancarios_empresa_EmpresaId",
                table: "dados_bancarios",
                column: "EmpresaId",
                principalTable: "empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dados_bancarios_usuario_UsuarioId",
                table: "dados_bancarios",
                column: "UsuarioId",
                principalTable: "usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_documento_usuarios_usuario_UsuarioId",
                table: "documento_usuarios",
                column: "UsuarioId",
                principalTable: "usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_empresa_usuario_UsuarioModelId",
                table: "empresa",
                column: "UsuarioModelId",
                principalTable: "usuario",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_grupo_permissoes_empresa_EmpresaId",
                table: "grupo_permissoes");

            migrationBuilder.DropForeignKey(
                name: "FK_usuario_empresa_EmpresaId",
                table: "usuario");

            migrationBuilder.DropTable(
                name: "Contatos");

            migrationBuilder.DropTable(
                name: "dados_bancarios");

            migrationBuilder.DropTable(
                name: "documento_usuarios");

            migrationBuilder.DropTable(
                name: "EmpresaEnderecoCorrespondencia");

            migrationBuilder.DropTable(
                name: "EmpresaEnderecoEntrega");

            migrationBuilder.DropTable(
                name: "EmpresaEnderecoFaturamento");

            migrationBuilder.DropTable(
                name: "permissao");

            migrationBuilder.DropTable(
                name: "empresa");

            migrationBuilder.DropTable(
                name: "ParametrosdeVendas");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "endereco");

            migrationBuilder.DropTable(
                name: "grupo_permissoes");
        }
    }
}
