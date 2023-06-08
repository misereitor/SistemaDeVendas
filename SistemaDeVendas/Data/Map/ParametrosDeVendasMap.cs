using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeVendas.Models.EmpresaModels;

namespace SistemaDeVendas.Data.Map
{
    public class ParametrosDeVendasModelMap : IEntityTypeConfiguration<ParametrosdeVendasModel>
    {
        public void Configure(EntityTypeBuilder<ParametrosdeVendasModel> builder)
        {
            builder.ToTable("parametrosdevendas");

            builder.HasKey(p => p.Id);

            // Configurações das colunas
            builder.Property(p => p.ValidadeOrcamentoCompra);
            builder.Property(p => p.ValidadeEntregaPedidoCompra);
            builder.Property(p => p.ValidadeEntregaorcamentoCompra);
            builder.Property(p => p.ValidadeOrcamentoVenda);
            builder.Property(p => p.ValidadeEntregaDePedidoVenda);
            builder.Property(p => p.ValidadeEntregaDeOrcamentoVenda);
            builder.Property(p => p.LimiteDeCreditoNovosCliente);
            builder.Property(p => p.UtilizarLimiteCredito);
            builder.Property(p => p.MaxDescontoPOS);
            builder.Property(p => p.MaxDescontoPedido);
            builder.Property(p => p.FechamentoCegoPDV).HasDefaultValue(false);
            builder.Property(p => p.LimiteNumerarioCaixa);
            builder.Property(p => p.CupomTroca).HasDefaultValue(false);
            builder.Property(p => p.PrasoCupomTroca);
            builder.Property(p => p.BloqVendaEstoqueNegativo).HasDefaultValue(false);
            builder.Property(p => p.BloqProducaoEstoqueNegativo).HasDefaultValue(false);
            builder.Property(p => p.MovimentacaoEstoqViaXML).HasDefaultValue(false);
            builder.Property(p => p.CadastroDeProdutoViaPedidoCompra).HasDefaultValue(false);
            builder.Property(p => p.CadastroDeProdutoViaPedidoVenda).HasDefaultValue(false);
            builder.Property(p => p.ValorizacaoEstoque);
            builder.Property(p => p.TipoImpressao);
        }
    }
}
