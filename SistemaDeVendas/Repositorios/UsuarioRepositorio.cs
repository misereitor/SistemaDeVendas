using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Data;
using SistemaDeVendas.Models.RepositorioModel;
using SistemaDeVendas.Models.RequestModels;
using SistemaDeVendas.Models.UsuariosModels;
using SistemaDeVendas.Repositorios.Interfaces.InterfaceUsuario;
using SistemaDeVendas.Services;
using SistemaDeVendas.TratamentoDeErros;
using SistemaDeVendas.Validacoes;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace SistemaDeVendas.Repositorios
{
    public class UsuarioRepositorio : IUsuariosRepositorio
    {
        private readonly ConexaoDBContext _dbContext;
        private readonly UsuarioModelValidador _validador;
        private readonly ValidacoesServices _validacoesServices;

        public UsuarioRepositorio(ConexaoDBContext dbContext, UsuarioModelValidador validador, ValidacoesServices validacoesServices)
        {
            _dbContext = dbContext;
            _validador = validador;
            _validacoesServices = validacoesServices;
        }

        public async Task<List<RetornoUsuario>> BuscarTodosOsUsuarios()
        {
            List<UsuarioModel> listaDeUsuarios;
            List<RetornoUsuario> retornoUsuario = new();
            
            try
            {
                listaDeUsuarios = await _dbContext.Usuarios.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            foreach (UsuarioModel usuario in listaDeUsuarios)
            {
                RetornoUsuario _retornoUsuario = new();
                var transformar = new TransformarObjetos<UsuarioModel, RetornoUsuario>();
                retornoUsuario.Add(transformar.ObjetosTransoformar(usuario, _retornoUsuario));
            }
            return retornoUsuario;
        }

        public async Task<RetornoUsuario> BuscarUsuarioPorId(int id)
        {
            UsuarioModel? usuarioPorId = null;
            try
            {
                usuarioPorId = await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            if (usuarioPorId == null)
            {
                throw new ErrosException(404, "Usuário não encontrado");
            }
            RetornoUsuario _retornoUsuario = new();
            var transformar = new TransformarObjetos<UsuarioModel, RetornoUsuario>();
            RetornoUsuario retornoUsuario = transformar.ObjetosTransoformar(usuarioPorId, _retornoUsuario);
            return retornoUsuario;
        }
        public async Task<UsuarioModel> BuscarUsuarioId(int id)
        {
            UsuarioModel? usuarioPorId = null;
            try
            {
                usuarioPorId = await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
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
            string senhaCriptografada;
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytesSenha = Encoding.UTF8.GetBytes(usuario.Senha); // Converte a senha em um array de bytes
                byte[] hashBytes = sha256.ComputeHash(bytesSenha); // Calcula o hash da senha

                // Converte o hash em uma string hexadecimal
                StringBuilder builder = new();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                senhaCriptografada = builder.ToString();
            }
            usuario.Usuario = usuario.Usuario.ToLower();
            usuario.Senha = senhaCriptografada;
            try
            {
                await _dbContext.AddAsync(usuario);
                await _dbContext.SaveChangesAsync();
            }catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return usuario;
        }

        public async Task<RetornoUsuario> AlterarUsuario(AlteradorUsuario usuario, int id)
        {
            UsuarioModel usuarioPorId = await BuscarUsuarioId(id) ?? throw new ErrosException(404, $"Usuário com ID: {id} não foi encontrado!");

            var properties = typeof(AlteradorUsuario).GetProperties();

            foreach (var property in properties)
            {
                var value = property.GetValue(usuario);

                if (value != null && !string.IsNullOrEmpty(value.ToString()))
                {
                    var usuarioProperty = usuarioPorId.GetType().GetProperty(property.Name);
                    usuarioProperty?.SetValue(usuarioPorId, value);
                }
            }
            try
            {
                _dbContext.Entry(usuarioPorId).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
            }catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }

            RetornoUsuario _retornoUsuario = new();
            var transformar = new TransformarObjetos<UsuarioModel, RetornoUsuario>();
            RetornoUsuario retornoUsuario = transformar.ObjetosTransoformar(usuarioPorId, _retornoUsuario);

            return retornoUsuario;
        }


        public async Task<bool> DeletarUsuario(int id)
        {
            UsuarioModel usuarioPorId = await BuscarUsuarioId(id);
            try
            {
                if (usuarioPorId != null)
                {
                    _dbContext.Usuarios.Remove(usuarioPorId);
                    await _dbContext.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            throw new ErrosException(404, $"Usuario do ID: {id} não foi encontrado!");
        }

        public async Task<bool> AlterarSenha(SenhaRequest senha, int id)
        {
            UsuarioModel usuarioPorId = await BuscarUsuarioId(id) ?? throw new ErrosException(404, $"Usuário com ID: {id} não foi encontrado!");
            if (!_validacoesServices.ValidarSenha(senha.Senha))
            {
                return false;
            }
            string senhaCriptografada;
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytesSenha = Encoding.UTF8.GetBytes(senha.Senha); // Converte a senha em um array de bytes
                byte[] hashBytes = sha256.ComputeHash(bytesSenha); // Calcula o hash da senha

                // Converte o hash em uma string hexadecimal
                StringBuilder builder = new();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                senhaCriptografada = builder.ToString();
            }
            usuarioPorId.Senha = senhaCriptografada;
            try
            {
                _dbContext.Entry(usuarioPorId).State = EntityState.Modified;
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
