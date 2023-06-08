using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Data;
using SistemaDeVendas.Models.EmpresaModels;
using SistemaDeVendas.Models.GeralModel;
using SistemaDeVendas.Models.UsuariosModels;
using SistemaDeVendas.Repositorios.Interfaces;

namespace SistemaDeVendas.Repositorios
{
    public class EnderecoRepositorio : IEnderecoRepositorio
    {
        private readonly ConexaoDBContext _dbContext;
        private readonly EmpresaRepositorio _empresaRepositorio;
        private readonly UsuarioRepositorio _usuarioRepositorio;

        public EnderecoRepositorio(ConexaoDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<EnderecoModel> AdcionarEnderecoCorrespondenciaEmpresa(int idEmpresa, EnderecoModel endereco)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            if (empresa == null) 
            {
                throw new Exception("Endereço não cadastrado");
            }
            empresa.EnderecoCorrespondencia.Add(endereco);
            _dbContext.Entry(empresa).CurrentValues.SetValues(empresa);
            await _dbContext.SaveChangesAsync();
            return endereco;
        }

        public async Task<EnderecoModel> AdcionarEnderecoEntregaEmpresa(int idEmpresa, EnderecoModel endereco)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            if (empresa == null)
            {
                throw new Exception("Endereço não cadastrado");
            }
            empresa.EnderecoEntrega.Add(endereco);
            _dbContext.Entry(empresa).CurrentValues.SetValues(empresa);
            await _dbContext.SaveChangesAsync();
            return endereco;
        }

