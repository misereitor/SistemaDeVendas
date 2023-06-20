﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SistemaDeVendas.Data;

#nullable disable

namespace SistemaDeVendas.Migrations
{
    [DbContext(typeof(ConexaoDBContext))]
    partial class ConexaoDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EmpresaEnderecoCorrespondencia", b =>
                {
                    b.Property<int>("EmpresaId")
                        .HasColumnType("integer");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("integer");

                    b.HasKey("EmpresaId", "EnderecoId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("EmpresaEnderecoCorrespondencia");
                });

            modelBuilder.Entity("EmpresaEnderecoEntrega", b =>
                {
                    b.Property<int>("EmpresaId")
                        .HasColumnType("integer");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("integer");

                    b.HasKey("EmpresaId", "EnderecoId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("EmpresaEnderecoEntrega");
                });

            modelBuilder.Entity("EmpresaEnderecoFaturamento", b =>
                {
                    b.Property<int>("EmpresaId")
                        .HasColumnType("integer");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("integer");

                    b.HasKey("EmpresaId", "EnderecoId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("EmpresaEnderecoFaturamento");
                });

            modelBuilder.Entity("SistemaDeVendas.Models.EmpresaModels.EmpresaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AreaDeAtuacao")
                        .HasColumnType("integer");

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("IE")
                        .HasColumnType("text");

                    b.Property<string>("IM")
                        .HasColumnType("text");

                    b.Property<byte[]>("Logo")
                        .HasColumnType("bytea");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("ParametroDeVendaId")
                        .HasColumnType("integer");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal?>("Telefone")
                        .HasColumnType("numeric");

                    b.Property<int?>("UsuarioModelId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ParametroDeVendaId");

                    b.HasIndex("UsuarioModelId");

                    b.ToTable("empresa", (string)null);
                });

            modelBuilder.Entity("SistemaDeVendas.Models.EmpresaModels.ParametrosdeVendasModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("BloqProducaoEstoqueNegativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<bool>("BloqVendaEstoqueNegativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<bool>("CadastroDeProdutoViaPedidoCompra")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<bool>("CadastroDeProdutoViaPedidoVenda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<bool>("CupomTroca")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<bool>("FechamentoCegoPDV")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<float>("LimiteDeCreditoNovosCliente")
                        .HasColumnType("real");

                    b.Property<float>("LimiteNumerarioCaixa")
                        .HasColumnType("real");

                    b.Property<float>("MaxDescontoPOS")
                        .HasColumnType("real");

                    b.Property<float>("MaxDescontoPedido")
                        .HasColumnType("real");

                    b.Property<bool>("MovimentacaoEstoqViaXML")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<int>("PrasoCupomTroca")
                        .HasColumnType("integer");

                    b.Property<int>("TipoImpressao")
                        .HasColumnType("integer");

                    b.Property<bool>("UtilizarLimiteCredito")
                        .HasColumnType("boolean");

                    b.Property<int>("ValidadeEntregaDeOrcamentoVenda")
                        .HasColumnType("integer");

                    b.Property<int>("ValidadeEntregaDePedidoVenda")
                        .HasColumnType("integer");

                    b.Property<int>("ValidadeEntregaPedidoCompra")
                        .HasColumnType("integer");

                    b.Property<int>("ValidadeEntregaorcamentoCompra")
                        .HasColumnType("integer");

                    b.Property<int>("ValidadeOrcamentoCompra")
                        .HasColumnType("integer");

                    b.Property<int>("ValidadeOrcamentoVenda")
                        .HasColumnType("integer");

                    b.Property<int>("ValorizacaoEstoque")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("ParametrosdeVendas");
                });

