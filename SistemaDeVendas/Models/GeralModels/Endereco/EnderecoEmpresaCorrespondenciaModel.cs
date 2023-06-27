using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeVendas.Models.GeralModels.EnderecoModel
{
    [Table("enderecoEmpresaCorrespondencia")]
    public class EnderecoEmpresaCorrespondenciaModel
    {
        [Key]
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }

        public EnderecoEmpresaCorrespondenciaModel()
        {
            Rua = string.Empty;
            Cidade = string.Empty;
            Estado = string.Empty;
            CEP = string.Empty;
            Bairro = string.Empty;
        }
    }
}
