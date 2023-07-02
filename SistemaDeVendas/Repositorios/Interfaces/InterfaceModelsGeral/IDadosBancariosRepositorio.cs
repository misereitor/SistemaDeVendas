using SistemaDeVendas.Models.GeralModels.DadosBancarios;

namespace SistemaDeVendas.Repositorios.Interfaces.InterfaceDadosBancarios
{
    public interface IDadosBancariosRepositorio
    {
        public Task<DadosBancariosUsuarioModel> AdicionarDadosBancariosEmpresa(int idEmpresa, DadosBancariosUsuarioModel dadosBancarios);
        public Task<DadosBancariosUsuarioModel> AdicionarDadosBancariosUsuario(int idUsuario, DadosBancariosUsuarioModel dadosBancarios);
        public Task<List<DadosBancariosUsuarioModel>> BuscarDadosBancariosEmpresaId(int idEmpresa);
        public Task<List<DadosBancariosUsuarioModel>> BuscarDadosBancariosUsuarioId(int idUsuario);
        public Task<DadosBancariosUsuarioModel> AlteraDadosBancariosEmpresaPorId(int idEmpresa, int idDadosBancarios, DadosBancariosUsuarioModel dadosBancarios);
        public Task<DadosBancariosUsuarioModel> AlteraDadosBancariosUsuarioPorId(int idUsuario, int idDadosBancarios, DadosBancariosUsuarioModel dadosBancarios);
        public Task<DadosBancariosUsuarioModel> DeletaDadosBancariosUsuarioPorId(int idEmpresa, int idDadosBancarios);
        public Task<DadosBancariosUsuarioModel> DeletaDadosBancariosEmpresaPorId(int idUsuario, int idDadosBancarios);

    }
}
