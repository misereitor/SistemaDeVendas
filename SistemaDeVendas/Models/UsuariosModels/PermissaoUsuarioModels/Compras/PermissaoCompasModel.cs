using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels.Compras
{
    public class PermissaoCompasModel
    {
        [Key]
        public int Id { get; set; }
        public Permissoes UPSTORE { get; set; }
        public Permissoes CentralCompras { get; set; }
        public Permissoes Devolucoes { get; set; }
        public PermissaoOrcamentoCompra OrcamentoCompra { get; set; }
        public PermissaoPedidoCompra PedidoCompra { get; set; }
    }
}
