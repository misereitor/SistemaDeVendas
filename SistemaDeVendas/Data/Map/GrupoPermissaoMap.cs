using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Models.Permissoes;

namespace SistemaDeVendas.Data.Map
{
    public class GrupoPermissaoMap : IEntityTypeConfiguration<GrupoPermissoesModel>
    {
        public void Configure(EntityTypeBuilder<GrupoPermissoesModel> builder)
        {
            builder.ToTable("grupo_permissoes");

            builder.HasKey(g => g.Id);
            builder.Property(g => g.Id).HasColumnName("id");

            builder.Property(g => g.Nome).HasColumnName("nome").IsRequired();

            builder.Property(g => g.PermissoesJson).HasColumnName("permissoes_json");

            builder.Ignore(g => g.Permissoes);
        }
    }
}
