using SistemaDeVendas.Data;
using SistemaDeVendas.Models.EmpresaModels;
using SistemaDeVendas.Models.FornecedorModels;
using SistemaDeVendas.Models.GeralModels.Endereco;
using SistemaDeVendas.Models.GeralModels.EnderecoModel;
using SistemaDeVendas.Models.RepositorioModel;
using SistemaDeVendas.Repositorios.Interfaces.InteerfaceEmpresa;
using SistemaDeVendas.Repositorios.Interfaces.InterfaceFornecedor;
using SistemaDeVendas.Repositorios.Interfaces.InterfaceModelsGeral;
using SistemaDeVendas.Repositorios.Interfaces.InterfaceUsuario;
using SistemaDeVendas.TratamentoDeErros;

namespace SistemaDeVendas.Repositorios
{
    public class EnderecoRepositorio : IEnderecoRepositorio
    {
        private readonly ConexaoDBContext _dbContext;
        private readonly IEmpresaRepositorio _empresaRepositorio;
        private readonly IUsuariosRepositorio _usuarioRepositorio;
        private readonly IFornecedorRepositorio _fornecedorRepositorio;

        public EnderecoRepositorio(ConexaoDBContext dbContext, IEmpresaRepositorio empresaRepositorio, IUsuariosRepositorio usuarioRepositorio, IFornecedorRepositorio fornecedorRepositorio)
        {
            _dbContext = dbContext;
            _empresaRepositorio = empresaRepositorio;
            _usuarioRepositorio = usuarioRepositorio;
            _fornecedorRepositorio = fornecedorRepositorio;
        }

        public async Task<EnderecoEmpresaCorrespondenciaModel> AdcionarEnderecoCorrespondenciaEmpresa(int idEmpresa, EnderecoEmpresaCorrespondenciaModel endereco)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            empresa.EnderecoCorrespondencia.Add(endereco);
            try
            {
                _dbContext.Entry(empresa).CurrentValues.SetValues(empresa);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return endereco;
        }

        public async Task<EnderecoEmpresaEntregaModel> AdcionarEnderecoEntregaEmpresa(int idEmpresa, EnderecoEmpresaEntregaModel endereco)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            empresa.EnderecoEntrega.Add(endereco);
            try
            {
                _dbContext.Entry(empresa).CurrentValues.SetValues(empresa);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return endereco;
        }

        public async Task<EnderecoEmpresaFaturamentoModel> AdcionarEnderecoFaturamentoEmpresa(int idEmpresa, EnderecoEmpresaFaturamentoModel endereco)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            empresa.EnderecoFaturamento.Add(endereco);
            try
            {
                _dbContext.Entry(empresa).CurrentValues.SetValues(empresa);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return endereco;
        }

