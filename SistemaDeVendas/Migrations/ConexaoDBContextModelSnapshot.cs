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

            modelBuilder.Entity("EmpresaUsuario", b =>
                {
                    b.Property<int>("Usuarios")
                        .HasColumnType("integer");

                    b.Property<int>("Empresas")
                        .HasColumnType("integer");

                    b.HasKey("Usuarios", "Empresas");

                    b.HasIndex("Empresas");

                    b.ToTable("EmpresaUsuario");

                    b.HasData(
                        new
                        {
                            Usuarios = 1,
                            Empresas = 1
                        });
                });

            modelBuilder.Entity("SistemaDeVendas.Models.EmpresaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AreaDeAtuacao")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("AreaDeAtuacao");

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean")
                        .HasColumnName("Ativo");

                    b.Property<decimal>("CNPJ")
                        .HasColumnType("numeric")
                        .HasColumnName("CNPJ");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Email");

                    b.Property<int?>("EnderecoCorrespondenciaId")
                        .IsRequired()
                        .HasColumnType("integer")
                        .HasColumnName("EnderecoCorrespondenciaId");

                    b.Property<int>("EnderecoEntregaId")
                        .HasColumnType("integer")
                        .HasColumnName("EnderecoEntregaId");

                    b.Property<int?>("EnderecoFaturamentoId")
                        .IsRequired()
                        .HasColumnType("integer")
                        .HasColumnName("EnderecoFaturamentoId");

                    b.Property<string>("IE")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("IE");

                    b.Property<string>("IM")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("IM");

                    b.Property<byte[]>("Logo")
                        .IsRequired()
                        .HasColumnType("bytea")
                        .HasColumnName("Logo");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("NomeFantasia");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("RazaoSocial");

                    b.Property<decimal?>("Telefone")
                        .IsRequired()
                        .HasColumnType("numeric")
                        .HasColumnName("Telefone");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoCorrespondenciaId")
                        .IsUnique();

                    b.HasIndex("EnderecoEntregaId")
                        .IsUnique();

                    b.HasIndex("EnderecoFaturamentoId")
                        .IsUnique();

                    b.ToTable("empresa", (string)null);
                });

            modelBuilder.Entity("SistemaDeVendas.Models.EnderecoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("CEP");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Cidade");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("integer");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Estado");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Rua");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("endereco");
                });

            modelBuilder.Entity("SistemaDeVendas.Models.UsuarioModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool?>("ADMPDV")
                        .IsRequired()
                        .HasColumnType("boolean");

                    b.Property<bool?>("Ativo")
                        .HasColumnType("boolean");

                    b.Property<decimal>("CPF")
                        .HasColumnType("numeric");

                    b.Property<float?>("Comissao")
                        .HasColumnType("real");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<byte[]>("Foto")
                        .HasColumnType("bytea");

                    b.Property<string>("Funcao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<bool?>("PDV")
                        .IsRequired()
                        .HasColumnType("boolean");

                    b.Property<int>("Perfil")
                        .HasColumnType("integer");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<decimal?>("Telefone")
                        .HasColumnType("numeric");

                    b.Property<bool?>("Vendedor")
                        .IsRequired()
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("usuario", (string)null);
                });

            modelBuilder.Entity("UsuarioEmpresa", b =>
                {
                    b.Property<int>("Empresas")
                        .HasColumnType("integer");

                    b.Property<int>("Usuarios")
                        .HasColumnType("integer");

                    b.HasKey("Empresas", "Usuarios");

                    b.HasIndex("Usuarios");

                    b.ToTable("UsuarioEmpresa");

                    b.HasData(
                        new
                        {
                            Empresas = 1,
                            Usuarios = 1
                        });
                });

            modelBuilder.Entity("EmpresaUsuario", b =>
                {
                    b.HasOne("SistemaDeVendas.Models.EmpresaModel", null)
                        .WithMany()
                        .HasForeignKey("Empresas")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaDeVendas.Models.UsuarioModel", null)
                        .WithMany()
                        .HasForeignKey("Usuarios")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaDeVendas.Models.EmpresaModel", b =>
                {
                    b.HasOne("SistemaDeVendas.Models.EnderecoModel", "EnderecoCorrespondencia")
                        .WithOne()
                        .HasForeignKey("SistemaDeVendas.Models.EmpresaModel", "EnderecoCorrespondenciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaDeVendas.Models.EnderecoModel", "EnderecoEntrega")
                        .WithOne()
                        .HasForeignKey("SistemaDeVendas.Models.EmpresaModel", "EnderecoEntregaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaDeVendas.Models.EnderecoModel", "EnderecoFaturamento")
                        .WithOne()
                        .HasForeignKey("SistemaDeVendas.Models.EmpresaModel", "EnderecoFaturamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EnderecoCorrespondencia");

                    b.Navigation("EnderecoEntrega");

                    b.Navigation("EnderecoFaturamento");
                });

            modelBuilder.Entity("SistemaDeVendas.Models.EnderecoModel", b =>
                {
                    b.HasOne("SistemaDeVendas.Models.EmpresaModel", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("UsuarioEmpresa", b =>
                {
                    b.HasOne("SistemaDeVendas.Models.EmpresaModel", null)
                        .WithMany()
                        .HasForeignKey("Empresas")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaDeVendas.Models.UsuarioModel", null)
                        .WithMany()
                        .HasForeignKey("Usuarios")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}