using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.Permissoes
{
    public class GrupoPermissaoUsuarios
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public List<PermissaoModel> Permissoes { get; set; }
    }
}
