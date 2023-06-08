using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels.Estoque
{
    public class PermissaoLocaisEstoque
    {
        [Key]
        public int Id { get; set; }
        public Permissoes LocaisEstoque { get; set; }
        public Permissoes InventariarEstoque { get; set; }
    }
}
