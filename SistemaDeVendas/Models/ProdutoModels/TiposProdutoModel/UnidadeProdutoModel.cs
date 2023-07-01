using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.ProdutoModels.TiposProdutoModel
{
    public class UnidadeProdutoModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }

        public UnidadeProdutoModel (int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
