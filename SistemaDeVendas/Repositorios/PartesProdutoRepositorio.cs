using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Data;
using SistemaDeVendas.Models.ProdutoModels.PartesProdutoModel;
using SistemaDeVendas.Repositorios.Interfaces.InterfaceProduto;
using SistemaDeVendas.TratamentoDeErros;

namespace SistemaDeVendas.Repositorios
{
    public class PartesProdutoRepositorio : IPartesProdutoRepositorio
    {
        private readonly ConexaoDBContext _dbContext;
        public PartesProdutoRepositorio(ConexaoDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<CategoriaProdutoModel> AdicionarCategoriaProduto(CategoriaProdutoModel categoriaProduto)
        {
            if (categoriaProduto == null)
            {
                throw new ErrosException(402, "A categoria do produto não pode ser vazia");
            }
            try
            {
                await _dbContext.CategoriaProduto.AddAsync(categoriaProduto);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return categoriaProduto;
        }

        public async Task<FinalidadeProdutoModel> AdicionarFinalidadeProduto(FinalidadeProdutoModel finalidadeProduto)
        {
            if (finalidadeProduto == null)
            {
                throw new ErrosException(402, "A finalidade do produto não pode ser vazia");
            }
            try
            {
                await _dbContext.FinalidadeProduto.AddAsync(finalidadeProduto);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return finalidadeProduto;
        }

        public async Task<MarcaProdutoModel> AdicionarMarcaProduto(MarcaProdutoModel marcaProduto)
        {
            if (marcaProduto == null)
            {
                throw new ErrosException(402, "A marca do produto não pode ser vazia");
            }
            try
            {
                await _dbContext.MarcaProduto.AddAsync(marcaProduto);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return marcaProduto;
        }

        public async Task<RCMProdutoModel> AdicionarRCMProduto(RCMProdutoModel RCMProduto)
        {
            if (RCMProduto == null)
            {
                throw new ErrosException(402, "o RCM do produto não pode ser vazia");
            }
            try
            {
                await _dbContext.RCMProduto.AddAsync(RCMProduto);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return RCMProduto;
        }

        public async Task<TipoProdutoModel> AdicionarTipoProduto(TipoProdutoModel tipoProduto)
        {
            if (tipoProduto == null)
            {
                throw new ErrosException(402, "o tipo do produto não pode ser vazia");
            }
            try
            {
                await _dbContext.TipoProduto.AddAsync(tipoProduto);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return tipoProduto;
        }

        public async Task<UnidadeProdutoModel> AdicionarUnidadeProduto(UnidadeProdutoModel unidadeProduto)
        {
            if (unidadeProduto == null)
            {
                throw new ErrosException(402, "A unidade do produto não pode ser vazia");
            }
            try
            {
                await _dbContext.UnidadeProduto.AddAsync(unidadeProduto);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return unidadeProduto;
        }

        public async Task<CategoriaProdutoModel> BuscarCategoriaProdutoPorId(int id)
        {
            CategoriaProdutoModel categoriaProduto;
            try
            {
                categoriaProduto = await _dbContext.CategoriaProduto.FirstOrDefaultAsync(x => x.Id == id) ?? throw new ErrosException(404, "A categoria do produto não foi encontrada");
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return categoriaProduto;
        }

        public async Task<FinalidadeProdutoModel> BuscarFinalidadeProdutoPorId(int id)
        {
            FinalidadeProdutoModel finalidadeProduto;
            try
            {
                finalidadeProduto = await _dbContext.FinalidadeProduto.FirstOrDefaultAsync(x => x.Id == id) ?? throw new ErrosException(404, "A Finalidade do produto não foi encontrada");
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return finalidadeProduto;
        }

        public async Task<MarcaProdutoModel> BuscarMarcaProdutoPorId(int id)
        {
            MarcaProdutoModel marcaProduto;
            try
            {
                marcaProduto = await _dbContext.MarcaProduto.FirstOrDefaultAsync(x => x.Id == id) ?? throw new ErrosException(404, "A marca do produto não foi encontrada");
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return marcaProduto;
        }

        public async Task<RCMProdutoModel> BuscarRCMProdutoPorId(int id)
        {
            RCMProdutoModel rCMProduto;
            try
            {
                rCMProduto = await _dbContext.RCMProduto.FirstOrDefaultAsync(x => x.Id == id) ?? throw new ErrosException(404, "o RCM do produto não foi encontrado");
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return rCMProduto;
        }

        public async Task<TipoProdutoModel> BuscarTiposProdutoPorId(int id)
        {
            TipoProdutoModel tipoProduto;
            try
            {
                tipoProduto = await _dbContext.TipoProduto.FirstOrDefaultAsync(x => x.Id == id) ?? throw new ErrosException(404, "O tipo do produto não foi encontrado");
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return tipoProduto;
        }
        public async Task<UnidadeProdutoModel> BuscarUnidadeProdutoPorId(int id)
        {

            UnidadeProdutoModel unidadeProduto;
            try
            {
                unidadeProduto = await _dbContext.UnidadeProduto.FirstOrDefaultAsync(x => x.Id == id) ?? throw new ErrosException(404, "O tipo do produto não foi encontrado");
            }
            catch (Exception ex) { throw new ErrosException(500, ex.Message); }
            return unidadeProduto;
        }

        public async Task<List<FinalidadeProdutoModel>> BuscarTodasFinalidadesProduto()
        {
            List<FinalidadeProdutoModel> finalidadesProduto;
            try
            {
                finalidadesProduto = await _dbContext.FinalidadeProduto.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return finalidadesProduto;
        }

        public async Task<List<CategoriaProdutoModel>> BuscarTodosCategoriasProduto()
        {
            List<CategoriaProdutoModel> categoriaProduto;
            try
            {
                categoriaProduto = await _dbContext.CategoriaProduto.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return categoriaProduto;
        }

        public async Task<List<RCMProdutoModel>> BuscarTodosRCMProduto()
        {
            List<RCMProdutoModel> rCMProduto;
            try
            {
                rCMProduto = await _dbContext.RCMProduto.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return rCMProduto;
        }

        public async Task<List<MarcaProdutoModel>> BuscarTodossMarcasProduto()
        {
            List<MarcaProdutoModel> MarcaProduto;
            try
            {
                MarcaProduto = await _dbContext.MarcaProduto.ToListAsync();
            }
            catch (Exception ex) { throw new ErrosException(500, ex.Message); }
            return MarcaProduto;
        }

        public async Task<List<TipoProdutoModel>> BuscarTodosTiposProduto()
        {
            List<TipoProdutoModel> tipoProduto;
            try
            {
                tipoProduto = await _dbContext.TipoProduto.ToListAsync();
            }
            catch (Exception ex) { throw new ErrosException(500, ex.Message); }
            return tipoProduto;
        }

        public async Task<List<UnidadeProdutoModel>> BuscarTodosUnidadesProduto()
        {
            List<UnidadeProdutoModel> unidadeProduto;
            try
            {
                unidadeProduto = await _dbContext.UnidadeProduto.ToListAsync();
            }
            catch (Exception ex) { throw new ErrosException(500, ex.Message); }
            return unidadeProduto;
        }


        public async Task<bool> DeletarCategoriaProduto(int id)
        {
            CategoriaProdutoModel categoriaProduto = await BuscarCategoriaProdutoPorId(id);
            try
            {
                _dbContext .CategoriaProduto.Remove(categoriaProduto);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return true;
        }

        public async Task<bool> DeletarFinalidadeProduto(int id)
        {
            FinalidadeProdutoModel finalidadeProduto = await BuscarFinalidadeProdutoPorId(id);
            try
            {
                _dbContext.FinalidadeProduto.Remove(finalidadeProduto);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return true;
        }

        public async Task<bool> DeletarMarcaProduto(int id)
        {
            MarcaProdutoModel marcaProduto = await BuscarMarcaProdutoPorId(id);
            try
            {
                _dbContext.MarcaProduto.Remove(marcaProduto);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex) { throw new ErrosException(500, ex.Message); }
            return true;
        }

        public async Task<bool> DeletarRCMProduto(int id)
        {
            RCMProdutoModel rCMProduto = await BuscarRCMProdutoPorId(id);
            try
            {
                _dbContext.RCMProduto.Remove(rCMProduto);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex) { throw new ErrosException(500, ex.Message); }
            return true;
        }

        public async Task<bool> DeletarTipoProduto(int id)
        {
            TipoProdutoModel tipoProduto = await BuscarTiposProdutoPorId(id);
            try
            {
                _dbContext.TipoProduto.Remove(tipoProduto);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex) { throw new ErrosException(500, ex.Message); }
            return true;
        }

        public async Task<bool> DeletarUnidadeProduto(int id)
        {
            UnidadeProdutoModel unidadeProduto = await BuscarUnidadeProdutoPorId(id);
            try
            {
                _dbContext.UnidadeProduto.Remove(unidadeProduto);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex) { throw new ErrosException(500, ex.Message); }
            return true;
        }

        public async Task<CategoriaProdutoModel> EditarCategoriaProduto(int id, CategoriaProdutoModel categoriaProduto)
        {
            CategoriaProdutoModel categoria = await BuscarCategoriaProdutoPorId(id);
            try
            {
                _dbContext.Entry(categoria).CurrentValues.SetValues(categoriaProduto);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex) { throw new ErrosException(500, ex.Message); }
            return categoria;
        }

        public async Task<FinalidadeProdutoModel> EditarFinalidadeProduto(int id, FinalidadeProdutoModel finalidadeProduto)
        {
            FinalidadeProdutoModel finalidade = await BuscarFinalidadeProdutoPorId(id);
            try
            {
                _dbContext.Entry(finalidade).CurrentValues.SetValues(finalidadeProduto);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return finalidade;

        }

        public async Task<MarcaProdutoModel> EditarMarcaProduto(int id, MarcaProdutoModel marcaProduto)
        {
            MarcaProdutoModel marca = await BuscarMarcaProdutoPorId(id);
            try
            {
                _dbContext.Entry(marca).CurrentValues.SetValues(marcaProduto);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex) { throw new ErrosException(500, ex.Message); }
            return marca;

        }

        public async Task<RCMProdutoModel> EditarRCMProduto(int id, RCMProdutoModel RCMProduto)
        {
            RCMProdutoModel rCMP = await BuscarRCMProdutoPorId(id);
            try
            {
                _dbContext.Entry(rCMP).CurrentValues.SetValues(RCMProduto);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex) { throw new ErrosException(500, ex.Message); }
            return rCMP;

        }

        public async Task<TipoProdutoModel> EditarTipoProduto(int id, TipoProdutoModel tipoProduto)
        {
            TipoProdutoModel tipo = await BuscarTiposProdutoPorId(id);
            try
            {
                _dbContext.Entry(tipo).CurrentValues.SetValues(tipoProduto);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex) { throw new ErrosException(500, ex.Message); }
            return tipo;

        }

        public async Task<UnidadeProdutoModel> EditarUnidadeProduto(int id, UnidadeProdutoModel unidadeProduto)
        {
            UnidadeProdutoModel unidade = await BuscarUnidadeProdutoPorId(id);
            try
            {
                _dbContext.Entry(unidade).CurrentValues.SetValues(unidadeProduto);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex) { throw new ErrosException(500, ex.Message); }
            return unidade;

        }
    }
}
