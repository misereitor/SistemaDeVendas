using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeVendas.Models.FornecedorModel
{
    [Table("TipoFornecedor")]
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

    }
}
