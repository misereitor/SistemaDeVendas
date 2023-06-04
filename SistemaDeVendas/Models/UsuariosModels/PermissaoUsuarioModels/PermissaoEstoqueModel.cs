using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels
{
    public class PermissaoEstoqueModel
    {
        [Key]
        public int Id { get; set; }
        public Permissoes LocaisEstoque { get; set; }
        public Permissoes IventariarEstoque { get; set; }
        public Permissoes ConsultarEstoque { get; set; }
        public Permissoes MovimentarEstoque { get; set; }
        public Permissoes Motivo { get; set; }
        public Permissoes TipoEstocagem { get; set; }
        public Permissoes TransferenciaInternas { get; set; }
        public Permissoes ItensPendentesEntrega { get; set; }
    }
}
