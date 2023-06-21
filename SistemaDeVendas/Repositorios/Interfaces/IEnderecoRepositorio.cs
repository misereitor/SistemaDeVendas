using SistemaDeVendas.Models.GeralModels.EnderecoModel;

namespace SistemaDeVendas.Repositorios.Interfaces
{
    public interface IEnderecoRepositorio
    {
        Task<EnderecoEmpresaEntregaModel> AdcionarEnderecoEntregaEmpresa(int idEmpresa, EnderecoEmpresaEntregaModel endereco);
        Task<EnderecoEmpresaFaturamentoModel> AdcionarEnderecoFaturamentoEmpresa(int idEmpresa, EnderecoEmpresaFaturamentoModel endereco);
        Task<EnderecoEmpresaCorrespondenciaModel> AdcionarEnderecoCorrespondenciaEmpresa(int idEmpresa, EnderecoEmpresaCorrespondenciaModel endereco);
        Task<EnderecoUsuarioModel> AdcionarEnderecoDoUsuario(int IdUsuario, EnderecoUsuarioModel endereco);
        Task<ICollection<EnderecoEmpresaEntregaModel>> BuscaEnderecoEntregaEmpresa(int idEmpresa);
        Task<ICollection<EnderecoEmpresaFaturamentoModel>> BuscaEnderecoFaturamentoEmpresa(int idEmpresa);
        Task<ICollection<EnderecoEmpresaCorrespondenciaModel>> BuscaEnderecoCorrespondenciaEmpresa(int idEmpresa);
        Task<EnderecoUsuarioModel> BuscaEnderecoDoUsuario(int IdUsuario);
        Task<EnderecoEmpresaEntregaModel> AlteraEnderecoEntregaEmpresa(int idEmpresa, int idEndereco, EnderecoEmpresaEntregaModel enderecoFaturamento);
        Task<EnderecoEmpresaFaturamentoModel> AlteraEnderecoFaturamentoEmpresa(int idEmpresa, int idEndereco, EnderecoEmpresaFaturamentoModel enderecoFaturamento);
        Task<EnderecoEmpresaCorrespondenciaModel> AlteraEnderecoCorrespondenciaEmpresa(int idEmpresa, int idEndereco, EnderecoEmpresaCorrespondenciaModel enderecoCorrespondencia);
        Task<EnderecoUsuarioModel> AlteraEnderecoDoUsuario(int IdUsuario, EnderecoUsuarioModel endereco);
        Task<bool> DeletaEnderecoEntregaEmpresa(int idEmpresa, int idEmderecoEntrega);
        Task<bool> DeletaEnderecoFaturamentoEmpresa(int idEmpresa, int idEmderecoFaturamento);
        Task<bool> DeletaEnderecoCorrespondenciaEmpresa(int idEmpresa, int idEmderecoCorrespondencia);
        Task<bool> DeletaEnderecoUsuario(int idUsuario);
    }
}
