namespace SistemaDeVendas.Models.ProdutoModels.PartesProdutoModel
{
    public class MarcaProdutoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public MarcaProdutoModel()
        {
            Nome = string.Empty;
        }
    }
}
