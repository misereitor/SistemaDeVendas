using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.ProdutoModels.PartesProdutoModel
{
    public class UnidadeProdutoModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }

        public UnidadeProdutoModel ()
        {
            Nome = string.Empty;
        }
    }
}
