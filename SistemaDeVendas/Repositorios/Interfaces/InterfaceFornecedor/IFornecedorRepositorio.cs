using SistemaDeVendas.Models.FornecedorModels;

namespace SistemaDeVendas.Repositorios.Interfaces.InterfaceFornecedor
{
    public interface IFornecedorRepositorio
    {
        public Task<FornecedorModel> CriarFornecedor(FornecedorModel fornecedor);
        public Task<FornecedorModel> AlterarFornecedor(int idFornecedor, FornecedorModel fornecedor);
        public Task<FornecedorModel> BuscarFornecedorPorId(int idFornecedor);
        public Task<List<FornecedorModel>> BuscarTodosFornecedores();
        public Task<bool> DesativarFornecedorModelPorId(int idFornecedor);
    }
}
