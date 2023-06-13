using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.Permissoes.PermissaoUsuarioModels.Catalogo
{
    public class PermissaoProdutosModel
    {
        [Key]
        public int Id { get; set; }
        public PermissaoModel Produtos { get; set; }
        public PermissaoModel Cor { get; set; }
        public PermissaoModel Tamanho { get; set; }
        public PermissaoModel Custo { get; set; }
    }
}
