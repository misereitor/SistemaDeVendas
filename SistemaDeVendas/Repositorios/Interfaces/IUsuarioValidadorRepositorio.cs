namespace SistemaDeVendas.Repositorios.Interfaces
{
    public interface IUsuarioValidadorRepositorio
    {
        Task<bool> EmailExclusivo(string email);
        Task<bool> UsuarioExclusivo(string usuario);
        bool CPFValidador(string cpf);
        bool CNPJValidador(string cnpj);
        bool RGValidador(string rg);
    }
}
