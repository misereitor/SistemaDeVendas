using SistemaDeVendas.Models.GeralModel;

namespace SistemaDeVendas.Models.RequestModel
{
    public class EnderecoUsuarioRequest
    {
        public int IdUsuario { get; set; }
        public EnderecoModel Endereco { get; set; }
    }
}
