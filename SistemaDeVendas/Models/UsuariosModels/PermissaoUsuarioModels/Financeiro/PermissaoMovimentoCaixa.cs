using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels.Financeiro
{
    public class PermissaoMovimentoCaixa
    {
        [Key]
        public int Id { get; set; }
        public Permissoes MovimentoCaixa { get; set; }
        public Permissoes TransferenciaEntreCaixas { get; set; }
    }
}
