using SistemaDeVendas.Enums;
using SistemaDeVendas.Models.EmpresaModels;
using SistemaDeVendas.Models.FinanceiroModel;
using SistemaDeVendas.Models.GeralModel;
using SistemaDeVendas.Models.GeralModels;
using SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels;
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
        [MaxLength(64)]
        public string Usuario { get; set; }
        [Required]
        [MaxLength(64)]
        public string Senha { get; set; }
        [Required]
        public Sexo Sexo { get; set; }
        public ICollection<EnderecoModel>? Endereco { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string? Site { get; set; }
        public string? Observacao { get; set; }
        public ICollection<DadosBancariosModel>? DadosBancarios { get; set; }
        public ICollection<DocumentoUsuariosModel>? Documentos { get; set; }
        public ICollection<EmpresaModel>? Empresas { get; set; }
        [Required]
        public PermissaoUsuarioModel Perfil { get; set; }
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
        [DefaultValue(false)]
        public bool Fornecedor { get; set; }
        public TipoFornecedorModel? Tipo { get; set; }
        public ICollection<ContasAPagarModel>? FinacneiroFornecedor { get; set; }
        [DefaultValue(false)]
        public bool FornecedorTransportador { get; set; }
        [DefaultValue(false)]
        public bool FornecedorRural { get; set; }
        public string? EmailNFEFornecedor { get; set; }
        public float? Comissao { get; set; }
        public decimal? Telefone { get; set; }
        public decimal? Celular { get; set; }
        public decimal? CPF { get; set; }
        public decimal? CNPJ { get; set; }
        public decimal? RG { get; set; }
        public decimal? Emissor { get; set; }
        public UF UF { get; set; }
        [Required]
        public decimal IE { get; set; }
        public decimal? IM { get; set; }
        public byte[]? Foto { get; set; }

        public UsuarioModel(int id, string nome, string email, string usuario, string senha, Sexo sexo, ICollection<EnderecoModel>? endereco, DateTime? dataNascimento, string? site, string? observacao, ICollection<DadosBancariosModel>? dadosBancarios, ICollection<DocumentoUsuariosModel>? documentos, ICollection<EmpresaModel>? empresas, PermissaoUsuarioModel perfil, bool ativo, bool master, bool operadorPDV, bool aDMPDV, bool vendedor, bool comprador, bool fornecedor, TipoFornecedorModel? tipo, ICollection<ContasAPagarModel>? finacneiroFornecedor, bool fornecedorTransportador, bool fornecedorRural, string? emailNFEFornecedor, float? comissao, decimal? telefone, decimal? celular, decimal? cPF, decimal? cNPJ, decimal? rG, decimal? emissor, UF uF, decimal iE, decimal? iM, byte[]? foto)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Usuario = usuario;
            Senha = senha;
            Sexo = sexo;
            Endereco = endereco;
            DataNascimento = dataNascimento;
            Site = site;
            Observacao = observacao;
            DadosBancarios = dadosBancarios;
            Documentos = documentos;
            Empresas = empresas;
            Perfil = perfil;
            Ativo = ativo;
            Master = master;
            OperadorPDV = operadorPDV;
            ADMPDV = aDMPDV;
            Vendedor = vendedor;
            Comprador = comprador;
            Fornecedor = fornecedor;
            Tipo = tipo;
            FinacneiroFornecedor = finacneiroFornecedor;
            FornecedorTransportador = fornecedorTransportador;
            FornecedorRural = fornecedorRural;
            EmailNFEFornecedor = emailNFEFornecedor;
            Comissao = comissao;
            Telefone = telefone;
            Celular = celular;
            CPF = cPF;
            CNPJ = cNPJ;
            RG = rG;
            Emissor = emissor;
            UF = uF;
            IE = iE;
            IM = iM;
            Foto = foto;
        }

        public UsuarioModel()
        {
        }
    }

}