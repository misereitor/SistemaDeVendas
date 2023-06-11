using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.Permissoes
{
    public class PermissaoModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public bool PodeAcessar { get; set; }
        public bool PodeCriar { get; set; }
        public bool PodeAlterar { get; set; }
        public bool PodeExcluir { get; set; }
        public int GrupoId { get; set; }
        public GrupoPermissaoUsuarios Grupo { get; set; }
    }
}
