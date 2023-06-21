using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeVendas.Models.GeralModels.ContatosModel
{
    [Table("contatosUsuario")]
    public class ContatosUsuarioModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public decimal Telefone { get; set; }
        public string Email { get; set; }

        public ContatosUsuarioModel(int id, string nome, string cargo, decimal telefone, string email)
        {
            Id = id;
            Nome = nome;
            Cargo = cargo;
            Telefone = telefone;
            Email = email;
        }
    }
}
