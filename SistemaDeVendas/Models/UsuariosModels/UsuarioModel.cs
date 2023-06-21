using SistemaDeVendas.Enums;
using SistemaDeVendas.Models.EmpresaModels;
using SistemaDeVendas.Models.GeralModels.DadosBancarios;
using SistemaDeVendas.Models.GeralModels.EnderecoModel;
using SistemaDeVendas.Models.Permissoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace SistemaDeVendas.Models.UsuariosModels
{
    [Table("usuario")]
    public class UsuarioModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(150)]
        public string Email { get; set; }
        [Required]
        [MaxLength(30)]
        public string Usuario { get; set; }
        [Required]
        [MaxLength(20)]
        public string Senha { get; set; }
        [Required]
        public UsuarioSexo Sexo { get; set; }
        public EnderecoUsuarioModel Endereco { get; set; }
        [Required]
        public DateOnly DataNascimento { get; set; }
        public DateTimeOffset DataCriacao { get; set; } = DateTimeOffset.UtcNow;
        public string Site { get; set; }
        public string Observacao { get; set; }
        public ICollection<DadosBancariosUsuarioModel> DadosBancarios { get; set; }
        public ICollection<DocumentoUsuariosModel> Documentos { get; set; }
        public ICollection<EmpresaModel> Empresas { get; set; }
        [DefaultValue(true)]
        public bool Ativo { get; set; }
        [DefaultValue(UsuarioRoles.Usuario)]
        public UsuarioRoles Roles { get; set; }
        [DefaultValue(false)]
        public bool OperadorPDV { get; set; }
        [DefaultValue(false)]
        public bool ADMPDV { get; set; }
        [DefaultValue(false)]
        public bool Vendedor { get; set; }
        [DefaultValue(false)]
        public bool Comprador { get; set; }
        public ICollection<GrupoPermissoesModel> Grupo { get; set; }
        [DefaultValue(0)]
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
        public int EnderecoId { get; set; }

        public UsuarioModel()
        {
            Grupo = new List<GrupoPermissoesModel>();
            DadosBancarios = new List<DadosBancariosUsuarioModel>();
            Documentos = new List<DocumentoUsuariosModel>();
            Empresas = new List<EmpresaModel>();
            Endereco = new EnderecoUsuarioModel();

            Nome = string.Empty;
            Email = string.Empty;
            Senha = string.Empty;
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