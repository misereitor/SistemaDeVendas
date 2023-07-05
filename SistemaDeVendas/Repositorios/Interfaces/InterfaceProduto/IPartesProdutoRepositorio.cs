using SistemaDeVendas.Models.ProdutoModels.PartesProdutoModel;

namespace SistemaDeVendas.Repositorios.Interfaces.InterfaceProduto
{
    public interface IPartesProdutoRepositorio
    {
        public Task<TipoProdutoModel> AdicionarTipoProduto(TipoProdutoModel tipoProduto);
        public Task<TipoProdutoModel> EditarTipoProduto(int id, TipoProdutoModel tipoProduto);
        public Task<bool> DeletarTipoProduto(int id);
        public Task<List<TipoProdutoModel>> BuscarTodosTiposProduto();
        public Task<TipoProdutoModel> BuscarTiposProdutoPorId(int id);

        public Task<UnidadeProdutoModel> AdicionarUnidadeProduto(UnidadeProdutoModel unidadeProduto);
        public Task<UnidadeProdutoModel> EditarUnidadeProduto(int id, UnidadeProdutoModel unidadeProduto);
        public Task<bool> DeletarUnidadeProduto(int id);
        public Task<List<UnidadeProdutoModel>> BuscarTodosUnidadesProduto();
        public Task<UnidadeProdutoModel> BuscarUnidadeProdutoPorId(int id);

        public Task<CategoriaProdutoModel> AdicionarCategoriaProduto(CategoriaProdutoModel categoriaProduto);
        public Task<CategoriaProdutoModel> EditarCategoriaProduto(int id, CategoriaProdutoModel categoriaProduto);
        public Task<bool> DeletarCategoriaProduto(int id);
        public Task<List<CategoriaProdutoModel>> BuscarTodosCategoriasProduto();
        public Task<CategoriaProdutoModel> BuscarCategoriaProdutoPorId(int id);

        public Task<MarcaProdutoModel> AdicionarMarcaProduto(MarcaProdutoModel marcaProduto);
        public Task<MarcaProdutoModel> EditarMarcaProduto(int id, MarcaProdutoModel marcaProduto);
        public Task<bool> DeletarMarcaProduto(int id);
        public Task<List<MarcaProdutoModel>> BuscarTodossMarcasProduto();
        public Task<MarcaProdutoModel> BuscarMarcaProdutoPorId(int id);

        public Task<FinalidadeProdutoModel> AdicionarFinalidadeProduto(FinalidadeProdutoModel finalidadeProduto);
        public Task<FinalidadeProdutoModel> EditarFinalidadeProduto(int id, FinalidadeProdutoModel finalidadeProduto);
        public Task<bool> DeletarFinalidadeProduto(int id);
        public Task<List<FinalidadeProdutoModel>> BuscarTodasFinalidadesProduto();
        public Task<FinalidadeProdutoModel> BuscarFinalidadeProdutoPorId(int id);

        public Task<RCMProdutoModel> AdicionarRCMProduto(RCMProdutoModel RCMProduto);
        public Task<RCMProdutoModel> EditarRCMProduto(int id, RCMProdutoModel RCMProduto);
        public Task<bool> DeletarRCMProduto(int id);
        public Task<List<RCMProdutoModel>> BuscarTodosRCMProduto();
        public Task<RCMProdutoModel> BuscarRCMProdutoPorId(int id);
    }
}
