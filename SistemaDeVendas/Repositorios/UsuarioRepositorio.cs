using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Data;
using SistemaDeVendas.Models.UsuariosModels;
using SistemaDeVendas.Repositorios.Interfaces;

namespace SistemaDeVendas.Repositorios
{
    public class UsuarioRepositorio : IUsuariosRepositorio
    {
        private readonly ConexaoDBContext _dbContext;

        public UsuarioRepositorio(ConexaoDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<UsuarioModel>> BuscarTodosOsUsuarios()
        {
            List<UsuarioModel> listaDeUsuarios = new List<UsuarioModel>();
            try
            {
                listaDeUsuarios = await  _dbContext.UsuarioModels.ToListAsync();
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Erro de SQL: " + ex.Message);
            }
            return listaDeUsuarios;
        }

        public async Task<UsuarioModel> BuscaUsuarioPorEmailESenha(string email, string senha)
        {
            UsuarioModel? usuario = new UsuarioModel();
            try
            {
                usuario = await _dbContext.UsuarioModels.FirstOrDefaultAsync(u => u.Email == email && u.Senha == senha);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro de SQL: " + ex.Message);
            }
            if (usuario == null)
            {
                throw new Exception("Usuário não encontrado");
            }
            return usuario;
        }
        public async Task<UsuarioModel> BuscarUsuarioPorId(int id)
        {
            UsuarioModel? usuarioPorId = null;
            try
            {
                usuarioPorId = await _dbContext.UsuarioModels.FirstOrDefaultAsync(x => x.Id == id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro de SQL: " + ex.Message);
            }
            if (usuarioPorId == null)
            {
                throw new Exception("Usuário não encontrado");
            }
            return usuarioPorId;
        }
        public async Task<UsuarioModel> CriarUsuario(UsuarioModel usuario)
        {
            try
            {
                await _dbContext.AddAsync(usuario);
                await _dbContext.SaveChangesAsync();
            }catch (Exception ex)
            {
                Console.WriteLine("Erro de SQL: " + ex.Message);
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
                _dbContext.UsuarioModels.Remove(usuarioPorId);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            throw new Exception($"Usuario do ID: {id} não foi encontrado!");
        }
    }
}
