namespace SistemaDeVendas.Models.ProdutoModels.TiposProdutoModel
{
    public class MarcaProdutoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public MarcaProdutoModel(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
