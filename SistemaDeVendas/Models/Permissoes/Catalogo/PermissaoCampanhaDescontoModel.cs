using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.Permissoes.PermissaoUsuarioModels.Catalogo
{
    public class PermissaoCampanhaDescontoModel
    {
        [Key]
        public int Id { get; set; }
        public PermissaoModel CampanhaDesconto { get; set; }
        public PermissaoModel CupomDesconto { get; set; }
    }
}
