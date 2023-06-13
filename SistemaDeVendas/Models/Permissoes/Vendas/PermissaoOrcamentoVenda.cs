using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.Permissoes.PermissaoUsuarioModels.Vendas
{
    public class PermissaoOrcamentoVenda
    {
        [Key]
        public int Id { get; set; }
        public PermissaoModel Orcamentovenda { get; set; }
        public PermissaoModel GerarPedido { get; set; }
        public PermissaoModel Cancelar { get; set; }
        public PermissaoModel EnviarPorEmail { get; set; }
        public PermissaoModel Copiar { get; set; }
        public PermissaoModel VisualizarTodosOrcamentos { get; set; }
        public PermissaoModel InserirVendedores { get; set; }
        public PermissaoModel AplicarDesconto { get; set; }

    }
}
