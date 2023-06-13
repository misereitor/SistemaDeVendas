using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Models.UsuariosModels;

namespace SistemaDeVendas.Data.Map
{
    public class DocumentoUsuarioModelMap : IEntityTypeConfiguration<DocumentoUsuariosModel>
    {
        public void Configure(EntityTypeBuilder<DocumentoUsuariosModel> builder)
        {
            builder.ToTable("documento_usuarios");

            builder.HasKey(d => d.Id);
            builder.Property(d => d.Id).HasColumnName("id");

            builder.Property(d => d.Tipo).HasColumnName("tipo").IsRequired();
            builder.Property(d => d.FotoDocumento).HasColumnName("foto_documento").IsRequired();

            builder.HasOne(d => d.Usuario).WithMany(u => u.Documentos).HasForeignKey(d => d.UsuarioId);
        }
    }
}