        public async Task<EnderecoUsuarioModel> AdcionarEnderecoDoUsuario(int IdUsuario, EnderecoUsuarioModel endereco)
        {
            RetornoUsuario usuario = await _usuarioRepositorio.BuscarUsuarioPorId(IdUsuario);
            usuario.Endereco = endereco;
            try
            {
                _dbContext.Entry(usuario).CurrentValues.SetValues(usuario);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return endereco;
        }

        public async Task<EnderecoFornecedor> AdcionarEnderecoDoFornecedor(int IdFornecedor, EnderecoFornecedor endereco)
        {
            FornecedorModel fornecedor = await _fornecedorRepositorio.BuscarFornecedorPorId(IdFornecedor);
            fornecedor.Endereco = endereco;
            try
            {
                _dbContext.Entry(fornecedor).CurrentValues.SetValues(fornecedor);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return endereco;
        }

        public async Task<EnderecoEmpresaCorrespondenciaModel> AlteraEnderecoCorrespondenciaEmpresa(int idEmpresa, int idEndereco, EnderecoEmpresaCorrespondenciaModel enderecoCorrespondencia)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa) ?? throw new Exception("Empresa não encontrada");
            EnderecoEmpresaCorrespondenciaModel? endereco = empresa.EnderecoCorrespondencia.FirstOrDefault(e => e.Id == idEndereco) ?? throw new Exception("Endereço não encontrado");
            endereco.CEP = enderecoCorrespondencia.CEP;
            endereco.Rua = enderecoCorrespondencia.Rua;
            endereco.Cidade = enderecoCorrespondencia.Cidade;
            endereco.Estado = enderecoCorrespondencia.Estado;
            try
            {
                _dbContext.Entry(empresa).CurrentValues.SetValues(empresa);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return endereco;
        }


        public async Task<EnderecoEmpresaEntregaModel> AlteraEnderecoEntregaEmpresa(int idEmpresa, int idEndereco, EnderecoEmpresaEntregaModel enderecoEntrega)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa) ?? throw new Exception("Empresa não encontrada");
            EnderecoEmpresaEntregaModel? endereco = empresa.EnderecoEntrega.FirstOrDefault(e => e.Id == idEndereco) ?? throw new Exception("Endereço não encontrado");
            endereco.CEP = enderecoEntrega.CEP;
            endereco.Rua = enderecoEntrega.Rua;
            endereco.Cidade = enderecoEntrega.Cidade;
            endereco.Estado = enderecoEntrega.Estado;
            try
            {
                _dbContext.Entry(empresa).CurrentValues.SetValues(empresa);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return endereco;
        }

        public async Task<EnderecoEmpresaFaturamentoModel> AlteraEnderecoFaturamentoEmpresa(int idEmpresa, int idEndereco, EnderecoEmpresaFaturamentoModel enderecoFaturamento)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa) ?? throw new Exception("Empresa não encontrada");
            EnderecoEmpresaFaturamentoModel? endereco = empresa.EnderecoFaturamento.FirstOrDefault(e => e.Id == idEndereco) ?? throw new Exception("Endereço não encontrado");
            endereco.CEP = enderecoFaturamento.CEP;
            endereco.Rua = enderecoFaturamento.Rua;
            endereco.Cidade = enderecoFaturamento.Cidade;
            endereco.Estado = enderecoFaturamento.Estado;
            try
            {
                _dbContext.Entry(empresa).CurrentValues.SetValues(empresa);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return endereco;
        }
        public async Task<EnderecoUsuarioModel> AlteraEnderecoDoUsuario(int IdUsuario, EnderecoUsuarioModel endereco)
        {
            RetornoUsuario usuario = await _usuarioRepositorio.BuscarUsuarioPorId(IdUsuario);
            usuario.Endereco = endereco;
            try
            {
                _dbContext.Entry(usuario).CurrentValues.SetValues(usuario);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return endereco;
        }

        public async Task<EnderecoFornecedor> AlteraEnderecoDoFornecedor(int IdFornecedor, EnderecoFornecedor endereco)
        {
            FornecedorModel fornecedor = await _fornecedorRepositorio.BuscarFornecedorPorId(IdFornecedor);
            fornecedor.Endereco = endereco;
            try
            {
                _dbContext.Entry(fornecedor).CurrentValues.SetValues(fornecedor);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return endereco;
        }

        public async Task<ICollection<EnderecoEmpresaCorrespondenciaModel>> BuscaEnderecoCorrespondenciaEmpresa(int idEmpresa)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            ICollection<EnderecoEmpresaCorrespondenciaModel> enderecoEmpresa = empresa.EnderecoCorrespondencia;
            return enderecoEmpresa;
        }

        public async Task<ICollection<EnderecoEmpresaEntregaModel>> BuscaEnderecoEntregaEmpresa(int idEmpresa)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            ICollection<EnderecoEmpresaEntregaModel> enderecoEmpresa = empresa.EnderecoEntrega;
            return enderecoEmpresa;
        }

