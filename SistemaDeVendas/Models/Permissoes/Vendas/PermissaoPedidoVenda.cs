using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.Permissoes.PermissaoUsuarioModels.Vendas
{
    public class PermissaoPedidoVenda
    {
        [Key]
        public int Id { get; set; }
        public PermissaoModel PrdidoVenda { get; set; }
        public PermissaoModel FaturarPedido { get; set; }
        public PermissaoModel EntregarPedido { get; set; }
        public PermissaoModel Cancelar { get; set; }
        public PermissaoModel Devolver { get; set; }
        public PermissaoModel RnviarPorEmail { get; set; }
        public PermissaoModel Copiar { get; set; }
        public PermissaoModel VisualizarTodosPedidos { get; set; }
        public PermissaoModel InserirVendedores { get; set; }
        public PermissaoModel AplicarDesconto { get; set; }
    }
}
