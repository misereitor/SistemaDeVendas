using SistemaDeVendas.Models.GeralModel;

namespace SistemaDeVendas.Repositorios.Interfaces
{
    public interface IEnderecoRepositorio
    {
        Task<EnderecoModel> AdcionarEnderecoEntregaEmpresa(int idEmpresa, EnderecoModel endereco);
        Task<EnderecoModel> AdcionarEnderecoFaturamentoEmpresa(int idEmpresa, EnderecoModel endereco);
        Task<EnderecoModel> AdcionarEnderecoCorrespondenciaEmpresa(int idEmpresa, EnderecoModel endereco);
        Task<EnderecoModel> AdcionarEnderecoDoUsuario(int IdUsuario, EnderecoModel endereco);
        Task<ICollection<EnderecoModel>> BuscaEnderecoEntregaEmpresa(int idEmpresa);
        Task<ICollection<EnderecoModel>> BuscaEnderecoFaturamentoEmpresa(int idEmpresa);
        Task<ICollection<EnderecoModel>> BuscaEnderecoCorrespondenciaEmpresa(int idEmpresa);
        Task<EnderecoModel> BuscaEnderecoDoUsuario(int IdUsuario);
        Task<EnderecoModel> AlteraEnderecoEntregaEmpresa(int idEmpresa, int idEndereco, EnderecoModel enderecoEntrega);
        Task<EnderecoModel> AlteraEnderecoFaturamentoEmpresa(int idEmpresa, int idEndereco, EnderecoModel enderecoFaturamento);
        Task<EnderecoModel> AlteraEnderecoCorrespondenciaEmpresa(int idEmpresa, int idEndereco, EnderecoModel enderecoCorrespondencia);
        Task<EnderecoModel> AlteraEnderecoDoUsuario(int IdUsuario, int idEndereco, EnderecoModel endereco);
        Task<bool> DeletaEnderecoEntregaEmpresa(int idEmpresa, int idEmderecoEntrega);
        Task<bool> DeletaEnderecoFaturamentoEmpresa(int idEmpresa, int idEmderecoFaturamento);
        Task<bool> DeletaEnderecoCorrespondenciaEmpresa(int idEmpresa, int idEmderecoCorrespondencia);
        Task<bool> DeletaEnderecoUsuario(int idUsuario);
    }
}
