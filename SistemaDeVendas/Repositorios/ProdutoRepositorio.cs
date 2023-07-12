using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Data;
using SistemaDeVendas.Models.ProdutoModels;
using SistemaDeVendas.Repositorios.Interfaces.InterfaceProduto;
using SistemaDeVendas.TratamentoDeErros;

namespace SistemaDeVendas.Repositorios
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly ConexaoDBContext _dbContext;
        public ProdutoRepositorio(ConexaoDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ProdutoModel> CriarProduto(ProdutoModel produto)
        {
            if (produto == null)
            {
                throw new ErrosException(402, "Produto não pode está vazio");
            }
            try
            {
                await _dbContext.Produto.AddAsync(produto);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return produto;
        }

        public async Task<ProdutoModel> AlterarProduto(ProdutoModel produto)
        {
            ProdutoModel p = await BuscarProdutoPorId(produto.Id) ?? throw new ErrosException(404, "Produto não encontrado");
            try
            {
                _dbContext.Entry(p).CurrentValues.SetValues(produto);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return p;
        }

        public async Task<ProdutoModel> BuscarProdutoPorId(int idProduto)
        {
            ProdutoModel? produto = null;
            try
            {
                produto = await _dbContext.Produto.FirstOrDefaultAsync(x => x.Id == idProduto);
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            if (produto == null)
            {
                throw new ErrosException(404, "Produto não encontrado");
            }
            return produto;
        }

        public async Task<List<ProdutoModel>> BuscarTodosProdutos()
        {
            List<ProdutoModel> produtos;
            try
            {
                 produtos = await _dbContext.Produto.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return produtos;
        }

        public async Task<bool> DesativarProdutoPorId(int idProduto)
        {
            ProdutoModel p = await BuscarProdutoPorId(idProduto) ?? throw new ErrosException(404, "Produto não encontrado");
            try
            {
                p.Ativo = false;
                _dbContext.Entry(p).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return true;
        }
    }
}
