using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeVendas.Models.GeralModels.EnderecoModel
{
    [Table("enderecoEmpresaFaturamento")]
    public class EnderecoEmpresaFaturamentoModel
    {
        [Key]
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }

        public EnderecoEmpresaFaturamentoModel()
        {
            Rua = string.Empty;
            Cidade = string.Empty;
            Estado = string.Empty;
            CEP = string.Empty;
            Bairro = string.Empty;
        }
    }
}
