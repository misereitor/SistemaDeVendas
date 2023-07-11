using SistemaDeVendas.Models.RepositorioModel;
using SistemaDeVendas.Models.RequestModels;
using SistemaDeVendas.Models.UsuariosModels;

namespace SistemaDeVendas.Repositorios.Interfaces.InterfaceUsuario
{
    public interface IUsuariosRepositorio
    {
        Task<List<RetornoUsuario>> BuscarTodosOsUsuarios();
        Task<RetornoUsuario> BuscarUsuarioPorId(int id);
        Task<UsuarioModel> CriarUsuario(UsuarioModel usuario);
        Task<RetornoUsuario> AlterarUsuario(AlteradorUsuario usuario, int id);
        Task<bool> DeletarUsuario(int id);
        Task<bool> AlterarSenha(SenhaRequest senha, int id);
    }
}
