using SistemaDeVendas.Enums;
using SistemaDeVendas.Models.EmpresaModels;
using SistemaDeVendas.Models.GeralModels.DadosBancarios;
using SistemaDeVendas.Models.GeralModels.EnderecoModel;
using SistemaDeVendas.Models.Permissoes;
using SistemaDeVendas.Models.UsuariosModels;

namespace SistemaDeVendas.Models.RepositorioModel
{
    public class RetornoUsuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Usuario { get; set; }
        public UsuarioSexo Sexo { get; set; }
        public EnderecoUsuarioModel? Endereco { get; set; }
        public DateOnly DataNascimento { get; set; }
        public DateTimeOffset DataCriacao { get; set; } = DateTimeOffset.UtcNow;
        public string Site { get; set; }
        public string Observacao { get; set; }
        public ICollection<DadosBancariosUsuarioModel> DadosBancarios { get; set; }
        public ICollection<DocumentoUsuariosModel> Documentos { get; set; }
        public ICollection<EmpresaModel> Empresas { get; set; }
        public bool Ativo { get; set; }
        public UsuarioRoles Roles { get; set; }
        public bool OperadorPDV { get; set; }
        public bool ADMPDV { get; set; }
        public bool Vendedor { get; set; }
        public bool Comprador { get; set; }
        public ICollection<GrupoPermissoesModel> Grupo { get; set; }
        public float Comissao { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public TipoPessoa TipoPessoa { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string IE { get; set; }
        public string IM { get; set; }
        public string RG { get; set; }
        public byte[]? Foto { get; set; }

        public RetornoUsuario()
        {
            Grupo = new List<GrupoPermissoesModel>();
            DadosBancarios = new List<DadosBancariosUsuarioModel>();
            Documentos = new List<DocumentoUsuariosModel>();
            Empresas = new List<EmpresaModel>();

            Nome = string.Empty;
            Email = string.Empty;
            Usuario = string.Empty;
            CPF = string.Empty;
            CNPJ = string.Empty;
            IE = string.Empty;
            IM = string.Empty;
            RG = string.Empty;
            Telefone = string.Empty;
            Celular = string.Empty;
            Site = string.Empty;
            Observacao = string.Empty;
        }
    }
}
