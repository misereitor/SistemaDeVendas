using SistemaDeVendas.Enums;
using SistemaDeVendas.Models.EmpresaModels;
using SistemaDeVendas.Models.GeralModel;
using SistemaDeVendas.Models.GeralModels;
using SistemaDeVendas.Models.Permissoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public Sexo Sexo { get; set; }
        public EnderecoModel? Endereco { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        public string? Site { get; set; }
        public string? Observacao { get; set; }
        public ICollection<DadosBancariosModel> DadosBancarios { get; set; }
        public ICollection<DocumentoUsuariosModel> Documentos { get; set; }
        public ICollection<EmpresaModel> Empresas { get; set; }
        [DefaultValue(true)]
        public bool Ativo { get; set; }
        [DefaultValue(false)]
        public bool Master { get; set; }
        [DefaultValue(false)]
        public bool OperadorPDV { get; set; }
        [DefaultValue(false)]
        public bool ADMPDV { get; set; }
        [DefaultValue(false)]
        public bool Vendedor { get; set; }
        [DefaultValue(false)]
        public bool Comprador { get; set; }
        public GrupoPermissoesModel? Grupo { get; set; }
        public float? Comissao { get; set; }
        public string? Telefone { get; set; }
        public string? Celular { get; set; }
        public TipoPessoa TipoPessoa { get; set; }
        public string? CPF { get; set; }
        public string? CNPJ { get; set; }
        public string? IE { get; set; }
        public string? RG { get; set; }
        public byte[]? Foto { get; set; }
        public int EnderecoId { get; internal set; }
        public int GrupoId { get; internal set; }
        public EmpresaModel Empresa { get; internal set; }

        public UsuarioModel()
        {
            DadosBancarios = new List<DadosBancariosModel>();
            Documentos = new List<DocumentoUsuariosModel>();
            Empresas = new List<EmpresaModel>();
        }
    }
}