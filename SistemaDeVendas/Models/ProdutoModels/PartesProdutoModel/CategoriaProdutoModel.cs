namespace SistemaDeVendas.Models.ProdutoModels.PartesProdutoModel
{
    public class CategoriaProdutoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public CategoriaProdutoModel()
        {
            Nome = string.Empty;
        }
    }
}
