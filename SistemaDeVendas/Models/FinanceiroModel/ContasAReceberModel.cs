using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeVendas.Models.GeralModels
{
    [Table("contasAReceber")]
    public class ContasAReceberModel
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

        public ContasAReceberModel(int id, decimal valor, string descricao, DateTime dataVencimento, DateTime datCriacao, bool pago)
        {
            Id = id;
            Valor = valor;
            Descricao = descricao;
            DataVencimento = dataVencimento;
            DatCriacao = datCriacao;
            Pago = pago;
        }
    }
}
