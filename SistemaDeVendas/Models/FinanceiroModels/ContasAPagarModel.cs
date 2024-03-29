﻿using SistemaDeVendas.Models.FornecedorModels;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeVendas.Models.FinanceiroModel
{
    [Table("ContasAPagar")]
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
        public FornecedorModel Fornecedor { get; set; }

        public ContasAPagarModel()
        {
            Fornecedor = new FornecedorModel();
            Descricao = string.Empty;
        }
    }
}
