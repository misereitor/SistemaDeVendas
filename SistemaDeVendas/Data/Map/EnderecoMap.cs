using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeVendas.Models;

namespace SistemaDeVendas.Data.Map
{
    public class EnderecoMap : IEntityTypeConfiguration<EnderecoModel>
    {
        public void Configure(EntityTypeBuilder<EnderecoModel> builder)
        {
            builder.Property(e => e.Id).HasColumnName("Id").IsRequired();
            builder.Property(e => e.Rua).HasColumnName("Rua").IsRequired();
            builder.Property(e => e.Cidade).HasColumnName("Cidade").IsRequired();
            builder.Property(e => e.Estado).HasColumnName("Estado").IsRequired();
            builder.Property(e => e.CEP).HasColumnName("CEP").IsRequired();
        }
    }
}
