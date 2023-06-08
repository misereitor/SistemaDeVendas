using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels.Pessoas
{
    public class PermissaoClientes
    {
        [Key]
        public int Id { get; set; }
        public Permissoes Clientes { get; set; }
        public Permissoes Enderecos { get; set; }
        public Permissoes Contatos { get; set; }
        public Permissoes ControleCredito { get; set; }
        public Permissoes ParcelaAtraso { get; set; }
        public Permissoes ParcelaPagas { get; set; }
        public Permissoes ParcelaAPagar { get; set; }
    }
}
