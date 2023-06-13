using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Models.Permissoes;

namespace SistemaDeVendas.Data.Map
{
    public class PermissaoModelMap : IEntityTypeConfiguration<PermissaoModel>
    {
        public void Configure(EntityTypeBuilder<PermissaoModel> builder)
        {
            builder.ToTable("permissao");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("id");

            builder.Property(p => p.PodeAcessar).HasColumnName("pode_acessar").IsRequired().HasDefaultValue(false);
            builder.Property(p => p.PodeCriar).HasColumnName("pode_criar").IsRequired().HasDefaultValue(false);
            builder.Property(p => p.PodeAlterar).HasColumnName("pode_alterar").IsRequired().HasDefaultValue(false);
            builder.Property(p => p.PodeExcluir).HasColumnName("pode_excluir").IsRequired().HasDefaultValue(false);
        }
    }
}