using SistemaDeVendas.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeVendas.Models.EmpresaModels
{
    [Table("ParametrosdeVendas")]
    public class ParametrosdeVendasModel
    {
        [Key]
        public int Id { get; set; }
        public int ValidadeOrcamentoCompra { get; set; }
        public int ValidadeEntregaPedidoCompra { get; set; }
        public int ValidadeEntregaorcamentoCompra { get; set; }
        public int ValidadeOrcamentoVenda { get; set; }
        public int ValidadeEntregaDePedidoVenda { get; set; }
        public int ValidadeEntregaDeOrcamentoVenda { get; set; }
        public float LimiteDeCreditoNovosCliente { get; set; }
        public bool UtilizarLimiteCredito { get; set; }
        public float MaxDescontoPOS { get; set; }
        public float MaxDescontoPedido { get; set; }
        [DefaultValue(false)]
        public bool FechamentoCegoPDV { get; set; }
        public float LimiteNumerarioCaixa { get; set; }
        [DefaultValue(false)]
        public bool CupomTroca { get; set; }
        public int PrasoCupomTroca { get; set; }
        [DefaultValue(false)]
        public bool BloqVendaEstoqueNegativo { get; set; }
        [DefaultValue(false)]
        public bool BloqProducaoEstoqueNegativo { get; set; }
        [DefaultValue(false)]
        public bool MovimentacaoEstoqViaXML { get; set; }
        [DefaultValue(false)]
        public bool CadastroDeProdutoViaPedidoCompra { get; set; }
        [DefaultValue(false)]
        public bool CadastroDeProdutoViaPedidoVenda { get; set; }
        public ValorizacaoEstoque ValorizacaoEstoque { get; set; }
        public TipoImpressora TipoImpressao { get; set; }
    }
}
