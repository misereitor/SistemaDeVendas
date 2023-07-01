namespace SistemaDeVendas.Models.ProdutoModels.TiposProdutoModel
{
    public class CategoriaProduto
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public CategoriaProduto(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
