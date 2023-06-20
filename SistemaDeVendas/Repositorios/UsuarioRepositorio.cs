using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Data;
using SistemaDeVendas.Models.UsuariosModels;
using SistemaDeVendas.Repositorios.Interfaces;
using SistemaDeVendas.TratamentoDeErros;
using SistemaDeVendas.Validacoes;
using System.Net;

namespace SistemaDeVendas.Repositorios
{
    public class UsuarioRepositorio : IUsuariosRepositorio
    {
        private readonly ConexaoDBContext _dbContext;
        private readonly UsuarioModelValidador _validador;

        public UsuarioRepositorio(ConexaoDBContext dbContext, UsuarioModelValidador validador)
        {
            _dbContext = dbContext;
            _validador= validador;
        }

        public async Task<List<UsuarioModel>> BuscarTodosOsUsuarios()
        {
            List<UsuarioModel> listaDeUsuarios;
            try
            {
                listaDeUsuarios = await _dbContext.Usuarios.ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro de SQL: " + ex.Message);
                throw;
            }
            return listaDeUsuarios;
        }
        public async Task<UsuarioModel> BuscarUsuarioPorId(int id)
        {
            UsuarioModel? usuarioPorId = null;
            try
            {
                usuarioPorId = await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro de SQL: " + ex.Message);
            }
            if (usuarioPorId == null)
            {
                throw new ErrosException(404, "Usuário não encontrado");
            }
            return usuarioPorId;
        }
        public async Task<UsuarioModel> CriarUsuario(UsuarioModel usuario)
        {
            var validationResult = await _validador.ValidateAsync(usuario);
            if (!validationResult.IsValid)
            {
                string errors = string.Join(", ", validationResult.Errors.Select(e => e.ErrorMessage));
                throw new ErrosException(409, errors);
            }
            try
            {
                await _dbContext.AddAsync(usuario);
                await _dbContext.SaveChangesAsync();
            }catch (Exception ex)
            {
                Console.WriteLine("Erro de SQL: " + ex.Message);
                throw;
            }
            return usuario;
        }

        public async Task<UsuarioModel> AlterarUsuario(UsuarioModel usuario, int id)
        {
            UsuarioModel usuarioPorId = await BuscarUsuarioPorId(id) ?? throw new Exception($"Usuario do ID: {id} não foi encontrado!");
            _dbContext.Entry(usuarioPorId).CurrentValues.SetValues(usuario);
            await _dbContext.SaveChangesAsync();
            return usuarioPorId;
        }


        public async Task<bool> DeletarUsuario(int id)
        {
            UsuarioModel usuarioPorId = await BuscarUsuarioPorId(id);
            if (usuarioPorId != null)
            {
                _dbContext.Usuarios.Remove(usuarioPorId);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            throw new Exception($"Usuario do ID: {id} não foi encontrado!");
        }
    }
}
