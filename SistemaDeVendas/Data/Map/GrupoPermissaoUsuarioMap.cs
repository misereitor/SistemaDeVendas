using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Models.Permissoes;

namespace SistemaDeVendas.Data.Map
{
    public class GrupoPermissaoUsuarioMap : IEntityTypeConfiguration<GrupoPermissaoUsuarios>
    {
        public void Configure(EntityTypeBuilder<GrupoPermissaoUsuarios> builder)
        {
            builder.HasKey(g => g.Id);

            builder.Property(g => g.Nome)
                .IsRequired();

            builder.HasMany(g => g.Permissoes)
                .WithOne(p => p.Grupo);
        }
    }
}
