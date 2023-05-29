using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeVendas.Models
{
    [Table("endereco")]
    public class EnderecoModel
    {
        [Key]
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public int EmpresaId { get; set; }
        public int UsuarioId { get; set; }

        public EnderecoModel(int id, string rua, string cidade, string estado, string cEP, int empresaId, int usuarioId)
        {
            Id = id;
            Rua = rua;
            Cidade = cidade;
            Estado = estado;
            CEP = cEP;
            EmpresaId = empresaId;
            UsuarioId = usuarioId;
        }

        public EnderecoModel()
        {
        }
    }
}
