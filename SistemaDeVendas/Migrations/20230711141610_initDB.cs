using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SistemaDeVendas.Migrations
{
    /// <inheritdoc />
    public partial class initDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriaProduto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaProduto", x => x.Id);
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
                name: "enderecousuario",
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
                    table.PrimaryKey("PK_enderecousuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinalidadeProduto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinalidadeProduto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarcaProduto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarcaProduto", x => x.Id);
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
                    FechamentoCegoPDV = table.Column<bool>(type: "boolean", nullable: false),
                    LimiteNumerarioCaixa = table.Column<float>(type: "real", nullable: false),
                    CupomTroca = table.Column<bool>(type: "boolean", nullable: false),
                    PrasoCupomTroca = table.Column<int>(type: "integer", nullable: false),
                    BloqVendaEstoqueNegativo = table.Column<bool>(type: "boolean", nullable: false),
                    BloqProducaoEstoqueNegativo = table.Column<bool>(type: "boolean", nullable: false),
                    MovimentacaoEstoqViaXML = table.Column<bool>(type: "boolean", nullable: false),
                    CadastroDeProdutoViaPedidoCompra = table.Column<bool>(type: "boolean", nullable: false),
                    CadastroDeProdutoViaPedidoVenda = table.Column<bool>(type: "boolean", nullable: false),
                    ValorizacaoEstoque = table.Column<int>(type: "integer", nullable: false),
                    TipoImpressao = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParametrosdeVendas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PodeAcessar = table.Column<bool>(type: "boolean", nullable: false),
                    PodeCriar = table.Column<bool>(type: "boolean", nullable: false),
                    PodeAlterar = table.Column<bool>(type: "boolean", nullable: false),
                    PodeExcluir = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RCMProduto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Codigo = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RCMProduto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoProduto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Codigo = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoProduto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnidadeProduto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadeProduto", x => x.Id);
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
                    Senha = table.Column<string>(type: "text", nullable: false),
                    Sexo = table.Column<int>(type: "integer", nullable: false),
                    EnderecoId = table.Column<int>(type: "integer", nullable: true),
                    DataNascimento = table.Column<DateOnly>(type: "date", nullable: false),
                    DataCriacao = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Site = table.Column<string>(type: "text", nullable: false),
                    Observacao = table.Column<string>(type: "text", nullable: false),
                    Ativo = table.Column<bool>(type: "boolean", nullable: false),
                    Roles = table.Column<int>(type: "integer", nullable: false),
                    OperadorPDV = table.Column<bool>(type: "boolean", nullable: false),
                    ADMPDV = table.Column<bool>(type: "boolean", nullable: false),
                    Vendedor = table.Column<bool>(type: "boolean", nullable: false),
                    Comprador = table.Column<bool>(type: "boolean", nullable: false),
                    Comissao = table.Column<float>(type: "real", nullable: false),
                    Telefone = table.Column<string>(type: "text", nullable: false),
                    Celular = table.Column<string>(type: "text", nullable: false),
                    TipoPessoa = table.Column<int>(type: "integer", nullable: false),
                    CPF = table.Column<string>(type: "text", nullable: false),
                    CNPJ = table.Column<string>(type: "text", nullable: false),
                    IE = table.Column<string>(type: "text", nullable: false),
                    IM = table.Column<string>(type: "text", nullable: false),
                    RG = table.Column<string>(type: "text", nullable: false),
                    Foto = table.Column<byte[]>(type: "bytea", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_usuario_enderecousuario_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "enderecousuario",
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
                    Logo = table.Column<byte[]>(type: "bytea", nullable: true),
                    CNPJ = table.Column<string>(type: "text", nullable: false),
                    Ativo = table.Column<bool>(type: "boolean", nullable: false),
                    AreaDeAtuacao = table.Column<int>(type: "integer", nullable: false),
                    Telefone = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    IE = table.Column<string>(type: "text", nullable: false),
                    IM = table.Column<string>(type: "text", nullable: false),
                    DataCriacao = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    ParametroDeVendaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empresa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_empresa_ParametrosdeVendas_ParametroDeVendaId",
                        column: x => x.ParametroDeVendaId,
                        principalTable: "ParametrosdeVendas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dadosBancariosUsuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Bancos = table.Column<int>(type: "integer", nullable: false),
                    Agencia = table.Column<decimal>(type: "numeric", nullable: false),
                    DigitoAgencia = table.Column<decimal>(type: "numeric", nullable: false),
                    Conta = table.Column<decimal>(type: "numeric", nullable: false),
                    DigitoConta = table.Column<decimal>(type: "numeric", nullable: false),
                    DataCriacao = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UsuarioModelId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dadosBancariosUsuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dadosBancariosUsuario_usuario_UsuarioModelId",
                        column: x => x.UsuarioModelId,
                        principalTable: "usuario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "documentoUsuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Tipo = table.Column<int>(type: "integer", nullable: false),
                    FotoDocumento = table.Column<byte[]>(type: "bytea", nullable: false),
                    DataCriacao = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UsuarioModelId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_documentoUsuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_documentoUsuarios_usuario_UsuarioModelId",
                        column: x => x.UsuarioModelId,
                        principalTable: "usuario",
                        principalColumn: "Id");
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
                name: "dadosBancariosEmpresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Bancos = table.Column<int>(type: "integer", nullable: false),
                    Agencia = table.Column<decimal>(type: "numeric", nullable: false),
                    DigitoAgencia = table.Column<decimal>(type: "numeric", nullable: false),
                    Conta = table.Column<decimal>(type: "numeric", nullable: false),
                    DigitoConta = table.Column<decimal>(type: "numeric", nullable: false),
                    DataCriacao = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    EmpresaModelId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dadosBancariosEmpresa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dadosBancariosEmpresa_empresa_EmpresaModelId",
                        column: x => x.EmpresaModelId,
                        principalTable: "empresa",
                        principalColumn: "Id");
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

            migrationBuilder.CreateTable(
                name: "enderecoEmpresaCorrespondencia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Rua = table.Column<string>(type: "text", nullable: false),
                    Cidade = table.Column<string>(type: "text", nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: false),
                    Bairro = table.Column<string>(type: "text", nullable: false),
                    CEP = table.Column<string>(type: "text", nullable: false),
                    EmpresaModelId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enderecoEmpresaCorrespondencia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_enderecoEmpresaCorrespondencia_empresa_EmpresaModelId",
                        column: x => x.EmpresaModelId,
                        principalTable: "empresa",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "enderecoEmpresaEntrega",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Rua = table.Column<string>(type: "text", nullable: false),
                    Cidade = table.Column<string>(type: "text", nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: false),
                    Bairro = table.Column<string>(type: "text", nullable: false),
                    CEP = table.Column<string>(type: "text", nullable: false),
                    EmpresaModelId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enderecoEmpresaEntrega", x => x.Id);
                    table.ForeignKey(
                        name: "FK_enderecoEmpresaEntrega_empresa_EmpresaModelId",
                        column: x => x.EmpresaModelId,
                        principalTable: "empresa",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "enderecoEmpresaFaturamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Rua = table.Column<string>(type: "text", nullable: false),
                    Cidade = table.Column<string>(type: "text", nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: false),
                    Bairro = table.Column<string>(type: "text", nullable: false),
                    CEP = table.Column<string>(type: "text", nullable: false),
                    EmpresaModelId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enderecoEmpresaFaturamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_enderecoEmpresaFaturamento_empresa_EmpresaModelId",
                        column: x => x.EmpresaModelId,
                        principalTable: "empresa",
                        principalColumn: "Id");
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
                name: "grupoPermissoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    PermissoesJson = table.Column<string>(type: "text", nullable: false),
                    EmpresaModelId = table.Column<int>(type: "integer", nullable: true),
                    UsuarioModelId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grupoPermissoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_grupoPermissoes_empresa_EmpresaModelId",
                        column: x => x.EmpresaModelId,
                        principalTable: "empresa",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_grupoPermissoes_usuario_UsuarioModelId",
                        column: x => x.UsuarioModelId,
                        principalTable: "usuario",
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
                        name: "FK_produto_CategoriaProduto_CategoriaProdutoId",
                        column: x => x.CategoriaProdutoId,
                        principalTable: "CategoriaProduto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_produto_FinalidadeProduto_FinalidadeProdutoId",
                        column: x => x.FinalidadeProdutoId,
                        principalTable: "FinalidadeProduto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_produto_MarcaProduto_MarcaProdutoId",
                        column: x => x.MarcaProdutoId,
                        principalTable: "MarcaProduto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_produto_RCMProduto_RCMId",
                        column: x => x.RCMId,
                        principalTable: "RCMProduto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_produto_TipoProduto_TipoProdutoId",
                        column: x => x.TipoProdutoId,
                        principalTable: "TipoProduto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_produto_UnidadeProduto_UnidadeId",
                        column: x => x.UnidadeId,
                        principalTable: "UnidadeProduto",
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

            migrationBuilder.InsertData(
                table: "usuario",
                columns: new[] { "Id", "ADMPDV", "Ativo", "CNPJ", "CPF", "Celular", "Comissao", "Comprador", "DataCriacao", "DataNascimento", "Email", "EnderecoId", "Foto", "IE", "IM", "Nome", "Observacao", "OperadorPDV", "RG", "Roles", "Senha", "Sexo", "Site", "Telefone", "TipoPessoa", "Usuario", "Vendedor" },
                values: new object[] { 1, true, true, "26467564000122", "", "", 0f, true, new DateTimeOffset(new DateTime(2023, 7, 11, 14, 16, 10, 661, DateTimeKind.Unspecified).AddTicks(9202), new TimeSpan(0, 0, 0, 0, 0)), new DateOnly(2023, 6, 10), "teste@teste.com", null, null, "", "", "Master", "", true, "", 0, "4a9ccbd733db5bd7d6c09acdb551b94504aa2738195b955dd0fa64f5145a9369", 0, "", "07536312387", 1, "suporte", true });

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
                name: "IX_dadosBancariosEmpresa_EmpresaModelId",
                table: "dadosBancariosEmpresa",
                column: "EmpresaModelId");

            migrationBuilder.CreateIndex(
                name: "IX_dadosBancariosUsuario_UsuarioModelId",
                table: "dadosBancariosUsuario",
                column: "UsuarioModelId");

            migrationBuilder.CreateIndex(
                name: "IX_documentoUsuarios_UsuarioModelId",
                table: "documentoUsuarios",
                column: "UsuarioModelId");

            migrationBuilder.CreateIndex(
                name: "IX_empresa_ParametroDeVendaId",
                table: "empresa",
                column: "ParametroDeVendaId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaModelUsuarioModel_UsuariosId",
                table: "EmpresaModelUsuarioModel",
                column: "UsuariosId");

            migrationBuilder.CreateIndex(
                name: "IX_enderecoEmpresaCorrespondencia_EmpresaModelId",
                table: "enderecoEmpresaCorrespondencia",
                column: "EmpresaModelId");

            migrationBuilder.CreateIndex(
                name: "IX_enderecoEmpresaEntrega_EmpresaModelId",
                table: "enderecoEmpresaEntrega",
                column: "EmpresaModelId");

            migrationBuilder.CreateIndex(
                name: "IX_enderecoEmpresaFaturamento_EmpresaModelId",
                table: "enderecoEmpresaFaturamento",
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
                name: "IX_grupoPermissoes_EmpresaModelId",
                table: "grupoPermissoes",
                column: "EmpresaModelId");

            migrationBuilder.CreateIndex(
                name: "IX_grupoPermissoes_UsuarioModelId",
                table: "grupoPermissoes",
                column: "UsuarioModelId");

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
                name: "IX_produto_TipoProdutoId",
                table: "produto",
                column: "TipoProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_produto_UnidadeId",
                table: "produto",
                column: "UnidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_EnderecoId",
                table: "usuario",
                column: "EnderecoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContasAPagar");

            migrationBuilder.DropTable(
                name: "contasAReceber");

            migrationBuilder.DropTable(
                name: "dadosBancariosEmpresa");

            migrationBuilder.DropTable(
                name: "dadosBancariosUsuario");

            migrationBuilder.DropTable(
                name: "documentoUsuarios");

            migrationBuilder.DropTable(
                name: "EmpresaModelUsuarioModel");

            migrationBuilder.DropTable(
                name: "enderecoEmpresaCorrespondencia");

            migrationBuilder.DropTable(
                name: "enderecoEmpresaEntrega");

            migrationBuilder.DropTable(
                name: "enderecoEmpresaFaturamento");

            migrationBuilder.DropTable(
                name: "grupoPermissoes");

            migrationBuilder.DropTable(
                name: "Permissao");

            migrationBuilder.DropTable(
                name: "produto");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "CategoriaProduto");

            migrationBuilder.DropTable(
                name: "FinalidadeProduto");

            migrationBuilder.DropTable(
                name: "MarcaProduto");

            migrationBuilder.DropTable(
                name: "RCMProduto");

            migrationBuilder.DropTable(
                name: "TipoProduto");

            migrationBuilder.DropTable(
                name: "UnidadeProduto");

            migrationBuilder.DropTable(
                name: "fornecedor");

            migrationBuilder.DropTable(
                name: "enderecousuario");

            migrationBuilder.DropTable(
                name: "empresa");

            migrationBuilder.DropTable(
                name: "enderecoForecedor");

            migrationBuilder.DropTable(
                name: "ParametrosdeVendas");
        }
    }
}
