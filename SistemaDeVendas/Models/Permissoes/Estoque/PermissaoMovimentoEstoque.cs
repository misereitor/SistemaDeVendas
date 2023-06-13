using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.Permissoes.PermissaoUsuarioModels.Estoque
{
    public class PermissaoMovimentoEstoque
    {
        [Key]
        public int Id { get; set; }
        public PermissaoModel MovimentoEstoque { get; set; }
        public PermissaoModel ItemMovimentoEstoque { get; set; }
        public PermissaoModel Entrada { get; set; }
        public PermissaoModel Saida { get; set; }
        public PermissaoModel Transferencia { get; set; }
    }
}
