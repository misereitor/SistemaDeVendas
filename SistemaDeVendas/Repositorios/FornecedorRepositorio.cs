using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Data;
using SistemaDeVendas.Models.FornecedorModels;
using SistemaDeVendas.Repositorios.Interfaces.InterfaceFornecedor;
using SistemaDeVendas.TratamentoDeErros;

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
            try
            {
                await _dbContext.Forcededor.AddAsync(fornecedor);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return fornecedor;
        }
        public async Task<FornecedorModel> AlterarFornecedor(int idFornecedor, FornecedorModel novoFornecedor)
        {
            FornecedorModel fornecedor = await BuscarFornecedorPorId(idFornecedor) ?? throw new Exception("Fornecedor não encontrado");
            try
            {
                _dbContext.Entry(fornecedor).CurrentValues.SetValues(novoFornecedor);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return fornecedor;
        }

        public async Task<FornecedorModel> BuscarFornecedorPorId(int id)
        {
            FornecedorModel? fornecedor;
            try
            {
                fornecedor = await _dbContext.Forcededor.FirstOrDefaultAsync(x => x.Id == id);
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            if (fornecedor == null)
            {
                throw new ErrosException(404, "Fornecedor não encontrado!");
            }
            return fornecedor;
        }

        public async Task<List<FornecedorModel>> BuscarTodosFornecedores()
        {
            List<FornecedorModel> fornecedores;
            try
            {
                fornecedores = await _dbContext.Forcededor.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return fornecedores;
        }

        public async Task<bool> DesativarFornecedorModelPorId(int idFornecedor)
        {
            FornecedorModel fornecedor = await BuscarFornecedorPorId(idFornecedor) ?? throw new Exception("Fornecedor não encontrado");
            fornecedor.Ativo = false;
            try
            {
                _dbContext.Entry(fornecedor).State = EntityState.Modified;
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
