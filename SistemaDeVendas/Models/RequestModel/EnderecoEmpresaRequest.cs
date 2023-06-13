using SistemaDeVendas.Models.GeralModel;

namespace SistemaDeVendas.Models.RequestModel
{
    public class EnderecoEmpresaRequest
    {
        public int IdEmpresa { get; set; }
        public int IdEndereco { get; set; }
        public EnderecoModel Endereco { get; set; }
    }
}
