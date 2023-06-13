using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.Permissoes.PermissaoUsuarioModels.Estoque
{
    public class PermissaoLocaisEstoque
    {
        [Key]
        public int Id { get; set; }
        public PermissaoModel LocaisEstoque { get; set; }
        public PermissaoModel InventariarEstoque { get; set; }
    }
}
