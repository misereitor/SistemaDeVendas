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
        public EmpresaModel Empresa { get; set; }

        public EnderecoModel(int id, string rua, string cidade, string estado, string cEP, EmpresaModel empresa)
        {
            Id = id;
            Rua = rua;
            Cidade = cidade;
            Estado = estado;
            CEP = cEP;
            Empresa = empresa;
        }

        public EnderecoModel()
        {
        }
    }
}
