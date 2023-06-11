using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Models.GeralModels;

namespace SistemaDeVendas.Data.Map
{
    public class ContatosModelMap : IEntityTypeConfiguration<ContatosModel>
    {
        public void Configure(EntityTypeBuilder<ContatosModel> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .IsRequired();

            builder.Property(c => c.Cargo);

            builder.Property(c => c.Telefone);

            builder.Property(c => c.Email);
        }
    }
}
