using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.Permissoes.PermissaoUsuarioModels.Financeiro
{
    public class PermissaoRecebimentos
    {
        [Key]
        public int Id { get; set; }
        public PermissaoModel Recebimentos { get; set; }
        public PermissaoModel IncluirRecebimento { get; set; }
        public PermissaoModel ExcluirRecebimento { get; set; }
    }
}