        public async Task<EnderecoModel> AdcionarEnderecoFaturamentoEmpresa(int idEmpresa, EnderecoModel endereco)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            if (empresa == null)
            {
                throw new Exception("Endereço não cadastrado");
            }
            empresa.EnderecoFaturamento.Add(endereco);
            _dbContext.Entry(empresa).CurrentValues.SetValues(empresa);
            await _dbContext.SaveChangesAsync();
            return endereco;
        }

        public async Task<EnderecoModel> AdcionarEnderecoDoUsuario(int IdUsuario, EnderecoModel endereco)
        {
            UsuarioModel usuario = await _usuarioRepositorio.BuscarUsuarioPorId(IdUsuario);
            if (usuario == null)
            {
                throw new Exception("Usuario não cadastrado");
            }
            usuario.Endereco = endereco;
            _dbContext.Entry(usuario).CurrentValues.SetValues(usuario);
            await _dbContext.SaveChangesAsync();
            return endereco;
        }

        public async Task<EnderecoModel> AlteraEnderecoCorrespondenciaEmpresa(int idEmpresa, int idEndereco, EnderecoModel enderecoCorrespondencia)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            if (empresa == null)
            {
                throw new Exception("Empresa não encontrada");
            }
            EnderecoModel? endereco = empresa.EnderecoCorrespondencia.FirstOrDefault(e => e.Id == idEndereco);
            if (endereco == null)
            {
                throw new Exception("Endereço não encontrado");
            }
            endereco.CEP = enderecoCorrespondencia.CEP;
            endereco.Rua = enderecoCorrespondencia.Rua;
            endereco.Cidade = enderecoCorrespondencia.Cidade;
            endereco.Estado = enderecoCorrespondencia.Estado;
            await _dbContext.SaveChangesAsync();
            return endereco;
        }


        public async Task<EnderecoModel> AlteraEnderecoEntregaEmpresa(int idEmpresa, int idEndereco, EnderecoModel enderecoEntrega)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            if (empresa == null)
            {
                throw new Exception("Empresa não encontrada");
            }
            EnderecoModel? endereco = empresa.EnderecoEntrega.FirstOrDefault(e => e.Id == idEndereco);
            if (endereco == null)
            {
                throw new Exception("Endereço não encontrado");
            }
            endereco.CEP = enderecoEntrega.CEP;
            endereco.Rua = enderecoEntrega.Rua;
            endereco.Cidade = enderecoEntrega.Cidade;
            endereco.Estado = enderecoEntrega.Estado;
            await _dbContext.SaveChangesAsync();
            return endereco;
        }

        public async Task<EnderecoModel> AlteraEnderecoFaturamentoEmpresa(int idEmpresa, int idEndereco, EnderecoModel enderecoFaturamento)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            if (empresa == null)
            {
                throw new Exception("Empresa não encontrada");
            }
            EnderecoModel? endereco = empresa.EnderecoFaturamento.FirstOrDefault(e => e.Id == idEndereco);
            if (endereco == null)
            {
                throw new Exception("Endereço não encontrado");
            }
            endereco.CEP = enderecoFaturamento.CEP;
            endereco.Rua = enderecoFaturamento.Rua;
            endereco.Cidade = enderecoFaturamento.Cidade;
            endereco.Estado = enderecoFaturamento.Estado;
            await _dbContext.SaveChangesAsync();
            return endereco;
        }
        public async Task<EnderecoModel> AlteraEnderecoDoUsuario(int IdUsuario, int idEndereco, EnderecoModel endereco)
        {
            UsuarioModel usuario = await _usuarioRepositorio.BuscarUsuarioPorId(IdUsuario);
            if (usuario == null)
            {
                throw new Exception("Usuario não cadastrado");
            }
            usuario.Endereco = endereco;
            _dbContext.Entry(usuario).CurrentValues.SetValues(usuario);
            await _dbContext.SaveChangesAsync();
            return endereco;
        }

        public async Task<ICollection<EnderecoModel>> BuscaEnderecoCorrespondenciaEmpresa(int idEmpresa)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            ICollection<EnderecoModel> enderecoEmpresa = empresa.EnderecoCorrespondencia;
            if (enderecoEmpresa == null)
            {
                throw new Exception("Endereço não cadastrado");
            }
            return enderecoEmpresa;
        }

        public async Task<ICollection<EnderecoModel>> BuscaEnderecoEntregaEmpresa(int idEmpresa)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            ICollection<EnderecoModel> enderecoEmpresa = empresa.EnderecoEntrega;
            if (enderecoEmpresa == null)
            {
                throw new Exception("Endereço não cadastrado");
            }
            return enderecoEmpresa;
        }

        public async Task<ICollection<EnderecoModel>> BuscaEnderecoFaturamentoEmpresa(int idEmpresa)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            ICollection<EnderecoModel> enderecoEmpresa = empresa.EnderecoFaturamento;
            if (enderecoEmpresa == null)
            {
                throw new Exception("Endereço não cadastrado");
            }
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
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            if (empresa == null)
            {
                throw new Exception("Empresa não encontrada");
            }
            EnderecoModel? endereco = empresa.EnderecoFaturamento.FirstOrDefault(e => e.Id == idEmderecoCorrespondencia);
            if (endereco == null)
            {
                throw new Exception("Endereço não encontrado");
            }
            empresa.EnderecoCorrespondencia.Remove(endereco);
            _dbContext.Entry(empresa).CurrentValues.SetValues(empresa);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeletaEnderecoEntregaEmpresa(int idEmpresa, int idEmderecoEntrega)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            if (empresa == null)
            {
                throw new Exception("Empresa não encontrada");
            }
            EnderecoModel? endereco = empresa.EnderecoEntrega.FirstOrDefault(e => e.Id == idEmderecoEntrega);
            if (endereco == null)
            {
                throw new Exception("Endereço não encontrado");
            }
            empresa.EnderecoEntrega.Remove(endereco);
            _dbContext.Entry(empresa).CurrentValues.SetValues(empresa);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeletaEnderecoFaturamentoEmpresa(int idEmpresa, int idEmderecoFaturamento)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            if (empresa == null)
            {
                throw new Exception("Empresa não encontrada");
            }
            EnderecoModel? endereco = empresa.EnderecoFaturamento.FirstOrDefault(e => e.Id == idEmderecoFaturamento);
            if (endereco == null)
            {
                throw new Exception("Endereço não encontrado");
            }
            empresa.EnderecoFaturamento.Remove(endereco);
            _dbContext.Entry(empresa).CurrentValues.SetValues(empresa);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
