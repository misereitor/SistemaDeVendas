using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Models.UsuariosModels;

namespace SistemaDeVendas.Data.Map
{
    public class DocumentoUsuarioModelMap : IEntityTypeConfiguration<DocumentoUsuariosModel>
    {
        public void Configure(EntityTypeBuilder<DocumentoUsuariosModel> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(d => d.Tipo)
                .IsRequired();

            builder.Property(d => d.FotoDocumento);

            builder.Property(d => d.UsuarioId);
        }
    }
}
