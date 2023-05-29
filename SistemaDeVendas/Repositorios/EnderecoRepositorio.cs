using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Data;
using SistemaDeVendas.Models;
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
        public async Task<EnderecoModel> BuscaEnderecoCorrespondenciaEmpresa(int idEmpresa)
        {
            EmpresaModel? empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            EnderecoModel? enderecoEmpresa = empresa.EnderecoCorrespondencia;
            if (enderecoEmpresa == null)
            {
                throw new Exception("Endereço não cadastrado");
            }
            return enderecoEmpresa;
        }
        public async Task<EnderecoModel> BuscaEnderecoEntregaEmpresa(int idEmpresa)
        {
            EmpresaModel? empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            EnderecoModel? enderecoEmpresa = empresa.EnderecoEntrega;
            if (enderecoEmpresa == null)
            {
                throw new Exception("Endereço não cadastrado");
            }
            return enderecoEmpresa;

        }
        public async Task<EnderecoModel> BuscaEnderecoFaturamentoEmpresa(int idEmpresa)
        {
            EmpresaModel? empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            EnderecoModel? enderecoEmpresa = empresa.EnderecoFaturamento;
            if (enderecoEmpresa == null)
            {
                throw new Exception("Endereço não cadastrado");
            }
            return enderecoEmpresa;

        }
        public async Task<EnderecoModel> BuscaEnderecoDoUsuario(int IdUsuario)
        {
            UsuarioModel usuario = await _usuarioRepositorio.BuscarUsuarioPorId(IdUsuario);
            if (usuario == null)
            {
                throw new Exception("Usuário não encontrado");
            }
            EnderecoModel enderecoUsuario = usuario.Endereco;
            return enderecoUsuario;
        }
        public async Task<EnderecoModel> AlteraEnderecoCorrespondenciaEmpresa(int idEmpresa, EnderecoModel enderecoCorrespondencia)
        {
            EmpresaModel? empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            empresa.EnderecoCorrespondencia = enderecoCorrespondencia;
            try
            {
                _dbContext.Entry(empresa).CurrentValues.SetValues(empresa);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro de SQL: " + ex.Message);
            }
            return enderecoCorrespondencia;
        }

        public async Task<EnderecoModel> AlteraEnderecoEntregaEmpresa(int idEmpresa, EnderecoModel enderecoEntrega)
        {
            EmpresaModel? empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            empresa.EnderecoEntrega = enderecoEntrega;
            try
            {
                _dbContext.Entry(empresa).CurrentValues.SetValues(empresa);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro de SQL: " + ex.Message);
            }
            return enderecoEntrega;
        }

        public async Task<EnderecoModel> AlteraEnderecoFaturamentoEmpresa(int idEmpresa, EnderecoModel enderecoFaturamento)
        {
            EmpresaModel? empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);
            empresa.EnderecoFaturamento = enderecoFaturamento;
            try
            {
                _dbContext.Entry(empresa).CurrentValues.SetValues(empresa);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro de SQL: " + ex.Message);
            }
            return enderecoFaturamento;
        }

        public async Task<EnderecoModel> AlteraEnderecoDoUsuario(int IdUsuario, EnderecoModel endereco)
        {
            UsuarioModel usuario = await _usuarioRepositorio.BuscarUsuarioPorId(IdUsuario);
            usuario.Endereco = endereco;
            try
            {
                _dbContext.Entry(usuario).CurrentValues.SetValues(usuario);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro de SQL: " + ex.Message);
            }
            return endereco;
        }

        public async Task<bool> DeletaEnderecoCorrespondenciaEmpresa(int idEmpresa, int idEmderecoCorrespondencia)
        {
            try
            {
                listaDeUsuarios = await _dbContext.UsuarioModels.ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro de SQL: " + ex.Message);
            }
        }

        public async Task<bool> DeletaEnderecoEntregaEmpresa(int idEmpresa, int idEmderecoEntrega)
        {
            try
            {
                listaDeUsuarios = await _dbContext.UsuarioModels.ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro de SQL: " + ex.Message);
            }
        }

        public async Task<bool> DeletaEnderecoFaturamentoEmpresa(int idEmpresa, int idEmderecoFaturamento)
        {
            EmpresaModel? empresa = await _empresaRepositorio.BuscarEmpresaPorId(idEmpresa);

            try
            {
                _dbContext.Entry(empresa).CurrentValues.SetValues("");
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro de SQL: " + ex.Message);
            }
            return true;
        }

        public async Task<bool> DeletarEnderecoDoUsuario(int IdUsuario, EnderecoModel endereco)
        {
            UsuarioModel usuario = await _usuarioRepositorio.BuscarUsuarioPorId(IdUsuario);
            if (usuario == null)
            {
                return false; // Usuário não encontrado
            }
            EnderecoModel enderecoExistente = await _dbContext.EnderacoModel.FirstOrDefaultAsync(e => e.Id == endereco.Id && e.UsuarioId == IdUsuario);
            if (enderecoExistente == null)
            {
                return false; // Endereço não encontrado ou não está associado ao usuário
            }
            try
            {
                _dbContext.Entry(usuario).CurrentValues.SetValues("");
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro de SQL: " + ex.Message);
            }
            return true;
        }
    }
}
