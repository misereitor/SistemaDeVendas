using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels.Financeiro
{
    public class PermissaoRecebimentos
    {
        [Key]
        public int Id { get; set; }
        public Permissoes Recebimentos { get; set; }
        public Permissoes IncluirRecebimento { get; set; }
        public Permissoes ExcluirRecebimento { get; set; }
    }
}
