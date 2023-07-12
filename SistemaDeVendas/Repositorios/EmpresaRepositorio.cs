using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Data;
using SistemaDeVendas.Models.EmpresaModels;
using SistemaDeVendas.Repositorios.Interfaces.InteerfaceEmpresa;
using SistemaDeVendas.TratamentoDeErros;

namespace SistemaDeVendas.Repositorios
{
    public class EmpresaRepositorio : IEmpresaRepositorio
    {
        private readonly ConexaoDBContext _dbContext;

        public EmpresaRepositorio(ConexaoDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<EmpresaModel> CriarEmpresa(EmpresaModel empresa)
        {
            try
            {
                await _dbContext.AddAsync(empresa);
                await _dbContext.SaveChangesAsync();
            }catch(Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return empresa;
        }
        public async Task<List<EmpresaModel>> BuscarTodosAsEmpresas()
        {
            List<EmpresaModel> empresas;
            try
            {
                empresas = await _dbContext.Empresas.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return empresas;
        }
        public async Task<EmpresaModel> BuscarEmpresaPorId(int id)
        {
            EmpresaModel? empresa = null;
            try
            {
                empresa = await _dbContext.Empresas.FirstOrDefaultAsync(x => x.Id == id);
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            if (empresa == null)
            {
                throw new Exception("Usuário não encontrado");
            }
            return empresa;
        }
        public async Task<EmpresaModel> AlterarEmpresa(EmpresaModel empresa, int id)
        {
            EmpresaModel empresaPorId = await BuscarEmpresaPorId(id) ?? throw new Exception($"Usuario do ID: {id} não foi encontrado!");
            try
            {
                _dbContext.Entry(empresaPorId).CurrentValues.SetValues(empresa);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return empresaPorId;
        }
        public async Task<bool> DeletarEmpresa(int id)
        {
            EmpresaModel empresaPorId = await BuscarEmpresaPorId(id) ?? throw new Exception($"Usuario do ID: {id} não foi encontrado!");
            try
            {
                _dbContext.Empresas.Remove(empresaPorId);
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
