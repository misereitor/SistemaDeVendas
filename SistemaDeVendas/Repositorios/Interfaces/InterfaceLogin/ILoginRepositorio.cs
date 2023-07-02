using SistemaDeVendas.Models.UsuariosModels;

namespace SistemaDeVendas.Repositorios.Interfaces.InterfaceLogin
{
    public interface ILoginRepositorio
    {
        Task<UsuarioModel> BuscaUsuarioPorUsuarioESenha(string usuario, string senha);
    }
}
