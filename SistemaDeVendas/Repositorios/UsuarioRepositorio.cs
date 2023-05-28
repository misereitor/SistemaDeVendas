using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Data;
using SistemaDeVendas.Models;
using SistemaDeVendas.Repositorios.Interfaces;

namespace SistemaDeVendas.Repositorios
{
    public class UsuarioRepositorio : IUsuariosRepositorio
    {
        private readonly ConexaoDBContex _dbContext = new ConexaoDBContex();

        public async Task<List<UsuarioModel>> BuscarTodosOsUsuarios()
        {
            List<UsuarioModel> listaDeUsuarios = new List<UsuarioModel>();
            try
            {
                listaDeUsuarios = await  _dbContext.usuarioModels.ToListAsync();
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Erro de SQL: " + ex.Message);
            }
            return listaDeUsuarios;
        }

        public async Task<UsuarioModel> BuscarUsuarioPorId(int id)
        {
            UsuarioModel? usuarioPorId = null;
            try
            {
                usuarioPorId = await _dbContext.usuarioModels.FirstOrDefaultAsync(x => x.Id == id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro de SQL: " + ex.Message);
            }
            if (usuarioPorId == null)
            {
                throw new Exception("Usuário não encontrado"); // Ou retorne um valor padrão, como null ou um usuário "vazio"
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
            UsuarioModel usuarioPorId = await BuscarUsuarioPorId(id);
            if (usuarioPorId == null)
            {
                throw new Exception($"Usuario do ID: {id} não foi encontrado!");
            }
            usuarioPorId = usuario;
            _dbContext.usuarioModels.Update(usuarioPorId);
            await _dbContext.SaveChangesAsync();
            return usuarioPorId;
        }


        public async Task<bool> DeletarUsuario(int id)
        {
            UsuarioModel usuarioPorId = await BuscarUsuarioPorId(id);
            if (usuarioPorId == null)
            {
                throw new Exception($"Usuario do ID: {id} não foi encontrado!");
            }
            _dbContext.usuarioModels.Remove(usuarioPorId);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
