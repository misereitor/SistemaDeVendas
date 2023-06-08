using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels.Financeiro
{
    public class PermissaoPagamentos
    {
        [Key]
        public int Id { get; set; }
        public Permissoes Pagamentos { get; set; }
        public Permissoes IncluirPagamentos { get; set; }
        public Permissoes ExcluirPagamentos { get; set; }
    }
}
