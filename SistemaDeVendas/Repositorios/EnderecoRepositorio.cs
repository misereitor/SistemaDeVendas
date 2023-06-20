using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Data;
using SistemaDeVendas.Models.EmpresaModels;
using SistemaDeVendas.Models.GeralModel;
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

        public async Task<EnderecoModel> AdcionarEnderecoCorrespondenciaEmpresa(int idEmpresa, EnderecoModel endereco)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            empresa.EnderecoCorrespondencia.Add(endereco);
            _dbContext.Entry(empresa).CurrentValues.SetValues(empresa);
            await _dbContext.SaveChangesAsync();
            return endereco;
        }

        public async Task<EnderecoModel> AdcionarEnderecoEntregaEmpresa(int idEmpresa, EnderecoModel endereco)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            empresa.EnderecoEntrega.Add(endereco);
            _dbContext.Entry(empresa).CurrentValues.SetValues(empresa);
            await _dbContext.SaveChangesAsync();
            return endereco;
        }

        public async Task<EnderecoModel> AdcionarEnderecoFaturamentoEmpresa(int idEmpresa, EnderecoModel endereco)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            empresa.EnderecoFaturamento.Add(endereco);
            _dbContext.Entry(empresa).CurrentValues.SetValues(empresa);
            await _dbContext.SaveChangesAsync();
            return endereco;
        }

        public async Task<EnderecoModel> AdcionarEnderecoDoUsuario(int IdUsuario, EnderecoModel endereco)
        {
            UsuarioModel usuario = await _usuarioRepositorio.BuscarUsuarioPorId(IdUsuario);
            usuario.Endereco = endereco;
            _dbContext.Entry(usuario).CurrentValues.SetValues(usuario);
            await _dbContext.SaveChangesAsync();
            return endereco;
        }

        public async Task<EnderecoModel> AlteraEnderecoCorrespondenciaEmpresa(int idEmpresa, int idEndereco, EnderecoModel enderecoCorrespondencia)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa) ?? throw new Exception("Empresa não encontrada");
            EnderecoModel? endereco = empresa.EnderecoCorrespondencia.FirstOrDefault(e => e.Id == idEndereco) ?? throw new Exception("Endereço não encontrado");
            endereco.CEP = enderecoCorrespondencia.CEP;
            endereco.Rua = enderecoCorrespondencia.Rua;
            endereco.Cidade = enderecoCorrespondencia.Cidade;
            endereco.Estado = enderecoCorrespondencia.Estado;
            await _dbContext.SaveChangesAsync();
            return endereco;
        }


        public async Task<EnderecoModel> AlteraEnderecoEntregaEmpresa(int idEmpresa, int idEndereco, EnderecoModel enderecoEntrega)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa) ?? throw new Exception("Empresa não encontrada");
            EnderecoModel? endereco = empresa.EnderecoEntrega.FirstOrDefault(e => e.Id == idEndereco) ?? throw new Exception("Endereço não encontrado");
            endereco.CEP = enderecoEntrega.CEP;
            endereco.Rua = enderecoEntrega.Rua;
            endereco.Cidade = enderecoEntrega.Cidade;
            endereco.Estado = enderecoEntrega.Estado;
            await _dbContext.SaveChangesAsync();
            return endereco;
        }

        public async Task<EnderecoModel> AlteraEnderecoFaturamentoEmpresa(int idEmpresa, int idEndereco, EnderecoModel enderecoFaturamento)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa) ?? throw new Exception("Empresa não encontrada");
            EnderecoModel? endereco = empresa.EnderecoFaturamento.FirstOrDefault(e => e.Id == idEndereco) ?? throw new Exception("Endereço não encontrado");
            endereco.CEP = enderecoFaturamento.CEP;
            endereco.Rua = enderecoFaturamento.Rua;
            endereco.Cidade = enderecoFaturamento.Cidade;
            endereco.Estado = enderecoFaturamento.Estado;
            await _dbContext.SaveChangesAsync();
            return endereco;
        }
        public async Task<EnderecoModel> AlteraEnderecoDoUsuario(int IdUsuario, EnderecoModel endereco)
        {
            UsuarioModel usuario = await _usuarioRepositorio.BuscarUsuarioPorId(IdUsuario);
            usuario.Endereco = endereco;
            _dbContext.Entry(usuario).CurrentValues.SetValues(usuario);
            await _dbContext.SaveChangesAsync();
            return endereco;
        }

        public async Task<ICollection<EnderecoModel>> BuscaEnderecoCorrespondenciaEmpresa(int idEmpresa)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            ICollection<EnderecoModel> enderecoEmpresa = empresa.EnderecoCorrespondencia ?? throw new Exception("Endereço não cadastrado");
            return enderecoEmpresa;
        }

        public async Task<ICollection<EnderecoModel>> BuscaEnderecoEntregaEmpresa(int idEmpresa)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            ICollection<EnderecoModel> enderecoEmpresa = empresa.EnderecoEntrega;
            return enderecoEmpresa ?? throw new Exception("Endereço não cadastrado");
        }

        public async Task<ICollection<EnderecoModel>> BuscaEnderecoFaturamentoEmpresa(int idEmpresa)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            ICollection<EnderecoModel> enderecoEmpresa = empresa.EnderecoFaturamento ?? throw new Exception("Endereço não cadastrado");
            return enderecoEmpresa;
        }

        public async Task<EnderecoModel> BuscaEnderecoDoUsuario(int IdUsuario)
        {
            UsuarioModel usuario = await _usuarioRepositorio.BuscarUsuarioPorId(IdUsuario);
            EnderecoModel enderecoUsuario = usuario.Endereco;
            if (usuario == null)
            {
                throw new Exception("Usuário não encontrado");
            }
            return enderecoUsuario;
        }

        public async Task<bool> DeletaEnderecoCorrespondenciaEmpresa(int idEmpresa, int idEmderecoCorrespondencia)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa) ?? throw new Exception("Empresa não encontrada");
            EnderecoModel? endereco = empresa.EnderecoFaturamento.FirstOrDefault(e => e.Id == idEmderecoCorrespondencia) ?? throw new Exception("Endereço não encontrado");
            empresa.EnderecoCorrespondencia.Remove(endereco);
            _dbContext.Entry(empresa).CurrentValues.SetValues(empresa);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeletaEnderecoEntregaEmpresa(int idEmpresa, int idEmderecoEntrega)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa) ?? throw new Exception("Empresa não encontrada");
            EnderecoModel? endereco = empresa.EnderecoEntrega.FirstOrDefault(e => e.Id == idEmderecoEntrega) ?? throw new Exception("Endereço não encontrado");
            empresa.EnderecoEntrega.Remove(endereco);
            _dbContext.Entry(empresa).CurrentValues.SetValues(empresa);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeletaEnderecoFaturamentoEmpresa(int idEmpresa, int idEmderecoFaturamento)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa) ?? throw new Exception("Empresa não encontrada");
            EnderecoModel? endereco = empresa.EnderecoFaturamento.FirstOrDefault(e => e.Id == idEmderecoFaturamento) ?? throw new Exception("Endereço não encontrado");
            empresa.EnderecoFaturamento.Remove(endereco);
            _dbContext.Entry(empresa).CurrentValues.SetValues(empresa);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeletaEnderecoUsuario(int idUsuario)
        {
            UsuarioModel usuario = await _usuarioRepositorio.BuscarUsuarioPorId(idUsuario) ?? throw new Exception("Usuario não encontrada");
            EnderecoModel enderecoVazio = new();
            usuario.Endereco = enderecoVazio;
            _dbContext.Entry(usuario).CurrentValues.SetValues(usuario);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
