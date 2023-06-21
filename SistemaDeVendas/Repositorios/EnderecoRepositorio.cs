using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Data;
using SistemaDeVendas.Models.EmpresaModels;
using SistemaDeVendas.Models.GeralModels.EnderecoModel;
using SistemaDeVendas.Models.UsuariosModels;
using SistemaDeVendas.Repositorios.Interfaces;
using SistemaDeVendas.TratamentoDeErros;

namespace SistemaDeVendas.Repositorios
{
    public class EnderecoRepositorio : IEnderecoRepositorio
    {
        private readonly ConexaoDBContext _dbContext;
        private readonly IEmpresaRepositorio _empresaRepositorio;
        private readonly IUsuariosRepositorio _usuarioRepositorio;

        public EnderecoRepositorio(ConexaoDBContext dbContext, IEmpresaRepositorio empresaRepositorio, IUsuariosRepositorio usuarioRepositorio)
        {
            _dbContext = dbContext;
            _empresaRepositorio = empresaRepositorio;
            _usuarioRepositorio = usuarioRepositorio;
        }

        public async Task<EnderecoEmpresaCorrespondenciaModel> AdcionarEnderecoCorrespondenciaEmpresa(int idEmpresa, EnderecoEmpresaCorrespondenciaModel endereco)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            empresa.EnderecoCorrespondencia.Add(endereco);
            _dbContext.Entry(empresa).CurrentValues.SetValues(empresa);
            await _dbContext.SaveChangesAsync();
            return endereco;
        }

        public async Task<EnderecoEmpresaEntregaModel> AdcionarEnderecoEntregaEmpresa(int idEmpresa, EnderecoEmpresaEntregaModel endereco)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            empresa.EnderecoEntrega.Add(endereco);
            _dbContext.Entry(empresa).CurrentValues.SetValues(empresa);
            await _dbContext.SaveChangesAsync();
            return endereco;
        }

        public async Task<EnderecoEmpresaFaturamentoModel> AdcionarEnderecoFaturamentoEmpresa(int idEmpresa, EnderecoEmpresaFaturamentoModel endereco)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            empresa.EnderecoFaturamento.Add(endereco);
            _dbContext.Entry(empresa).CurrentValues.SetValues(empresa);
            await _dbContext.SaveChangesAsync();
            return endereco;
        }

        public async Task<EnderecoUsuarioModel> AdcionarEnderecoDoUsuario(int IdUsuario, EnderecoUsuarioModel endereco)
        {
            UsuarioModel usuario = await _usuarioRepositorio.BuscarUsuarioPorId(IdUsuario);
            usuario.Endereco = endereco;
            _dbContext.Entry(usuario).CurrentValues.SetValues(usuario);
            await _dbContext.SaveChangesAsync();
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
            await _dbContext.SaveChangesAsync();
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
            await _dbContext.SaveChangesAsync();
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
            await _dbContext.SaveChangesAsync();
            return endereco;
        }
        public async Task<EnderecoUsuarioModel> AlteraEnderecoDoUsuario(int IdUsuario, EnderecoUsuarioModel endereco)
        {
            UsuarioModel usuario = await _usuarioRepositorio.BuscarUsuarioPorId(IdUsuario);
            usuario.Endereco = endereco;
            _dbContext.Entry(usuario).CurrentValues.SetValues(usuario);
            await _dbContext.SaveChangesAsync();
            return endereco;
        }

        public async Task<ICollection<EnderecoEmpresaCorrespondenciaModel>> BuscaEnderecoCorrespondenciaEmpresa(int idEmpresa)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            ICollection<EnderecoEmpresaCorrespondenciaModel> enderecoEmpresa = empresa.EnderecoCorrespondencia ?? throw new Exception("Endereço não cadastrado");
            return enderecoEmpresa;
        }

        public async Task<ICollection<EnderecoEmpresaEntregaModel>> BuscaEnderecoEntregaEmpresa(int idEmpresa)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            ICollection<EnderecoEmpresaEntregaModel> enderecoEmpresa = empresa.EnderecoEntrega;
            return enderecoEmpresa ?? throw new Exception("Endereço não cadastrado");
        }

        public async Task<ICollection<EnderecoEmpresaFaturamentoModel>> BuscaEnderecoFaturamentoEmpresa(int idEmpresa)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            ICollection<EnderecoEmpresaFaturamentoModel> enderecoEmpresa = empresa.EnderecoFaturamento ?? throw new Exception("Endereço não cadastrado");
            return enderecoEmpresa;
        }

        public async Task<EnderecoUsuarioModel> BuscaEnderecoDoUsuario(int IdUsuario)
        {
            UsuarioModel usuario = await _usuarioRepositorio.BuscarUsuarioPorId(IdUsuario);
            EnderecoUsuarioModel enderecoUsuario = usuario.Endereco;
            if (usuario == null)
            {
                throw new Exception("Usuário não encontrado");
            }
            return enderecoUsuario;
        }

        public async Task<bool> DeletaEnderecoCorrespondenciaEmpresa(int idEmpresa, int idEmderecoCorrespondencia)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa) ?? throw new Exception("Empresa não encontrada");
            EnderecoEmpresaCorrespondenciaModel? endereco = empresa.EnderecoCorrespondencia.FirstOrDefault(e => e.Id == idEmderecoCorrespondencia) ?? throw new Exception("Endereço não encontrado");
            empresa.EnderecoCorrespondencia.Remove(endereco);
            _dbContext.Entry(empresa).CurrentValues.SetValues(empresa);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeletaEnderecoEntregaEmpresa(int idEmpresa, int idEmderecoEntrega)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa) ?? throw new Exception("Empresa não encontrada");
            EnderecoEmpresaEntregaModel? endereco = empresa.EnderecoEntrega.FirstOrDefault(e => e.Id == idEmderecoEntrega) ?? throw new Exception("Endereço não encontrado");
            empresa.EnderecoEntrega.Remove(endereco);
            _dbContext.Entry(empresa).CurrentValues.SetValues(empresa);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeletaEnderecoFaturamentoEmpresa(int idEmpresa, int idEmderecoFaturamento)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa) ?? throw new Exception("Empresa não encontrada");
            EnderecoEmpresaFaturamentoModel? endereco = empresa.EnderecoFaturamento.FirstOrDefault(e => e.Id == idEmderecoFaturamento) ?? throw new Exception("Endereço não encontrado");
            empresa.EnderecoFaturamento.Remove(endereco);
            _dbContext.Entry(empresa).CurrentValues.SetValues(empresa);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeletaEnderecoUsuario(int idUsuario)
        {
            UsuarioModel usuario = await _usuarioRepositorio.BuscarUsuarioPorId(idUsuario) ?? throw new Exception("Usuario não encontrada");
            EnderecoUsuarioModel enderecoVazio = new();
            usuario.Endereco = enderecoVazio;
            _dbContext.Entry(usuario).CurrentValues.SetValues(usuario);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
