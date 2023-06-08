using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels.Relatorios
{
    public class PermissaoRelatorioModel
    {
        [Key]
        public int Id { get; set; }
        public Permissoes PedidoCompraAberto { get; set; }
        public Permissoes PedidoVendaAberto { get; set; }
        public Permissoes ListaAniversariantes { get; set; }
        public Permissoes ListaNewsLetter { get; set; }
        public Permissoes VendasConsignadasPorClientes { get; set; }
        public Permissoes CatalogoDeClientes { get; set; }
        public Permissoes DREGerencialSimplificada { get; set; }
        public Permissoes ContasAPagar { get; set; }
        public Permissoes BoletosEmitidos { get; set; }
        public Permissoes LucratividadePorProduto { get; set; }
        public Permissoes ContasAReceber { get; set; }
        public Permissoes TrasicoesTef { get; set; }
        public Permissoes ProdutosPorClientes { get; set; }
        public Permissoes ListaPrecos { get; set; }
        public Permissoes ComprasRealizadas { get; set; }
        public Permissoes ComprasConsignadas { get; set; }
        public Permissoes CurvaABCItensVendidos { get; set; }
        public Permissoes VendasPorFormaPagamento { get; set; }
        public Permissoes VendasPorPDV { get; set; }
        public Permissoes VendasPorvendedor { get; set; }
        public Permissoes TicketMedioPorVendedor { get; set; }
        public Permissoes ventasTotais { get; set; }
        public Permissoes CurvABCClientes { get; set; }
        public Permissoes ControleEstokeKARDEX { get; set; }
        public Permissoes ControleDeEstoqueKARDEXCurto { get; set; }
        public Permissoes LocalizacaoStatus { get; set; }
        public Permissoes ListaItensEstoqueBaixo { get; set; }
        public Permissoes CurvaABCItensEstoque { get; set; }
        public Permissoes VendaPorPeriodo { get; set; }
        public Permissoes VendasPorDesconto { get; set; }
        public Permissoes RelatrorioDivergenciasEstoque { get; set; }
        public Permissoes VendasConsignadas { get; set; }
        public Permissoes FornecedoresComprasConsignadas { get; set; }
        public Permissoes PerdaseAvarias { get; set; }
        public Permissoes AuditoriaOperacional { get; set; }
    }
}
