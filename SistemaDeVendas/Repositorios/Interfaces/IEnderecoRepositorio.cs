using SistemaDeVendas.Models.GeralModel;

namespace SistemaDeVendas.Repositorios.Interfaces
{
    public interface IEnderecoRepositorio
    {
        Task<EnderecoModel> BuscaEnderecoEntregaEmpresa(int idEmpresa);
        Task<EnderecoModel> BuscaEnderecoFaturamentoEmpresa(int idEmpresa);
        Task<EnderecoModel> BuscaEnderecoCorrespondenciaEmpresa(int idEmpresa);
        Task<EnderecoModel> BuscaEnderecoDoUsuario(int IdUsuario);
        Task<EnderecoModel> AlteraEnderecoEntregaEmpresa(int idEmpresa, EnderecoModel enderecoEntrega);
        Task<EnderecoModel> AlteraEnderecoFaturamentoEmpresa(int idEmpresa, EnderecoModel enderecoFaturamento);
        Task<EnderecoModel> AlteraEnderecoCorrespondenciaEmpresa(int idEmpresa, EnderecoModel enderecoCorrespondencia);
        Task<EnderecoModel> AlteraEnderecoDoUsuario(int IdUsuario, EnderecoModel endereco);
        Task<bool> DeletaEnderecoEntregaEmpresa(int idEmpresa, int idEmderecoEntrega);
        Task<bool> DeletaEnderecoFaturamentoEmpresa(int idEmpresa, int idEmderecoFaturamento);
        Task<bool> DeletaEnderecoCorrespondenciaEmpresa(int idEmpresa, int idEmderecoCorrespondencia);
        Task<bool> DeletarEnderecoDoUsuario(int IdUsuario, EnderecoModel endereco);
    }
}
