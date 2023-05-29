using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeVendas.Models
{
    [Table("empresa")]
    public class EmpresaModel
    {

        [Key]
        public int Id { get; set; }
        public string NomeFantasia { get; set; }
        public string? RazaoSocial { get; set; }
        public byte[]? Logo { get; set; }
        public decimal  CNPJ { get; set; }
        public bool Ativo { get; set; }
        public string? AreaDeAtuacao { get; set; }
        public decimal? Telefone { get; set; }
        public string Email { get; set; }
        public string? IE { get; set; }
        public string? IM { get; set; }
        public int? EnderecoEntregaId { get; set; }
        public EnderecoModel? EnderecoEntrega { get; set; }
        public int? EnderecoFaturamentoId { get; set; }
        public EnderecoModel? EnderecoFaturamento { get; set; }
        public int? EnderecoCorrespondenciaId { get; set; }
        public EnderecoModel? EnderecoCorrespondencia { get; set; }
        public ICollection<UsuarioModel>? Usuarios { get; set; }

        public EmpresaModel(int id, string nomeFantasia, string razaoSocial, byte[] logo, decimal cNPJ, bool ativo, string areaDeAtuacao, decimal telefone, string email, string iE, string iM, int enderecoEntregaId, EnderecoModel enderecoEntrega, int enderecoFaturamentoId, EnderecoModel enderecoFaturamento, int enderecoCorrespondenciaId, EnderecoModel enderecoCorrespondencia, ICollection<UsuarioModel> usuarios)
        {
            Id = id;
            NomeFantasia = nomeFantasia;
            RazaoSocial = razaoSocial;
            Logo = logo;
            CNPJ = cNPJ;
            Ativo = ativo;
            AreaDeAtuacao = areaDeAtuacao;
            Telefone = telefone;
            Email = email;
            IE = iE;
            IM = iM;
            EnderecoEntregaId = enderecoEntregaId;
            EnderecoEntrega = enderecoEntrega;
            EnderecoFaturamentoId = enderecoFaturamentoId;
            EnderecoFaturamento = enderecoFaturamento;
            EnderecoCorrespondenciaId = enderecoCorrespondenciaId;
            EnderecoCorrespondencia = enderecoCorrespondencia;
            Usuarios = usuarios;
        }

        public EmpresaModel()
        {
        }
    }
}
