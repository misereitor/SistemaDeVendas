using SistemaDeVendas.Models.GeralModels.Endereco;
using SistemaDeVendas.Models.GeralModels.EnderecoModel;

namespace SistemaDeVendas.Repositorios.Interfaces.InterfaceModelsGeral
{
    public interface IEnderecoRepositorio
    {
        Task<EnderecoEmpresaEntregaModel> AdcionarEnderecoEntregaEmpresa(int idEmpresa, EnderecoEmpresaEntregaModel endereco);
        Task<EnderecoEmpresaFaturamentoModel> AdcionarEnderecoFaturamentoEmpresa(int idEmpresa, EnderecoEmpresaFaturamentoModel endereco);
        Task<EnderecoEmpresaCorrespondenciaModel> AdcionarEnderecoCorrespondenciaEmpresa(int idEmpresa, EnderecoEmpresaCorrespondenciaModel endereco);
        Task<EnderecoUsuarioModel> AdcionarEnderecoDoUsuario(int idUsuario, EnderecoUsuarioModel endereco);
        Task<EnderecoFornecedor> AdcionarEnderecoDoFornecedor(int idFornecedor, EnderecoFornecedor endereco);
        Task<ICollection<EnderecoEmpresaEntregaModel>> BuscaEnderecoEntregaEmpresa(int idEmpresa);
        Task<ICollection<EnderecoEmpresaFaturamentoModel>> BuscaEnderecoFaturamentoEmpresa(int idEmpresa);
        Task<ICollection<EnderecoEmpresaCorrespondenciaModel>> BuscaEnderecoCorrespondenciaEmpresa(int idEmpresa);
        Task<EnderecoUsuarioModel> BuscaEnderecoDoUsuario(int idUsuario);
        Task<EnderecoFornecedor> BuscaEnderecoDoFornecedor(int idFornecedor);
        Task<EnderecoEmpresaEntregaModel> AlteraEnderecoEntregaEmpresa(int idEmpresa, int idEndereco, EnderecoEmpresaEntregaModel enderecoFaturamento);
        Task<EnderecoEmpresaFaturamentoModel> AlteraEnderecoFaturamentoEmpresa(int idEmpresa, int idEndereco, EnderecoEmpresaFaturamentoModel enderecoFaturamento);
        Task<EnderecoEmpresaCorrespondenciaModel> AlteraEnderecoCorrespondenciaEmpresa(int idEmpresa, int idEndereco, EnderecoEmpresaCorrespondenciaModel enderecoCorrespondencia);
        Task<EnderecoUsuarioModel> AlteraEnderecoDoUsuario(int idUsuario, EnderecoUsuarioModel endereco);
        Task<EnderecoFornecedor> AlteraEnderecoDoFornecedor(int idFornecedor, EnderecoFornecedor endereco);
        Task<bool> DeletaEnderecoEntregaEmpresa(int idEmpresa, int idEmderecoEntrega);
        Task<bool> DeletaEnderecoFaturamentoEmpresa(int idEmpresa, int idEmderecoFaturamento);
        Task<bool> DeletaEnderecoCorrespondenciaEmpresa(int idEmpresa, int idEmderecoCorrespondencia);
        Task<bool> DeletaEnderecoUsuario(int idUsuario);
        Task<bool> DeletaEnderecoFornecedor(int idFornecedor);
    }
}
