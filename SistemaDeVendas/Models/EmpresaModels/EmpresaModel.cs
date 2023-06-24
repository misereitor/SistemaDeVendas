using SistemaDeVendas.Enums;
using SistemaDeVendas.Models.FornecedorModel;
using SistemaDeVendas.Models.GeralModels.DadosBancarios;
using SistemaDeVendas.Models.GeralModels.Endereco;
using SistemaDeVendas.Models.GeralModels.EnderecoModel;
using SistemaDeVendas.Models.Permissoes;
using SistemaDeVendas.Models.ProdutoModels;
using SistemaDeVendas.Models.UsuariosModels;
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
        [Required]
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public byte[]? Logo { get; set; }
        public string CNPJ { get; set; }
        [DefaultValue(false)]
        public bool Ativo { get; set; }
        public AreaAtuacaoEmpresa AreaDeAtuacao { get; set; }
        public string Telefone { get; set; } = string.Empty;
        public string Email { get; set; }
        public string? IE { get; set; }
        public string? IM { get; set; }
        public ICollection<EnderecoEmpresaEntregaModel> EnderecoEntrega { get; set; }
        public ICollection<EnderecoEmpresaFaturamentoModel> EnderecoFaturamento { get; set; }
        public ICollection<EnderecoEmpresaCorrespondenciaModel> EnderecoCorrespondencia { get; set; }
        public ICollection<UsuarioModel> Usuarios { get; set; }
        public ICollection<FornecedoresModel> Fornecedores { get; set; }
        public ICollection<DadosBancariosEmpresaModel> DadosBancarios { get; set; }
        public ParametrosdeVendasModel ParametroDeVenda { get; set; }
        public ICollection<GrupoPermissoesModel> GrupoPermissoes { get; set; }
        public ICollection<ProdutoModel> Produtos { get; set; }

        public EmpresaModel()
        {
            ParametroDeVenda = new ParametrosdeVendasModel();
            DadosBancarios = new List<DadosBancariosEmpresaModel>();
            GrupoPermissoes = new List<GrupoPermissoesModel>();
            Usuarios = new List<UsuarioModel>();
            EnderecoEntrega = new List<EnderecoEmpresaEntregaModel>();
            EnderecoFaturamento = new List<EnderecoEmpresaFaturamentoModel>();
            EnderecoCorrespondencia = new List<EnderecoEmpresaCorrespondenciaModel>();
            Fornecedores = new List<FornecedoresModel>();
            Produtos = new List<ProdutoModel>();

            NomeFantasia = string.Empty;
            RazaoSocial = string.Empty;
            CNPJ = string.Empty;
            Email = string.Empty;
        }
    }
}
