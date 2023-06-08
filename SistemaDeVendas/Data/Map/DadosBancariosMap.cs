using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Models.GeralModels;

namespace SistemaDeVendas.Data.Map
{
    public class DadosBancariosMap : IEntityTypeConfiguration<DadosBancariosModel>
    {
        public void Configure(EntityTypeBuilder<DadosBancariosModel> builder)
        {
            builder.ToTable("dados_bancarios");

            builder.HasKey(d => d.Id);
            builder.Property(d => d.Id).HasColumnName("id").IsRequired();
            builder.Property(d => d.Bancos).HasColumnName("bancos").IsRequired();
            builder.Property(d => d.Agencia).HasColumnName("agencia").IsRequired();
            builder.Property(d => d.DigitoAgencia).HasColumnName("digito_agencia").IsRequired();
            builder.Property(d => d.Conta).HasColumnName("conta").IsRequired();
            builder.Property(d => d.DigitoConta).HasColumnName("digito_conta").IsRequired();
        }
    }
}
