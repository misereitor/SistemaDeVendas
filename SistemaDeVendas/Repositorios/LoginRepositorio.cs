using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Data;
using SistemaDeVendas.Models.UsuariosModels;
using SistemaDeVendas.Repositorios.Interfaces;
using SistemaDeVendas.TratamentoDeErros;

namespace SistemaDeVendas.Repositorios
{
    public class LoginRepositorio : ILoginRepositorio
    {

        private readonly ConexaoDBContext _dbContext;

        public LoginRepositorio(ConexaoDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<UsuarioModel> BuscaUsuarioPorUsuarioESenha(string usuario, string senha)
        {
            UsuarioModel? user = new();
            try
            {
                user = await _dbContext.Usuarios.FirstOrDefaultAsync(u => u.Usuario == usuario && u.Senha == senha);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro de SQL: " + ex.Message);
                throw;
            }
            if (user == null)
            {
                throw new ErrosException(404, "Usuário e/ou senha inválidos");
            }
            return user;
        }
    }
}
