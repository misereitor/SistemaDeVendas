using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.Permissoes.PermissaoUsuarioModels.PDV
{
    public class PermissaoCupom
    {
        [Key]
        public int Id { get; set; }
        public PermissaoModel Cupom { get; set; }
        public PermissaoModel CancelarCupom { get; set; }
        public PermissaoModel DevolverCupom { get; set; }
    }
}
