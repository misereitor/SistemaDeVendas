using SistemaDeVendas.Enums;
using SistemaDeVendas.Models.GeralModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeVendas.Models.EmpresaModels
{
    [Table("empresa")]
    public class EmpresaModel
    {

        [Key]
        public int Id { get; set; }
        public string NomeFantasia { get; set; }
        public string? RazaoSocial { get; set; }
        public byte[]? Logo { get; set; }
        public decimal CNPJ { get; set; }
        [DefaultValue(false)]
        public bool Ativo { get; set; }
        public AreaAtuacaoEmpresa AreaDeAtuacao { get; set; }
        public decimal? Telefone { get; set; }
        public string Email { get; set; }
        public string? IE { get; set; }
        public string? IM { get; set; }
        public EnderecoModel? EnderecoEntrega { get; set; }
        public EnderecoModel? EnderecoFaturamento { get; set; }
        public EnderecoModel? EnderecoCorrespondencia { get; set; }
        public ParametrosDeVendasModel? ParametroDeVenda { get; set; }

        public EmpresaModel()
        {
        }
    }
}
