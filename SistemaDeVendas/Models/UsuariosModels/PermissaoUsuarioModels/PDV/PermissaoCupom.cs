using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels.PDV
{
    public class PermissaoCupom
    {
        [Key]
        public int Id { get; set; }
        public Permissoes Cupom { get; set; }
        public Permissoes CancelarCupom { get; set; }
        public Permissoes DevolverCupom { get; set; }
    }
}
