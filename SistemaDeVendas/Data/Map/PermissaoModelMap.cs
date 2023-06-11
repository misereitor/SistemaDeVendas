using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Models.Permissoes;

namespace SistemaDeVendas.Data.Map
{
    public class PermissaoModelMap : IEntityTypeConfiguration<PermissaoModel>
    {
        public void Configure(EntityTypeBuilder<PermissaoModel> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired();

            builder.Property(p => p.PodeAcessar);

            builder.Property(p => p.PodeCriar);

            builder.Property(p => p.PodeAlterar);

            builder.Property(p => p.PodeExcluir);

            builder.Property(p => p.GrupoId);

            builder.HasOne(p => p.Grupo)
                .WithMany(g => g.Permissoes);
        }
    }
}