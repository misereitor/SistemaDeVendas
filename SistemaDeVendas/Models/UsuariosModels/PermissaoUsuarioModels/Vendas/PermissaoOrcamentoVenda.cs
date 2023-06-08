using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels.Vendas
{
    public class PermissaoOrcamentoVenda
    {
        [Key]
        public int Id { get; set; }
        public Permissoes Orcamentovenda { get; set; }
        public Permissoes GerarPedido { get; set; }
        public Permissoes Cancelar { get; set; }
        public Permissoes EnviarPorEmail { get; set; }
        public Permissoes Copiar { get; set; }
        public Permissoes VisualizarTodosOrcamentos { get; set; }
        public Permissoes InserirVendedores { get; set; }
        public Permissoes AplicarDesconto { get; set; }

    }
}
