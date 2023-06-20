using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeVendas.Enums;
using SistemaDeVendas.Models.EmpresaModels;
using SistemaDeVendas.Models.GeralModel;
using SistemaDeVendas.Models.GeralModels;
using SistemaDeVendas.Models.Permissoes;
using SistemaDeVendas.Models.UsuariosModels;
using System.Globalization;

namespace SistemaDeVendas.Data.Map
{
    public class UsuarioModelMap : IEntityTypeConfiguration<UsuarioModel>
    {

        public void Configure(EntityTypeBuilder<UsuarioModel> builder)
        {
            builder.ToTable("usuario");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(u => u.Usuario)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(u => u.Sexo)
                .IsRequired();

            builder.Property(u => u.DataNascimento)
                .HasColumnType("date")
                .IsRequired();

            builder.Property(u => u.DataCriacao)
                .HasColumnType("timestamp with time zone")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(u => u.Site)
                .HasMaxLength(255);

            builder.Property(u => u.Observacao);

            builder.Property(u => u.Ativo)
                .HasDefaultValue(true);

            builder.Property(u => u.Roles)
                .HasDefaultValue(UsuarioRoles.Usuario);

            builder.Property(u => u.OperadorPDV)
                .HasDefaultValue(false);

            builder.Property(u => u.ADMPDV)
                .HasDefaultValue(false);

            builder.Property(u => u.Vendedor)
                .HasDefaultValue(false);

            builder.Property(u => u.Comprador)
                .HasDefaultValue(false);

            builder.Property(u => u.Comissao);

            builder.Property(u => u.Telefone)
                .HasMaxLength(20);

            builder.Property(u => u.Celular)
                .HasMaxLength(20);

            builder.Property(u => u.TipoPessoa)
                .IsRequired();

            builder.Property(u => u.CPF)
                .HasMaxLength(20);

            builder.Property(u => u.CNPJ)
                .HasMaxLength(20);

            builder.Property(u => u.IE)
                .HasMaxLength(20);

            builder.Property(u => u.RG)
                .HasMaxLength(20);

            builder.Property(u => u.Foto);

            builder.HasOne(u => u.Endereco).WithMany().HasForeignKey(u => u.EnderecoId);
            builder.HasMany(u => u.DadosBancarios).WithOne().HasForeignKey("UsuarioId").IsRequired().OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(u => u.Documentos).WithOne().HasForeignKey(d => d.UsuarioId);
            builder.HasOne(u => u.Empresa)
                .WithMany(e => e.Usuarios)
                .HasForeignKey(u => u.EmpresaId);

            builder.HasOne(u => u.Grupo).WithMany().HasForeignKey(u => u.GrupoId);
            builder.HasKey(u => u.Id);
        }
        
    }
}