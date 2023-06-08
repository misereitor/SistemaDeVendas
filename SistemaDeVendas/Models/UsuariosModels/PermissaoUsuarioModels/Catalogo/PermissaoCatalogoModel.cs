using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels.Catalogo
{
    public class PermissaoCatalogoModel
    {
        [Key]
        public int Id { get; set; }
        public Permissoes Marcas { get; set; }
        public Permissoes Categorias { get; set; }
        public Permissoes UnidadesMedida { get; set; }
        public Permissoes ImpressaoEtiqueta { get; set; }
        public Permissoes Servico { get; set; }
        public Permissoes Producao { get; set; }
        public Permissoes PaginaOferta { get; set; }
        public Permissoes Combos { get; set; }
        public PermissaoProdutosModel Produtos { get; set; }
        public PermissaoCampanhaDescontoModel CampanhaDesconto { get; set; }
    }
}
