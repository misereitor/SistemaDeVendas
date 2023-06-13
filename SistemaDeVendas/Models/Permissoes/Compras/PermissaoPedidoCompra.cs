using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.Permissoes.PermissaoUsuarioModels.Compras
{
    public class PermissaoPedidoCompra
    {
        [Key]
        public int Id { get; set; }
        public PermissaoModel PedidoCompra { get; set; }
        public PermissaoModel Faturar { get; set; }
        public PermissaoModel Cancelar { get; set; }
        public PermissaoModel Receber { get; set; }
        public PermissaoModel Copair { get; set; }
        public PermissaoModel EnviarPorEmail { get; set; }
        public PermissaoModel AplicarDesconto { get; set; }
    }
}
