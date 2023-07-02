using SistemaDeVendas.Models.UsuariosModels;

namespace SistemaDeVendas.Repositorios.Interfaces.InterfaceUsuario
{
    public interface IUsuarioValidadorRepositorio
    {
        Task<bool> EmailExclusivo(string email);
        Task<bool> UsuarioExclusivo(string usuario);
        bool CPFValidador(UsuarioModel usuario);
        bool CNPJValidador(UsuarioModel usuario);
        bool RGValidador(UsuarioModel usuario);
        bool PesoaJuridica(UsuarioModel usuario);
        bool PesoaFisica(UsuarioModel usuario);
    }
}
