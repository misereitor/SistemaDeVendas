using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.GeralModels
{
    public class ContatosModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Caargo { get; set; }
        public decimal Telefone { get; set; }
        public string Email { get; set; }

        public ContatosModel(int id, string nome, string caargo, decimal telefone, string email)
        {
            Id = id;
            Nome = nome;
            Caargo = caargo;
            Telefone = telefone;
            Email = email;
        }

        public ContatosModel()
        {
        }
    }
}
