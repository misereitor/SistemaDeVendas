using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

namespace SistemaDeVendas.Models.GeralModels.EnderecoModel
{
    [Table("enderecousuario")]
    public class EnderecoUsuarioModel
    {
        [Key]
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }

        public EnderecoUsuarioModel()
        {
            Rua = string.Empty;
            Cidade = string.Empty;
            Estado = string.Empty;
            CEP = string.Empty;
        }
    }
}