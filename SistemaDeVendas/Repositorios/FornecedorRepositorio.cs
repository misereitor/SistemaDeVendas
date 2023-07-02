using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Data;
using SistemaDeVendas.Models.FornecedorModels;
using SistemaDeVendas.Repositorios.Interfaces.InterfaceFornecedor;

namespace SistemaDeVendas.Repositorios
{
    public class FornecedorRepositorio : IFornecedorRepositorio
    {
        private readonly ConexaoDBContext _dbContext;
        public FornecedorRepositorio(ConexaoDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<FornecedorModel> CriarFornecedor(FornecedorModel fornecedor)
        {
            if (fornecedor == null)
            {
                throw new Exception("Fornecedor não é válido!");
            }
            await _dbContext.Forcededor.AddAsync(fornecedor);
            await _dbContext.SaveChangesAsync();
            return fornecedor;
        }
        public async Task<FornecedorModel> AlterarFornecedor(int idFornecedor, FornecedorModel novoFornecedor)
        {
            FornecedorModel fornecedor = await BuscarFornecedorPorId(idFornecedor) ?? throw new Exception("Fornecedor não encontrado");
            _dbContext.Entry(fornecedor).CurrentValues.SetValues(novoFornecedor);
            await _dbContext.SaveChangesAsync();
            return fornecedor;
        }

        public async Task<FornecedorModel> BuscarFornecedorPorId(int id)
        {
            FornecedorModel? fornecedor = null;
            fornecedor = await _dbContext.Forcededor.FirstOrDefaultAsync(x => x.Id == id);
            if (fornecedor == null)
            {
                throw new Exception("Fornecedor não encontrado!");
            }
            return fornecedor;
        }

        public async Task<List<FornecedorModel>> BuscarTodosFornecedores()
        {
            List<FornecedorModel> fornecedores = await _dbContext.Forcededor.ToListAsync();
            return fornecedores;
        }

        public async Task<bool> DesativarFornecedorModelPorId(int idFornecedor)
        {
            FornecedorModel fornecedor = await BuscarFornecedorPorId(idFornecedor) ?? throw new Exception("Fornecedor não encontrado");
            fornecedor.Ativo = false;
            _dbContext.Entry(fornecedor).CurrentValues.SetValues(fornecedor);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
