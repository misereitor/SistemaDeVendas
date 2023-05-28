using SistemaDeVendas.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeVendas.Models
{
    [Table("usuario")]
    public class UsuarioModel
    {
        public UsuarioModel()
        {
            Empresas = new List<EmpresaModel>();
        }

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
    }
}