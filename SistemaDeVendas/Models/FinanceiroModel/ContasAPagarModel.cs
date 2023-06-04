using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.FinanceiroModel
{
    public class ContasAPagarModel
    {
        [Key]
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        [Required]
        public DateTime DataVencimento { get; set; }
        [Required]
        public DateTime DatCriacao { get; set; }
        [DefaultValue(false)]
        public bool Pago { get; set; }

        public ContasAPagarModel(int id, decimal valor, string descricao, DateTime dataVencimento, DateTime datCriacao, bool pago)
        {
            Id = id;
            Valor = valor;
            Descricao = descricao;
            DataVencimento = dataVencimento;
            DatCriacao = datCriacao;
            Pago = pago;
        }

        public ContasAPagarModel()
        {
        }
    }
}
