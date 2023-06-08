using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.GeralModels
{
    public class ContatosModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public decimal Telefone { get; set; }
        public string Email { get; set; }

        public ContatosModel()
        {
        }
    }
}
