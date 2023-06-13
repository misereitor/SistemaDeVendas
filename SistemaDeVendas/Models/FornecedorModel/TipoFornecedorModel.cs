using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.FornecedorModel
{
    public class TipoFornecedorModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Tipo { get; set; }

        public TipoFornecedorModel(int id, string tipo)
        {
            Id = id;
            Tipo = tipo;
        }

        public TipoFornecedorModel()
        {
        }
    }
}
