using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.ProdutoModels.TiposProdutoModel
{
    public class TipoProdutoModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public decimal Codigo { get; set; }
        public TipoProdutoModel()
        {
            Nome = string.Empty;
        }
    }
}
