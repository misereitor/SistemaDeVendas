using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels.Vendas
{
    public class PermissaoPedidoVenda
    {
        [Key]
        public int Id { get; set; }
        public Permissoes PrdidoVenda { get; set; }
        public Permissoes FaturarPedido { get; set; }
        public Permissoes EntregarPedido { get; set; }
        public Permissoes Cancelar { get; set; }
        public Permissoes Devolver { get; set; }
        public Permissoes RnviarPorEmail { get; set; }
        public Permissoes Copiar { get; set; }
        public Permissoes VisualizarTodosPedidos { get; set; }
        public Permissoes InserirVendedores { get; set; }
        public Permissoes AplicarDesconto { get; set; }
    }
}
