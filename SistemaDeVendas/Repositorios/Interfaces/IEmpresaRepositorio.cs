using SistemaDeVendas.Models;

namespace SistemaDeVendas.Repositorios.Interfaces
{
    public interface IEmpresaRepositorio
    {
        Task<List<EmpresaModel>> BuscarTodosAsEmpresas();
        Task<EmpresaModel> BuscarEmpresaPorId(int id);
        Task<EmpresaModel> CriarEmpresa(EmpresaModel empresa);
        Task<EmpresaModel> AlterarEmpresa(EmpresaModel empresa, int id);
        Task<bool> DeletarEmpresa(int id);
    }
}
