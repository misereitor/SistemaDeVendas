using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels.Compras
{
    public class PermissaoPedidoCompra
    {
        [Key]
        public int Id { get; set; }
        public Permissoes PedidoCompra { get; set; }
        public Permissoes Faturar { get; set; }
        public Permissoes Cancelar { get; set; }
        public Permissoes Receber { get; set; }
        public Permissoes Copair { get; set; }
        public Permissoes EnviarPorEmail { get; set; }
        public Permissoes AplicarDesconto { get; set; }
    }
}
