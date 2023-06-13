using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.Permissoes.PermissaoUsuarioModels.Compras
{
    public class PermissaoCompasModel
    {
        [Key]
        public int Id { get; set; }
        public PermissaoModel UPSTORE { get; set; }
        public PermissaoModel CentralCompras { get; set; }
        public PermissaoModel Devolucoes { get; set; }
        public PermissaoOrcamentoCompra OrcamentoCompra { get; set; }
        public PermissaoPedidoCompra PedidoCompra { get; set; }
    }
}
