using SistemaDeVendas.Enums;
using SistemaDeVendas.Models.GeralModels.Endereco;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeVendas.Models.FornecedorModel
{
    [Table("fornecedor")]
    public class FornecedoresModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        [Required]
        public UsuarioSexo Sexo { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string ExpedicaoRG { get; set; }
        [DefaultValue(false)]
        public bool ContribuinteIE { get; set; }
        public string CNPJ { get; set; }
        public string IE { get; set; }
        public string IM { get; set; }
        [Required]
        public TipoPessoa TipoPessoa { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }
        public string Observacao { get; set; }
        public EnderecoFornecedor? Endereco { get; set; }
        [DefaultValue(true)]
        public bool Ativo { get; set; }
        [DefaultValue(false)]
        public bool Transportadora { get; set; }
        [DefaultValue(false)]
        public bool ProdutorRutal { get; set; }

        public FornecedoresModel()
        {
            RazaoSocial = string.Empty;
            NomeFantasia = string.Empty;
            RG = string.Empty;
            CPF = string.Empty;
            ExpedicaoRG = string.Empty;
            CNPJ = string.Empty;
            IE = string.Empty;
            IM = string.Empty;
            Telefone = string.Empty;
            Celular = string.Empty;
            Email = string.Empty;
            Site = string.Empty;
            Observacao = string.Empty;
        }

    }
}
