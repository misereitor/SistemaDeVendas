using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.Permissoes.PermissaoUsuarioModels.Relatorios
{
    public class PermissaoRelatorioModel
    {
        [Key]
        public int Id { get; set; }
        public PermissaoModel PedidoCompraAberto { get; set; }
        public PermissaoModel PedidoVendaAberto { get; set; }
        public PermissaoModel ListaAniversariantes { get; set; }
        public PermissaoModel ListaNewsLetter { get; set; }
        public PermissaoModel VendasConsignadasPorClientes { get; set; }
        public PermissaoModel CatalogoDeClientes { get; set; }
        public PermissaoModel DREGerencialSimplificada { get; set; }
        public PermissaoModel ContasAPagar { get; set; }
        public PermissaoModel BoletosEmitidos { get; set; }
        public PermissaoModel LucratividadePorProduto { get; set; }
        public PermissaoModel ContasAReceber { get; set; }
        public PermissaoModel TrasicoesTef { get; set; }
        public PermissaoModel ProdutosPorClientes { get; set; }
        public PermissaoModel ListaPrecos { get; set; }
        public PermissaoModel ComprasRealizadas { get; set; }
        public PermissaoModel ComprasConsignadas { get; set; }
        public PermissaoModel CurvaABCItensVendidos { get; set; }
        public PermissaoModel VendasPorFormaPagamento { get; set; }
        public PermissaoModel VendasPorPDV { get; set; }
        public PermissaoModel VendasPorvendedor { get; set; }
        public PermissaoModel TicketMedioPorVendedor { get; set; }
        public PermissaoModel ventasTotais { get; set; }
        public PermissaoModel CurvABCClientes { get; set; }
        public PermissaoModel ControleEstokeKARDEX { get; set; }
        public PermissaoModel ControleDeEstoqueKARDEXCurto { get; set; }
        public PermissaoModel LocalizacaoStatus { get; set; }
        public PermissaoModel ListaItensEstoqueBaixo { get; set; }
        public PermissaoModel CurvaABCItensEstoque { get; set; }
        public PermissaoModel VendaPorPeriodo { get; set; }
        public PermissaoModel VendasPorDesconto { get; set; }
        public PermissaoModel RelatrorioDivergenciasEstoque { get; set; }
        public PermissaoModel VendasConsignadas { get; set; }
        public PermissaoModel FornecedoresComprasConsignadas { get; set; }
        public PermissaoModel PerdaseAvarias { get; set; }
        public PermissaoModel AuditoriaOperacional { get; set; }
    }
}
