using SistemaDeVendas.Enums;
using SistemaDeVendas.Models.EmpresaModels;
using SistemaDeVendas.Models.GeralModels.DadosBancarios;
using SistemaDeVendas.Models.GeralModels.EnderecoModel;
using SistemaDeVendas.Models.Permissoes;
using SistemaDeVendas.Models.UsuariosModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SistemaDeVendas.Models.RepositorioModel
{
    public class AlteradorUsuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public UsuarioSexo Sexo { get; set; }
        public EnderecoUsuarioModel? Endereco { get; set; }
        public DateOnly DataNascimento { get; set; }
        public string Site { get; set; }
        public string Observacao { get; set; }
        public ICollection<DadosBancariosUsuarioModel> DadosBancarios { get; set; }
        public ICollection<DocumentoUsuariosModel> Documentos { get; set; }
        public ICollection<EmpresaModel> Empresas { get; set; }
        public bool Ativo { get; set; }
        [DefaultValue(UsuarioRoles.Usuario)]
        public UsuarioRoles Roles { get; set; }
        public bool OperadorPDV { get; set; }
        public bool ADMPDV { get; set; }
        public bool Vendedor { get; set; }
        public bool Comprador { get; set; }
        public ICollection<GrupoPermissoesModel> Grupo { get; set; }
        public float Comissao { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public byte[]? Foto { get; set; }

        public AlteradorUsuario()
        {
            Grupo = new List<GrupoPermissoesModel>();
            DadosBancarios = new List<DadosBancariosUsuarioModel>();
            Documentos = new List<DocumentoUsuariosModel>();
            Empresas = new List<EmpresaModel>();

            Nome = string.Empty;
            Email = string.Empty;
            Telefone = string.Empty;
            Celular = string.Empty;
            Site = string.Empty;
            Observacao = string.Empty;
        }
    }
}
