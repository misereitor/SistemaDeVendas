using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.Permissoes.PermissaoUsuarioModels.Financeiro
{
    public class PermissaoPagamentos
    {
        [Key]
        public int Id { get; set; }
        public PermissaoModel Pagamentos { get; set; }
        public PermissaoModel IncluirPagamentos { get; set; }
        public PermissaoModel ExcluirPagamentos { get; set; }
    }
}
