using SistemaDeVendas.Models.GeralModels;

namespace SistemaDeVendas.Repositorios.Interfaces
{
    public interface IDadosBancariosRepositorio
    {
        public Task<DadosBancariosModel> AdicionarDadosBancariosEmpresa(int idEmpresa, DadosBancariosModel dadosBancarios);
        public Task<DadosBancariosModel> AdicionarDadosBancariosUsuario(int idUsuario, DadosBancariosModel dadosBancarios);
        public Task<List<DadosBancariosModel>> BuscarDadosBancariosEmpresaId(int idEmpresa);
        public Task<List<DadosBancariosModel>> BuscarDadosBancariosUsuarioId(int idUsuario);
        public Task<DadosBancariosModel> AlteraDadosBancariosEmpresaPorId(int idEmpresa, int idDadosBancarios, DadosBancariosModel dadosBancarios);
        public Task<DadosBancariosModel> AlteraDadosBancariosUsuarioPorId(int idUsuario, int idDadosBancarios, DadosBancariosModel dadosBancarios);
        public Task<DadosBancariosModel> DeletaDadosBancariosUsuarioPorId(int idEmpresa, int idDadosBancarios);
        public Task<DadosBancariosModel> DeletaDadosBancariosEmpresaPorId(int idUsuario, int idDadosBancarios);

    }
}
