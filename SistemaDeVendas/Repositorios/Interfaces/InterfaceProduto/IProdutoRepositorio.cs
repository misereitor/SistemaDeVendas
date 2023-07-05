using SistemaDeVendas.Models.ProdutoModels;

namespace SistemaDeVendas.Repositorios.Interfaces.InterfaceProduto
{
    public interface IProdutoRepositorio
    {
        public Task<ProdutoModel> CriarProduto(ProdutoModel produto);
        public Task<ProdutoModel> AlterarProduto(ProdutoModel produto);
        public Task<ProdutoModel> BuscarProdutoPorId(int idProduto);
        public Task<List<ProdutoModel>> BuscarTodosProdutos();
        public Task<bool> DesativarProdutoPorId(int idProduto);
    }
}