            modelBuilder.Entity("SistemaDeVendas.Models.GeralModel.EnderecoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("endereco");
                });

            modelBuilder.Entity("SistemaDeVendas.Models.GeralModels.ContatosModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Telefone")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Contatos");
                });

            modelBuilder.Entity("SistemaDeVendas.Models.GeralModels.DadosBancariosModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Agencia")
                        .HasColumnType("numeric")
                        .HasColumnName("agencia");

                    b.Property<int>("Bancos")
                        .HasColumnType("integer")
                        .HasColumnName("bancos");

                    b.Property<decimal>("Conta")
                        .HasColumnType("numeric")
                        .HasColumnName("conta");

                    b.Property<decimal>("DigitoAgencia")
                        .HasColumnType("numeric")
                        .HasColumnName("digito_agencia");

                    b.Property<decimal>("DigitoConta")
                        .HasColumnType("numeric")
                        .HasColumnName("digito_conta");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("integer");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("dados_bancarios", (string)null);
                });

            modelBuilder.Entity("SistemaDeVendas.Models.Permissoes.GrupoPermissoesModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("EmpresaId")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.Property<string>("PermissoesJson")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("permissoes_json");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("grupo_permissoes", (string)null);
                });

            modelBuilder.Entity("SistemaDeVendas.Models.Permissoes.PermissaoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("PodeAcessar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("pode_acessar");

                    b.Property<bool>("PodeAlterar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("pode_alterar");

                    b.Property<bool>("PodeCriar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("pode_criar");

                    b.Property<bool>("PodeExcluir")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("pode_excluir");

                    b.HasKey("Id");

                    b.ToTable("permissao", (string)null);
                });

            modelBuilder.Entity("SistemaDeVendas.Models.UsuariosModels.DocumentoUsuariosModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("FotoDocumento")
                        .IsRequired()
                        .HasColumnType("bytea")
                        .HasColumnName("foto_documento");

                    b.Property<int>("Tipo")
                        .HasColumnType("integer")
                        .HasColumnName("tipo");

                    b.Property<int?>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("documento_usuarios", (string)null);
                });

            modelBuilder.Entity("SistemaDeVendas.Models.UsuariosModels.UsuarioModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("ADMPDV")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true);

                    b.Property<string>("CNPJ")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("CPF")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("Celular")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<float?>("Comissao")
                        .HasColumnType("real");

                    b.Property<bool>("Comprador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<DateTimeOffset>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateOnly>("DataNascimento")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<int?>("EmpresaId")
                        .HasColumnType("integer");

                    b.Property<int?>("EnderecoId")
                        .HasColumnType("integer");

                    b.Property<byte[]>("Foto")
                        .HasColumnType("bytea");

                    b.Property<int?>("GrupoId")
                        .HasColumnType("integer");

                    b.Property<string>("IE")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Observacao")
                        .HasColumnType("text");

                    b.Property<bool>("OperadorPDV")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("RG")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<int>("Roles")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(2);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<int>("Sexo")
                        .HasColumnType("integer");

                    b.Property<string>("Site")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Telefone")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<int>("TipoPessoa")
                        .HasColumnType("integer");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<bool>("Vendedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("GrupoId");

                    b.ToTable("usuario", (string)null);
                });

            modelBuilder.Entity("EmpresaEnderecoCorrespondencia", b =>
                {
                    b.HasOne("SistemaDeVendas.Models.EmpresaModels.EmpresaModel", null)
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaDeVendas.Models.GeralModel.EnderecoModel", null)
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmpresaEnderecoEntrega", b =>
                {
                    b.HasOne("SistemaDeVendas.Models.EmpresaModels.EmpresaModel", null)
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaDeVendas.Models.GeralModel.EnderecoModel", null)
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmpresaEnderecoFaturamento", b =>
                {
                    b.HasOne("SistemaDeVendas.Models.EmpresaModels.EmpresaModel", null)
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaDeVendas.Models.GeralModel.EnderecoModel", null)
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaDeVendas.Models.EmpresaModels.EmpresaModel", b =>
                {
                    b.HasOne("SistemaDeVendas.Models.EmpresaModels.ParametrosdeVendasModel", "ParametroDeVenda")
                        .WithMany()
                        .HasForeignKey("ParametroDeVendaId");

                    b.HasOne("SistemaDeVendas.Models.UsuariosModels.UsuarioModel", null)
                        .WithMany("Empresas")
                        .HasForeignKey("UsuarioModelId");

                    b.Navigation("ParametroDeVenda");
                });

            modelBuilder.Entity("SistemaDeVendas.Models.GeralModels.DadosBancariosModel", b =>
                {
                    b.HasOne("SistemaDeVendas.Models.EmpresaModels.EmpresaModel", null)
                        .WithMany("DadosBancarios")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaDeVendas.Models.UsuariosModels.UsuarioModel", null)
                        .WithMany("DadosBancarios")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaDeVendas.Models.Permissoes.GrupoPermissoesModel", b =>
                {
                    b.HasOne("SistemaDeVendas.Models.EmpresaModels.EmpresaModel", null)
                        .WithMany("GrupoPermissoes")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaDeVendas.Models.UsuariosModels.DocumentoUsuariosModel", b =>
                {
                    b.HasOne("SistemaDeVendas.Models.UsuariosModels.UsuarioModel", "Usuario")
                        .WithMany("Documentos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("SistemaDeVendas.Models.UsuariosModels.UsuarioModel", b =>
                {
                    b.HasOne("SistemaDeVendas.Models.EmpresaModels.EmpresaModel", "Empresa")
                        .WithMany("Usuarios")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SistemaDeVendas.Models.GeralModel.EnderecoModel", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");

                    b.HasOne("SistemaDeVendas.Models.Permissoes.GrupoPermissoesModel", "Grupo")
                        .WithMany()
                        .HasForeignKey("GrupoId");

                    b.Navigation("Empresa");

                    b.Navigation("Endereco");

                    b.Navigation("Grupo");
                });

            modelBuilder.Entity("SistemaDeVendas.Models.EmpresaModels.EmpresaModel", b =>
                {
                    b.Navigation("DadosBancarios");

                    b.Navigation("GrupoPermissoes");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("SistemaDeVendas.Models.UsuariosModels.UsuarioModel", b =>
                {
                    b.Navigation("DadosBancarios");

                    b.Navigation("Documentos");

                    b.Navigation("Empresas");
                });
#pragma warning restore 612, 618
        }
    }
}
