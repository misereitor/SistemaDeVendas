using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.Permissoes.PermissaoUsuarioModels.Catalogo
{
    public class PermissaoCatalogoModel
    {
        [Key]
        public int Id { get; set; }
        public PermissaoModel Marcas { get; set; }
        public PermissaoModel Categorias { get; set; }
        public PermissaoModel UnidadesMedida { get; set; }
        public PermissaoModel ImpressaoEtiqueta { get; set; }
        public PermissaoModel Servico { get; set; }
        public PermissaoModel Producao { get; set; }
        public PermissaoModel PaginaOferta { get; set; }
        public PermissaoModel Combos { get; set; }
        public PermissaoProdutosModel Produtos { get; set; }
        public PermissaoCampanhaDescontoModel CampanhaDesconto { get; set; }
    }
}
