using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels.Catalogo
{
    public class PermissaoProdutosModel
    {
        [Key]
        public int Id { get; set; }
        public Permissoes Produtos { get; set; }
        public Permissoes Cor { get; set; }
        public Permissoes Tamanho { get; set; }
        public Permissoes Custo { get; set; }
    }
}
