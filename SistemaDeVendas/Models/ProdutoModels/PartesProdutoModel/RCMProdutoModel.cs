using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.ProdutoModels.PartesProdutoModel
{
    public class RCMProdutoModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public decimal Codigo { get; set;}
        public RCMProdutoModel() 
        {
            Nome = string.Empty;
        }
    }
}
