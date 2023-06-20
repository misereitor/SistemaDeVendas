using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeVendas.Models.EmpresaModels;
using SistemaDeVendas.Models.GeralModel;
using SistemaDeVendas.Models.UsuariosModels;

namespace SistemaDeVendas.Data.Map
{
    public class EmpresaModelMap : IEntityTypeConfiguration<EmpresaModel>
    {
        public void Configure(EntityTypeBuilder<EmpresaModel> builder)
        {
            builder.ToTable("empresa");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.NomeFantasia);

            builder.Property(e => e.RazaoSocial);

            builder.Property(e => e.Logo);

            builder.Property(e => e.CNPJ);

            builder.Property(e => e.Ativo)
                .HasDefaultValue(false);

            builder.Property(e => e.AreaDeAtuacao)
                .IsRequired();

            builder.Property(e => e.Telefone);

            builder.Property(e => e.Email);

            builder.Property(e => e.IE);

            builder.Property(e => e.IM);

            builder.HasMany(e => e.DadosBancarios).WithOne().HasForeignKey("EmpresaId").IsRequired().OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(e => e.EnderecoEntrega)
                .WithMany()
                .UsingEntity<Dictionary<string, object>>(
                    "EmpresaEnderecoEntrega",
                    e => e.HasOne<EnderecoModel>().WithMany().HasForeignKey("EnderecoId"),
                    e => e.HasOne<EmpresaModel>().WithMany().HasForeignKey("EmpresaId")
                );

            builder.HasMany(e => e.EnderecoFaturamento)
                .WithMany()
                .UsingEntity<Dictionary<string, object>>(
                    "EmpresaEnderecoFaturamento",
                    e => e.HasOne<EnderecoModel>().WithMany().HasForeignKey("EnderecoId"),
                    e => e.HasOne<EmpresaModel>().WithMany().HasForeignKey("EmpresaId")
                );

            builder.HasMany(e => e.EnderecoCorrespondencia)
                .WithMany()
                .UsingEntity<Dictionary<string, object>>(
                    "EmpresaEnderecoCorrespondencia",
                    e => e.HasOne<EnderecoModel>().WithMany().HasForeignKey("EnderecoId"),
                    e => e.HasOne<EmpresaModel>().WithMany().HasForeignKey("EmpresaId")
                );
            builder.HasMany(e => e.GrupoPermissoes)
                .WithOne()
                .HasForeignKey(g => g.EmpresaId);

            builder.HasMany(e => e.Usuarios)
                .WithOne()
                .HasForeignKey(u => u.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.ParametroDeVenda);
        }
    }
}
