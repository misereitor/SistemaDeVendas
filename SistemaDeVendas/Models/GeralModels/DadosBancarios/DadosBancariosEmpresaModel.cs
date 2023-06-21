using SistemaDeVendas.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeVendas.Models.GeralModels.DadosBancarios
{
    [Table("dadosBancariosEmpresa")]
    public class DadosBancariosEmpresaModel
    {
        [Key]
        public int Id { get; set; }
        public Bancos Bancos { get; set; }
        public decimal Agencia { get; set; }
        public decimal DigitoAgencia { get; set; }
        public decimal Conta { get; set; }
        public decimal DigitoConta { get; set; }
    }
}