        public async Task<ICollection<EnderecoEmpresaFaturamentoModel>> BuscaEnderecoFaturamentoEmpresa(int idEmpresa)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            ICollection<EnderecoEmpresaFaturamentoModel> enderecoEmpresa = empresa.EnderecoFaturamento ?? throw new Exception("Endereço não cadastrado");
            return enderecoEmpresa;
        }

        public async Task<EnderecoUsuarioModel> BuscaEnderecoDoUsuario(int IdUsuario)
        {
            RetornoUsuario usuario = await _usuarioRepositorio.BuscarUsuarioPorId(IdUsuario) ?? throw new Exception("Usuário não encontrado");
            if (usuario.Endereco == null)
            {
                throw new Exception("Endereço não cadastrado");
            }
            EnderecoUsuarioModel enderecoUsuario = usuario.Endereco;
            return enderecoUsuario;
        }

        public async Task<EnderecoFornecedor> BuscaEnderecoDoFornecedor(int IdFornecedor)
        {
            FornecedorModel fornecedor = await _fornecedorRepositorio.BuscarFornecedorPorId(IdFornecedor) ?? throw new Exception("Usuário não encontrado");
            if (fornecedor.Endereco == null)
            {
                throw new Exception("Endereço não cadastrado");
            }
            EnderecoFornecedor enderecoFornecedor = fornecedor.Endereco;
            return enderecoFornecedor;
        }

        public async Task<bool> DeletaEnderecoCorrespondenciaEmpresa(int idEmpresa, int idEmderecoCorrespondencia)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa) ?? throw new Exception("Empresa não encontrada");
            EnderecoEmpresaCorrespondenciaModel? endereco = empresa.EnderecoCorrespondencia.FirstOrDefault(e => e.Id == idEmderecoCorrespondencia) ?? throw new Exception("Endereço não encontrado");
            empresa.EnderecoCorrespondencia.Remove(endereco);
            try
            {
                _dbContext.Entry(empresa).CurrentValues.SetValues(empresa);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return true;
        }

        public async Task<bool> DeletaEnderecoEntregaEmpresa(int idEmpresa, int idEmderecoEntrega)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa) ?? throw new Exception("Empresa não encontrada");
            EnderecoEmpresaEntregaModel? endereco = empresa.EnderecoEntrega.FirstOrDefault(e => e.Id == idEmderecoEntrega) ?? throw new Exception("Endereço não encontrado");
            empresa.EnderecoEntrega.Remove(endereco);
            try
            {
                _dbContext.Entry(empresa).CurrentValues.SetValues(empresa);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return true;
        }

        public async Task<bool> DeletaEnderecoFaturamentoEmpresa(int idEmpresa, int idEmderecoFaturamento)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa) ?? throw new Exception("Empresa não encontrada");
            EnderecoEmpresaFaturamentoModel? endereco = empresa.EnderecoFaturamento.FirstOrDefault(e => e.Id == idEmderecoFaturamento) ?? throw new Exception("Endereço não encontrado");
            empresa.EnderecoFaturamento.Remove(endereco);
            try
            {
                _dbContext.Entry(empresa).CurrentValues.SetValues(empresa);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return true;
        }

        public async Task<bool> DeletaEnderecoUsuario(int idUsuario)
        {
            RetornoUsuario usuario = await _usuarioRepositorio.BuscarUsuarioPorId(idUsuario) ?? throw new Exception("Usuario não encontrada");
            EnderecoUsuarioModel enderecoVazio = new();
            usuario.Endereco = enderecoVazio;
            try
            {
                _dbContext.Entry(usuario).CurrentValues.SetValues(usuario);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return true;
        }

        public async Task<bool> DeletaEnderecoFornecedor(int IdFornecedor)
        {
            FornecedorModel fornecedor = await _fornecedorRepositorio.BuscarFornecedorPorId(IdFornecedor) ?? throw new Exception("Usuário não encontrado");
            EnderecoFornecedor enderecoVazio = new();
            fornecedor.Endereco = enderecoVazio;
            try
            {
                _dbContext.Entry(fornecedor).CurrentValues.SetValues(fornecedor);
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
