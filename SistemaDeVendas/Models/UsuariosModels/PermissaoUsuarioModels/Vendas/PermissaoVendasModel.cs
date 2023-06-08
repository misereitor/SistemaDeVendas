using SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels.Catalogo;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels.Vendas
{
    public class PermissaoVendasModel
    {
        [Key]
        public int Id { get; set; }
        public Permissoes CRM { get; set; }
        public Permissoes Devolucoes { get; set; }
        public Permissoes LancamentoComissao { get; set; }
        public Permissoes AprovacaoComissao { get; set; }
        public Permissoes OrgemExpedicao { get; set; }
        public Permissoes LojaVirtualCategoria { get; set; }
        public Permissoes LojaVirtualDestaque { get; set; }
        public Permissoes LojaVirtualBanners { get; set; }
        public Permissoes Promocoes { get; set; }
        public PermissaoPedidoVenda PedidoVenda { get; set; }
        public PermissaoOrcamentoVenda OrcamentoVenda { get; set; }

    }
}
