using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SistemaDeVendas.Migrations
{
    /// <inheritdoc />
    public partial class fornecedor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "enderecousuario",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "enderecoEmpresaFaturamento",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "enderecoEmpresaEntrega",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "enderecoEmpresaCorrespondencia",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "IM",
                table: "empresa",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IE",
                table: "empresa",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DataCriacao",
                table: "empresa",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DataCriacao",
                table: "documentoUsuarios",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DataCriacao",
                table: "dadosBancariosUsuario",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DataCriacao",
                table: "dadosBancariosEmpresa",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.CreateTable(
                name: "CategoriaProdutoModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaProdutoModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "contasAReceber",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Valor = table.Column<decimal>(type: "numeric", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    DataVencimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DatCriacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Pago = table.Column<bool>(type: "boolean", nullable: false),
                    EmpresaModelId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contasAReceber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_contasAReceber_empresa_EmpresaModelId",
                        column: x => x.EmpresaModelId,
                        principalTable: "empresa",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "enderecoForecedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Rua = table.Column<string>(type: "text", nullable: false),
                    Cidade = table.Column<string>(type: "text", nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: false),
                    Bairro = table.Column<string>(type: "text", nullable: false),
                    CEP = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enderecoForecedor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinalidadeProdutoModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinalidadeProdutoModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarcaProdutoModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarcaProdutoModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RCMProdutoModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Codigo = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RCMProdutoModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoProdutoModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Codigo = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoProdutoModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnidadeProdutoModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadeProdutoModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "fornecedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RazaoSocial = table.Column<string>(type: "text", nullable: false),
                    NomeFantasia = table.Column<string>(type: "text", nullable: false),
                    Sexo = table.Column<int>(type: "integer", nullable: false),
                    RG = table.Column<string>(type: "text", nullable: false),
                    CPF = table.Column<string>(type: "text", nullable: false),
                    ExpedicaoRG = table.Column<string>(type: "text", nullable: false),
                    ContribuinteIE = table.Column<bool>(type: "boolean", nullable: false),
                    CNPJ = table.Column<string>(type: "text", nullable: false),
                    IE = table.Column<string>(type: "text", nullable: false),
                    IM = table.Column<string>(type: "text", nullable: false),
                    TipoPessoa = table.Column<int>(type: "integer", nullable: false),
                    Telefone = table.Column<string>(type: "text", nullable: false),
                    Celular = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Site = table.Column<string>(type: "text", nullable: false),
                    Observacao = table.Column<string>(type: "text", nullable: false),
                    EnderecoId = table.Column<int>(type: "integer", nullable: true),
                    Ativo = table.Column<bool>(type: "boolean", nullable: false),
                    Transportadora = table.Column<bool>(type: "boolean", nullable: false),
                    ProdutorRutal = table.Column<bool>(type: "boolean", nullable: false),
                    EmpresaModelId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fornecedor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_fornecedor_empresa_EmpresaModelId",
                        column: x => x.EmpresaModelId,
                        principalTable: "empresa",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_fornecedor_enderecoForecedor_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "enderecoForecedor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ContasAPagar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Valor = table.Column<decimal>(type: "numeric", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    DataVencimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DatCriacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Pago = table.Column<bool>(type: "boolean", nullable: false),
                    FornecedorId = table.Column<int>(type: "integer", nullable: false),
                    EmpresaModelId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContasAPagar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContasAPagar_empresa_EmpresaModelId",
                        column: x => x.EmpresaModelId,
                        principalTable: "empresa",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ContasAPagar_fornecedor_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "fornecedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    CodigoDeBarras = table.Column<decimal>(type: "numeric", nullable: false),
                    TipoProdutoId = table.Column<int>(type: "integer", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    PrecoDeCusto = table.Column<float>(type: "real", nullable: false),
                    PrecoVendaVarejo = table.Column<float>(type: "real", nullable: false),
                    PrecoVendaAtacado = table.Column<float>(type: "real", nullable: false),
                    UnidadeId = table.Column<int>(type: "integer", nullable: false),
                    Ativo = table.Column<bool>(type: "boolean", nullable: false),
                    FornecedorId = table.Column<int>(type: "integer", nullable: false),
                    CategoriaProdutoId = table.Column<int>(type: "integer", nullable: false),
                    SubcategoriaProdutoId = table.Column<int>(type: "integer", nullable: false),
                    MovimentaEstoque = table.Column<bool>(type: "boolean", nullable: false),
                    EstoqueMinimo = table.Column<int>(type: "integer", nullable: false),
                    QuantidadeEmEstoque = table.Column<int>(type: "integer", nullable: false),
                    MarcaProdutoId = table.Column<int>(type: "integer", nullable: false),
                    Modelo = table.Column<string>(type: "text", nullable: false),
                    CodigoBalanca = table.Column<decimal>(type: "numeric", nullable: false),
                    CodigoInterno = table.Column<decimal>(type: "numeric", nullable: false),
                    FinalidadeProdutoId = table.Column<int>(type: "integer", nullable: false),
                    RCMId = table.Column<int>(type: "integer", nullable: false),
                    DataValidade = table.Column<DateOnly>(type: "date", nullable: false),
                    DataCriacao = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Garantia = table.Column<int>(type: "integer", nullable: false),
                    EmpresaModelId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_produto_CategoriaProdutoModel_CategoriaProdutoId",
                        column: x => x.CategoriaProdutoId,
                        principalTable: "CategoriaProdutoModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_produto_CategoriaProdutoModel_SubcategoriaProdutoId",
                        column: x => x.SubcategoriaProdutoId,
                        principalTable: "CategoriaProdutoModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_produto_FinalidadeProdutoModel_FinalidadeProdutoId",
                        column: x => x.FinalidadeProdutoId,
                        principalTable: "FinalidadeProdutoModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_produto_MarcaProdutoModel_MarcaProdutoId",
                        column: x => x.MarcaProdutoId,
                        principalTable: "MarcaProdutoModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_produto_RCMProdutoModel_RCMId",
                        column: x => x.RCMId,
                        principalTable: "RCMProdutoModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_produto_TipoProdutoModel_TipoProdutoId",
                        column: x => x.TipoProdutoId,
                        principalTable: "TipoProdutoModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_produto_UnidadeProdutoModel_UnidadeId",
                        column: x => x.UnidadeId,
                        principalTable: "UnidadeProdutoModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_produto_empresa_EmpresaModelId",
                        column: x => x.EmpresaModelId,
                        principalTable: "empresa",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_produto_fornecedor_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "fornecedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 7, 2, 17, 17, 46, 647, DateTimeKind.Unspecified).AddTicks(8337), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_ContasAPagar_EmpresaModelId",
                table: "ContasAPagar",
                column: "EmpresaModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ContasAPagar_FornecedorId",
                table: "ContasAPagar",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_contasAReceber_EmpresaModelId",
                table: "contasAReceber",
                column: "EmpresaModelId");

            migrationBuilder.CreateIndex(
                name: "IX_fornecedor_EmpresaModelId",
                table: "fornecedor",
                column: "EmpresaModelId");

            migrationBuilder.CreateIndex(
                name: "IX_fornecedor_EnderecoId",
                table: "fornecedor",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_produto_CategoriaProdutoId",
                table: "produto",
                column: "CategoriaProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_produto_EmpresaModelId",
                table: "produto",
                column: "EmpresaModelId");

            migrationBuilder.CreateIndex(
                name: "IX_produto_FinalidadeProdutoId",
                table: "produto",
                column: "FinalidadeProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_produto_FornecedorId",
                table: "produto",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_produto_MarcaProdutoId",
                table: "produto",
                column: "MarcaProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_produto_RCMId",
                table: "produto",
                column: "RCMId");

            migrationBuilder.CreateIndex(
                name: "IX_produto_SubcategoriaProdutoId",
                table: "produto",
                column: "SubcategoriaProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_produto_TipoProdutoId",
                table: "produto",
                column: "TipoProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_produto_UnidadeId",
                table: "produto",
                column: "UnidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContasAPagar");

            migrationBuilder.DropTable(
                name: "contasAReceber");

            migrationBuilder.DropTable(
                name: "produto");

            migrationBuilder.DropTable(
                name: "CategoriaProdutoModel");

            migrationBuilder.DropTable(
                name: "FinalidadeProdutoModel");

            migrationBuilder.DropTable(
                name: "MarcaProdutoModel");

            migrationBuilder.DropTable(
                name: "RCMProdutoModel");

            migrationBuilder.DropTable(
                name: "TipoProdutoModel");

            migrationBuilder.DropTable(
                name: "UnidadeProdutoModel");

            migrationBuilder.DropTable(
                name: "fornecedor");

            migrationBuilder.DropTable(
                name: "enderecoForecedor");

            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "enderecousuario");

            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "enderecoEmpresaFaturamento");

            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "enderecoEmpresaEntrega");

            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "enderecoEmpresaCorrespondencia");

            migrationBuilder.DropColumn(
                name: "DataCriacao",
                table: "empresa");

            migrationBuilder.DropColumn(
                name: "DataCriacao",
                table: "documentoUsuarios");

            migrationBuilder.DropColumn(
                name: "DataCriacao",
                table: "dadosBancariosUsuario");

            migrationBuilder.DropColumn(
                name: "DataCriacao",
                table: "dadosBancariosEmpresa");

            migrationBuilder.AlterColumn<string>(
                name: "IM",
                table: "empresa",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "IE",
                table: "empresa",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTimeOffset(new DateTime(2023, 6, 24, 14, 35, 15, 484, DateTimeKind.Unspecified).AddTicks(4815), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
