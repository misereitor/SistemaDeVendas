using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
            string senhaCriptografadaFornecida;
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytesSenha = Encoding.UTF8.GetBytes(senha); // Converte a senha fornecida em um array de bytes
                byte[] hashBytes = sha256.ComputeHash(bytesSenha); // Calcula o hash da senha fornecida

                // Converte o hash em uma string hexadecimal
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                senhaCriptografadaFornecida = builder.ToString();
            }
            try
            {
                Console.WriteLine(senhaCriptografadaFornecida);
                user = await _dbContext.Usuarios.FirstOrDefaultAsync(u => u.Usuario.ToLower() == usuario && u.Senha == senhaCriptografadaFornecida);
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
