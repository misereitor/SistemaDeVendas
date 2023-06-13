using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.Permissoes.PermissaoUsuarioModels.Vendas
{
    public class PermissaoVendasModel
    {
        [Key]
        public int Id { get; set; }
        public PermissaoModel CRM { get; set; }
        public PermissaoModel Devolucoes { get; set; }
        public PermissaoModel LancamentoComissao { get; set; }
        public PermissaoModel AprovacaoComissao { get; set; }
        public PermissaoModel OrgemExpedicao { get; set; }
        public PermissaoModel LojaVirtualCategoria { get; set; }
        public PermissaoModel LojaVirtualDestaque { get; set; }
        public PermissaoModel LojaVirtualBanners { get; set; }
        public PermissaoModel Promocoes { get; set; }
        public PermissaoPedidoVenda PedidoVenda { get; set; }
        public PermissaoOrcamentoVenda OrcamentoVenda { get; set; }

    }
}
