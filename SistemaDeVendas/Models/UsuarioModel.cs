using SistemaDeVendas.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeVendas.Models
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
        public string Senha { get; set; }

        public EnderecoModel Endereco { get; set; }

        public ICollection<EmpresaModel>? Empresas { get; set; }

        [Required]
        public string? Funcao { get; set; }

        public bool? Ativo { get; set; }

        [Required]
        public CargoUsuario Perfil { get; set; }

        public bool? PDV { get; set; }

        public bool? ADMPDV { get; set; }
        public bool? Vendedor { get; set; }

        public float? Comissao { get; set; }

        public decimal? Telefone { get; set; }

        [Required]
        public decimal CPF { get; set; }

        public byte[]? Foto { get; set; }

        public UsuarioModel(int id, string nome, string email, string senha, EnderecoModel endereco, ICollection<EmpresaModel>? empresas, string? funcao, bool? ativo, CargoUsuario perfil, bool? pDV, bool? aDMPDV, bool? vendedor, float? comissao, decimal? telefone, decimal cPF, byte[]? foto)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Endereco = endereco;
            Empresas = empresas;
            Funcao = funcao;
            Ativo = ativo;
            Perfil = perfil;
            PDV = pDV;
            ADMPDV = aDMPDV;
            Vendedor = vendedor;
            Comissao = comissao;
            Telefone = telefone;
            CPF = cPF;
            Foto = foto;
        }

        public UsuarioModel()
        {
        }
    }

}