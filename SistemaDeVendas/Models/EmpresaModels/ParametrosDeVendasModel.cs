using SistemaDeVendas.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.EmpresaModels
{
    public class ParametrosDeVendasModel
    {
        public ParametrosDeVendasModel()
        {
        }

        [Key]
        public int Id { get; set; }
        public int? ValidadeOrcamentoCompra { get; set; }
        public int? ValidadeEntregaPedidoCompra { get; set; }
        public int? ValidadeEntregaorcamentoCompra { get; set; }
        public int? ValidadeOrcamentoVenda { get; set; }
        public int? ValidadeEntregaDePedidoVenda { get; set; }
        public int? ValidadeEntregaDeOrcamentoVenda { get; set; }
        public float? LimiteDeCreditoNovosCliente { get; set; }
        public bool UtilizarLimiteCredito { get; set; }
        public float? MaxDescontoPOS { get; set; }
        public float? MaxDescontoPedido { get; set; }
        [DefaultValue(false)]
        public bool FechamentoCegoPDV { get; set; }
        public float? LimiteNumerarioCaixa { get; set; }
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
        public ValorizacaoEstoque? ValorizacaoEstoque { get; set; }
        public TipoImpressora? TipoImpressao { get; set; }

        public ParametrosDeVendasModel(int id, int? validadeOrcamentoCompra, int? validadeEntregaPedidoCompra, int? validadeEntregaorcamentoCompra, int? validadeOrcamentoVenda, int? validadeEntregaDePedidoVenda, int? validadeEntregaDeOrcamentoVenda, float? limiteDeCreditoNovosCliente, bool utilizarLimiteCredito, float? maxDescontoPOS, float? maxDescontoPedido, bool fechamentoCegoPDV, float? limiteNumerarioCaixa, bool cupomTroca, int prasoCupomTroca, bool bloqVendaEstoqueNegativo, bool bloqProducaoEstoqueNegativo, bool movimentacaoEstoqViaXML, bool cadastroDeProdutoViaPedidoCompra, bool cadastroDeProdutoViaPedidoVenda, ValorizacaoEstoque? valorizacaoEstoque, TipoImpressora? tipoImpressao)
        {
            Id = id;
            ValidadeOrcamentoCompra = validadeOrcamentoCompra;
            ValidadeEntregaPedidoCompra = validadeEntregaPedidoCompra;
            ValidadeEntregaorcamentoCompra = validadeEntregaorcamentoCompra;
            ValidadeOrcamentoVenda = validadeOrcamentoVenda;
            ValidadeEntregaDePedidoVenda = validadeEntregaDePedidoVenda;
            ValidadeEntregaDeOrcamentoVenda = validadeEntregaDeOrcamentoVenda;
            LimiteDeCreditoNovosCliente = limiteDeCreditoNovosCliente;
            UtilizarLimiteCredito = utilizarLimiteCredito;
            MaxDescontoPOS = maxDescontoPOS;
            MaxDescontoPedido = maxDescontoPedido;
            FechamentoCegoPDV = fechamentoCegoPDV;
            LimiteNumerarioCaixa = limiteNumerarioCaixa;
            CupomTroca = cupomTroca;
            PrasoCupomTroca = prasoCupomTroca;
            BloqVendaEstoqueNegativo = bloqVendaEstoqueNegativo;
            BloqProducaoEstoqueNegativo = bloqProducaoEstoqueNegativo;
            MovimentacaoEstoqViaXML = movimentacaoEstoqViaXML;
            CadastroDeProdutoViaPedidoCompra = cadastroDeProdutoViaPedidoCompra;
            CadastroDeProdutoViaPedidoVenda = cadastroDeProdutoViaPedidoVenda;
            ValorizacaoEstoque = valorizacaoEstoque;
            TipoImpressao = tipoImpressao;
        }
    }
}
