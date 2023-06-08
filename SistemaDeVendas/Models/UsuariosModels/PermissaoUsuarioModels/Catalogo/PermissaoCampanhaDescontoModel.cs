using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels.Catalogo
{
    public class PermissaoCampanhaDescontoModel
    {
        [Key]
        public int Id { get; set; }
        public Permissoes CampanhaDesconto { get; set; }
        public Permissoes CupomDesconto { get; set; }
    }
}
