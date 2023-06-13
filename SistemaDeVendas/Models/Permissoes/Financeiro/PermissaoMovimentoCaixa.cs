using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.Permissoes.PermissaoUsuarioModels.Financeiro
{
    public class PermissaoMovimentoCaixa
    {
        [Key]
        public int Id { get; set; }
        public PermissaoModel MovimentoCaixa { get; set; }
        public PermissaoModel TransferenciaEntreCaixas { get; set; }
    }
}
