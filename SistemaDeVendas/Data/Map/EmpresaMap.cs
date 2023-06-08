using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeVendas.Models.EmpresaModels;
using SistemaDeVendas.Models.UsuariosModels;

namespace SistemaDeVendas.Data.Map
{
    public class EmpresaMap : IEntityTypeConfiguration<EmpresaModel>
    {
        public void Configure(EntityTypeBuilder<EmpresaModel> builder)
        {
            builder.ToTable("empresa");

            builder.HasKey(e => e.Id);

            // Relacionamento 1:N entre EmpresaModel e EnderecoModel para os diferentes tipos de endereço
            builder.HasMany(e => e.EnderecoEntrega)
                .WithOne()
                .HasForeignKey("EmpresaModel_EnderecoEntregaId")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(e => e.EnderecoFaturamento)
                .WithOne()
                .HasForeignKey("EmpresaModel_EnderecoFaturamentoId")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(e => e.EnderecoCorrespondencia)
                .WithOne()
                .HasForeignKey("EmpresaModel_EnderecoCorrespondenciaId")
                .OnDelete(DeleteBehavior.Cascade);

            // Relacionamento N:N entre EmpresaModel e UsuarioModel
            builder.HasMany(e => e.Usuarios)
                .WithMany(u => u.Empresas)
                .UsingEntity(j => j.ToTable("EmpresaUsuario"));

            builder.HasOne(e => e.ParametroDeVenda)
                .WithOne()
                .HasForeignKey<ParametrosdeVendasModel>(p => p.Id)
                .OnDelete(DeleteBehavior.Cascade);

            // Configurações das colunas
            builder.Property(e => e.NomeFantasia).IsRequired();
            builder.Property(e => e.RazaoSocial).IsRequired();
            builder.Property(e => e.Logo);
            builder.Property(e => e.CNPJ).IsRequired();
            builder.Property(e => e.Ativo).HasDefaultValue(false);
            builder.Property(e => e.AreaDeAtuacao);
            builder.Property(e => e.Telefone);
            builder.Property(e => e.Email);
            builder.Property(e => e.IE);
            builder.Property(e => e.IM);

            // Índice para o CNPJ
            builder.HasIndex(e => e.CNPJ).IsUnique();
        }
    }
}