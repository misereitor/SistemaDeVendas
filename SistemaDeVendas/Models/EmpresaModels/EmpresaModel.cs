using SistemaDeVendas.Enums;
using SistemaDeVendas.Models.GeralModel;
using SistemaDeVendas.Models.GeralModels;
using SistemaDeVendas.Models.Permissoes;
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
        public ICollection<EnderecoModel> EnderecoEntrega { get; set; }
        public ICollection<EnderecoModel> EnderecoFaturamento { get; set; }
        public ICollection<EnderecoModel> EnderecoCorrespondencia { get; set; }
        public ICollection<UsuarioModel> Usuarios { get; set; }
        public ICollection<DadosBancariosModel> DadosBancarios { get; set; }
        public ParametrosdeVendasModel ParametroDeVenda { get; set; }
        public List<GrupoPermissoesModel> GrupoPermissoes { get; set; }

        public EmpresaModel()
        {
            ParametroDeVenda = new ParametrosdeVendasModel();
            DadosBancarios = new List<DadosBancariosModel>();
            GrupoPermissoes = new List<GrupoPermissoesModel>();
            Usuarios = new List<UsuarioModel>();
            EnderecoEntrega = new List<EnderecoModel>();
            EnderecoFaturamento = new List<EnderecoModel>();
            EnderecoCorrespondencia = new List<EnderecoModel>();

            NomeFantasia = string.Empty;
            RazaoSocial = string.Empty;
            CNPJ = string.Empty;
            Email = string.Empty;
        }
    }
}
