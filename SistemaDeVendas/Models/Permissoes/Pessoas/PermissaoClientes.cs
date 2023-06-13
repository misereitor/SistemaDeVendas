using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.Permissoes.PermissaoUsuarioModels.Pessoas
{
    public class PermissaoClientes
    {
        [Key]
        public int Id { get; set; }
        public PermissaoModel Clientes { get; set; }
        public PermissaoModel Enderecos { get; set; }
        public PermissaoModel Contatos { get; set; }
        public PermissaoModel ControleCredito { get; set; }
        public PermissaoModel ParcelaAtraso { get; set; }
        public PermissaoModel ParcelaPagas { get; set; }
        public PermissaoModel ParcelaAPagar { get; set; }
    }
}
