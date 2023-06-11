using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeVendas.Models.EmpresaModels;
using SistemaDeVendas.Models.GeralModel;
using SistemaDeVendas.Models.Permissoes;
using SistemaDeVendas.Models.UsuariosModels;

namespace SistemaDeVendas.Data.Map
{
    public class UsuarioModelMap : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioModel> builder)
        {
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

            builder.Property(u => u.Sexo);

            builder.HasOne(u => u.Endereco);

            builder.Property(u => u.DataNascimento)
                .IsRequired();

            builder.Property(u => u.Site);

            builder.Property(u => u.Observacao);

            builder.HasMany(u => u.DadosBancarios);

            builder.HasMany(u => u.Documentos);

            builder.HasMany(u => u.Empresas)
                .WithMany(e => e.Usuarios);

            builder.Property(u => u.Ativo)
                .HasDefaultValue(true);

            builder.Property(u => u.Master)
                .HasDefaultValue(false);

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

            builder.Property(u => u.TipoPessoa);

            builder.Property(u => u.CPF)
                .HasMaxLength(14);

            builder.Property(u => u.CNPJ)
                .HasMaxLength(18);

            builder.Property(u => u.IE)
                .HasMaxLength(18);

            builder.Property(u => u.RG)
                .HasMaxLength(20);

            builder.Property(u => u.Foto);
        }
    }
}