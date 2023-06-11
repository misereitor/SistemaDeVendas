using SistemaDeVendas.Enums;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.GeralModels
{
    public class DadosBancariosModel
    {
        [Key]
        public int Id { get; set; }
        public Bancos Bancos { get; set; }
        public decimal Agencia { get; set; }
        public decimal DigitoAgencia { get; set; }
        public decimal Conta { get; set; }
        public decimal DigitoConta { get; set; }

        public DadosBancariosModel()
        {
        }
    }
}
