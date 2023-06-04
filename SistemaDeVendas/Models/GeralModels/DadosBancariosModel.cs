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

        public DadosBancariosModel(int id, Bancos bancos, decimal agencia, decimal digitoAgencia, decimal conta, decimal digitoConta)
        {
            Id = id;
            Bancos = bancos;
            Agencia = agencia;
            DigitoAgencia = digitoAgencia;
            Conta = conta;
            DigitoConta = digitoConta;
        }

        public DadosBancariosModel()
        {
        }
    }
}
