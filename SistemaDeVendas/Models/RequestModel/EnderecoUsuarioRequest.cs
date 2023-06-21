using SistemaDeVendas.Models.GeralModels.EnderecoModel;

namespace SistemaDeVendas.Models.RequestModel
{
    public class EnderecoUsuarioRequest
    {
        public int IdUsuario { get; set; }
        public EnderecoUsuarioModel Endereco { get; set; }

        public EnderecoUsuarioRequest(int idUsuario, EnderecoUsuarioModel endereco)
        {
            IdUsuario = idUsuario;
            Endereco = endereco;
        }
    }
}
