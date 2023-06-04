using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels
{
    public class PermissaoRelatorioModel
    {
        [Key]
        public int Id { get; set; }
        public Permissoes NaturezaOperacao { get; set; }
    }
}
