using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeVendas.Models.Permissoes
{
    [Table("Permissao")]
    public class PermissaoModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool PodeAcessar { get; set; }
        [DefaultValue(false)]
        public bool PodeCriar { get; set; }
        [DefaultValue(false)]
        public bool PodeAlterar { get; set; }
        [DefaultValue(false)]
        public bool PodeExcluir { get; set; }
    }
}
