using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.ProdutoModels.TiposProdutoModel
{
    public class FinalidadeProdutoModel
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public FinalidadeProdutoModel() 
        { 
            Nome = string.Empty;
        }
    }
}
