using Microsoft.AspNetCore.Mvc;
using SistemaDeVendas.Models.UsuariosModels;
using SistemaDeVendas.Repositorios;
using SistemaDeVendas.Repositorios.Interfaces;
using SistemaDeVendas.Services;

namespace SistemaDeVendas.Controllers
{
    [ApiController]
    [Route("v1")]
    public class LoginController : ControllerBase
    {
        private readonly UsuarioRepositorio _usuarioRepositorio;

        public LoginController(UsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<dynamic>> AuthenticateAsync([FromBody] UsuarioModel usuario)
        {
            UsuarioModel user = await _usuarioRepositorio.BuscaUsuarioPorEmailESenha(usuario.Email, usuario.Senha);

            if (user == null)
            {
                return NotFound("Usuario e/ou senha invalidos");
            }

            var token = TokenService.GerarToken(user);
            user.Senha = "";
            return new
            {
                user.Id,
                user.Nome,
                user.Email,
                Token = token
            };
        }
    }
}
