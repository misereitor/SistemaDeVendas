using SistemaDeVendas.Models.UsuariosModels;

namespace SistemaDeVendas.Repositorios.Interfaces
{
    public interface IUsuariosRepositorio
    {
        Task<List<UsuarioModel>> BuscarTodosOsUsuarios();
        Task<UsuarioModel> BuscaUsuarioPorEmailESenha(string email, string senha);
        Task<UsuarioModel> BuscarUsuarioPorId(int id);
        Task<UsuarioModel> CriarUsuario(UsuarioModel usuario);
        Task<UsuarioModel> AlterarUsuario(UsuarioModel usuario, int id);
        Task<bool> DeletarUsuario(int id);
    }
}
