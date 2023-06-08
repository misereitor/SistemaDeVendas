using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels.Estoque
{
    public class PermissaoMovimentoEstoque
    {
        [Key]
        public int Id { get; set; }
        public Permissoes MovimentoEstoque { get; set; }
        public Permissoes ItemMovimentoEstoque { get; set; }
        public Permissoes Entrada { get; set; }
        public Permissoes Saida { get; set; }
        public Permissoes Transferencia { get; set; }
    }
}
