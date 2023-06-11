using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeVendas.Models.GeralModel;

namespace SistemaDeVendas.Data.Map
{
    public class EnderecoModelMap : IEntityTypeConfiguration<EnderecoModel>
    {
        public void Configure(EntityTypeBuilder<EnderecoModel> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Rua);

            builder.Property(e => e.Cidade);

            builder.Property(e => e.Estado);

            builder.Property(e => e.CEP);
        }
    }
}
