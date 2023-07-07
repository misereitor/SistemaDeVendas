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
                throw new ErrosException(401, "A categoria do produto não pode ser vazia");
            }
            await _dbContext.CategoriaProduto.AddAsync(categoriaProduto);
            await _dbContext.SaveChangesAsync();
            return categoriaProduto;
        }

        public async Task<FinalidadeProdutoModel> AdicionarFinalidadeProduto(FinalidadeProdutoModel finalidadeProduto)
        {
            if (finalidadeProduto == null)
            {
                throw new ErrosException(401, "A finalidade do produto não pode ser vazia");
            }
            await _dbContext.FinalidadeProduto.AddAsync(finalidadeProduto);
            await _dbContext.SaveChangesAsync();
            return finalidadeProduto;
        }

        public async Task<MarcaProdutoModel> AdicionarMarcaProduto(MarcaProdutoModel marcaProduto)
        {
            if (marcaProduto == null)
            {
                throw new ErrosException(401, "A marca do produto não pode ser vazia");
            }
            await _dbContext.MarcaProduto.AddAsync(marcaProduto);
            await _dbContext.SaveChangesAsync();
            return marcaProduto;
        }

        public async Task<RCMProdutoModel> AdicionarRCMProduto(RCMProdutoModel RCMProduto)
        {
            if (RCMProduto == null)
            {
                throw new ErrosException(401, "o RCM do produto não pode ser vazia");
            }
            await _dbContext.RCMProduto.AddAsync(RCMProduto);
            await _dbContext.SaveChangesAsync();
            return RCMProduto;
        }

        public async Task<TipoProdutoModel> AdicionarTipoProduto(TipoProdutoModel tipoProduto)
        {
            if (tipoProduto == null)
            {
                throw new ErrosException(401, "o tipo do produto não pode ser vazia");
            }
            await _dbContext.TipoProduto.AddAsync(tipoProduto);
            await _dbContext.SaveChangesAsync();
            return tipoProduto;
        }

        public async Task<UnidadeProdutoModel> AdicionarUnidadeProduto(UnidadeProdutoModel unidadeProduto)
        {
            if (unidadeProduto == null)
            {
                throw new ErrosException(401, "A unidade do produto não pode ser vazia");
            }
            await _dbContext.UnidadeProduto.AddAsync(unidadeProduto);
            await _dbContext.SaveChangesAsync();
            return unidadeProduto;
        }

        public async Task<CategoriaProdutoModel> BuscarCategoriaProdutoPorId(int id)
        {
            CategoriaProdutoModel? categoriaProduto = await _dbContext.CategoriaProduto.FirstOrDefaultAsync(x => x.Id == id) ?? throw new ErrosException(401, "A categoria do produto não foi encontrada");
            return categoriaProduto;

        }

        public async Task<FinalidadeProdutoModel> BuscarFinalidadeProdutoPorId(int id)
        {
            FinalidadeProdutoModel? finalidadeProduto = await _dbContext.FinalidadeProduto.FirstOrDefaultAsync(x => x.Id == id) ?? throw new ErrosException(401, "A Finalidade do produto não foi encontrada");
            return finalidadeProduto;
        }

        public async Task<MarcaProdutoModel> BuscarMarcaProdutoPorId(int id)
        {
            MarcaProdutoModel? marcaProduto = await _dbContext.MarcaProduto.FirstOrDefaultAsync(x => x.Id == id) ?? throw new ErrosException(401, "A marca do produto não foi encontrada");
            return marcaProduto;
        }

        public async Task<RCMProdutoModel> BuscarRCMProdutoPorId(int id)
        {
            RCMProdutoModel? rCMProduto = await _dbContext.RCMProduto.FirstOrDefaultAsync(x => x.Id == id) ?? throw new ErrosException(401, "o RCM do produto não foi encontrado");
            return rCMProduto;
        }

        public async Task<TipoProdutoModel> BuscarTiposProdutoPorId(int id)
        {
            TipoProdutoModel? tipoProduto = await _dbContext.TipoProduto.FirstOrDefaultAsync(x => x.Id == id) ?? throw new ErrosException(401, "O tipo do produto não foi encontrado");
            return tipoProduto;
        }
        public async Task<UnidadeProdutoModel> BuscarUnidadeProdutoPorId(int id)
        {
            UnidadeProdutoModel? unidadeProduto = await _dbContext.UnidadeProduto.FirstOrDefaultAsync(x => x.Id == id) ?? throw new ErrosException(401, "O tipo do produto não foi encontrado");
            return unidadeProduto;
        }

        public async Task<List<FinalidadeProdutoModel>> BuscarTodasFinalidadesProduto()
        {
            List<FinalidadeProdutoModel> finalidadesProduto = await _dbContext.FinalidadeProduto.ToListAsync();
            return finalidadesProduto;
        }

        public async Task<List<CategoriaProdutoModel>> BuscarTodosCategoriasProduto()
        {
            List<CategoriaProdutoModel> categoriaProduto = await _dbContext.CategoriaProduto.ToListAsync();
            return categoriaProduto;
        }

        public async Task<List<RCMProdutoModel>> BuscarTodosRCMProduto()
        {
            List<RCMProdutoModel> rCMProduto = await _dbContext.RCMProduto.ToListAsync();
            return rCMProduto;
        }

        public async Task<List<MarcaProdutoModel>> BuscarTodossMarcasProduto()
        {
            List<MarcaProdutoModel> MarcaProduto = await _dbContext.MarcaProduto.ToListAsync();
            return MarcaProduto;
        }

        public async Task<List<TipoProdutoModel>> BuscarTodosTiposProduto()
        {
            List<TipoProdutoModel> tipoProduto = await _dbContext.TipoProduto.ToListAsync();
            return tipoProduto;
        }

        public async Task<List<UnidadeProdutoModel>> BuscarTodosUnidadesProduto()
        {
            List<UnidadeProdutoModel> unidadeProduto = await _dbContext.UnidadeProduto.ToListAsync();
            return unidadeProduto;
        }


        public async Task<bool> DeletarCategoriaProduto(int id)
        {
            CategoriaProdutoModel categoriaProduto = await BuscarCategoriaProdutoPorId(id);
            _dbContext .CategoriaProduto.Remove(categoriaProduto);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeletarFinalidadeProduto(int id)
        {
            FinalidadeProdutoModel finalidadeProduto = await BuscarFinalidadeProdutoPorId(id);
            _dbContext.FinalidadeProduto.Remove(finalidadeProduto);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeletarMarcaProduto(int id)
        {
            MarcaProdutoModel marcaProduto = await BuscarMarcaProdutoPorId(id);
            _dbContext.MarcaProduto.Remove(marcaProduto);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeletarRCMProduto(int id)
        {
            RCMProdutoModel rCMProduto = await BuscarRCMProdutoPorId(id);
            _dbContext.RCMProduto.Remove(rCMProduto);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeletarTipoProduto(int id)
        {
            TipoProdutoModel tipoProduto = await BuscarTiposProdutoPorId(id);
            _dbContext.TipoProduto.Remove(tipoProduto);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeletarUnidadeProduto(int id)
        {
            UnidadeProdutoModel unidadeProduto = await BuscarUnidadeProdutoPorId(id);
            _dbContext.UnidadeProduto.Remove(unidadeProduto);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<CategoriaProdutoModel> EditarCategoriaProduto(int id, CategoriaProdutoModel categoriaProduto)
        {
            CategoriaProdutoModel categoria = await BuscarCategoriaProdutoPorId(id);
            _dbContext.Entry(categoria).CurrentValues.SetValues(categoriaProduto);
            await _dbContext.SaveChangesAsync();
            return categoria;
        }

        public async Task<FinalidadeProdutoModel> EditarFinalidadeProduto(int id, FinalidadeProdutoModel finalidadeProduto)
        {
            FinalidadeProdutoModel finalidade = await BuscarFinalidadeProdutoPorId(id);
            _dbContext.Entry(finalidade).CurrentValues.SetValues(finalidadeProduto);
            await _dbContext.SaveChangesAsync();
            return finalidade;

        }

        public async Task<MarcaProdutoModel> EditarMarcaProduto(int id, MarcaProdutoModel marcaProduto)
        {
            MarcaProdutoModel marca = await BuscarMarcaProdutoPorId(id);
            _dbContext.Entry(marca).CurrentValues.SetValues(marcaProduto);
            await _dbContext.SaveChangesAsync();
            return marca;

        }

        public async Task<RCMProdutoModel> EditarRCMProduto(int id, RCMProdutoModel RCMProduto)
        {
            RCMProdutoModel rCMP = await BuscarRCMProdutoPorId(id);
            _dbContext.Entry(rCMP).CurrentValues.SetValues(RCMProduto);
            await _dbContext.SaveChangesAsync();
            return rCMP;

        }

        public async Task<TipoProdutoModel> EditarTipoProduto(int id, TipoProdutoModel tipoProduto)
        {
            TipoProdutoModel tipo = await BuscarTiposProdutoPorId(id);
            _dbContext.Entry(tipo).CurrentValues.SetValues(tipoProduto);
            await _dbContext.SaveChangesAsync();
            return tipo;

        }

        public async Task<UnidadeProdutoModel> EditarUnidadeProduto(int id, UnidadeProdutoModel unidadeProduto)
        {
            UnidadeProdutoModel unidade = await BuscarUnidadeProdutoPorId(id);
            _dbContext.Entry(unidade).CurrentValues.SetValues(unidadeProduto);
            await _dbContext.SaveChangesAsync();
            return unidade;

        }
    }
}
