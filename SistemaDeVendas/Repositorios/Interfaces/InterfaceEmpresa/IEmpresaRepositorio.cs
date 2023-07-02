using SistemaDeVendas.Models.EmpresaModels;

namespace SistemaDeVendas.Repositorios.Interfaces.InteerfaceEmpresa
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
