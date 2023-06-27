using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeVendas.Models.ProdutoModels
{
    [Table("produto")]
    public class ProdutoModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public ProdutoModel() 
        {
            Nome = string.Empty;
        }
    }
}
