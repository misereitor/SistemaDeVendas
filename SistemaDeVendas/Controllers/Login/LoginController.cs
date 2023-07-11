using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaDeVendas.Models.LoginModel;
using SistemaDeVendas.Models.UsuariosModels;
using SistemaDeVendas.Repositorios;
using SistemaDeVendas.Repositorios.Interfaces.InterfaceLogin;
using SistemaDeVendas.Services;

namespace SistemaDeVendas.Controllers.Login
{
    [ApiController]
    [Route("v1")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepositorio _loginRepositorio;

        public LoginController(ILoginRepositorio loginRepositorio)
        {
            _loginRepositorio = loginRepositorio;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult<dynamic>> AuthenticateAsync([FromBody] LoginRequest loginRequest)
        {
            UsuarioModel user = await _loginRepositorio.BuscaUsuarioPorUsuarioESenha(loginRequest.Usuario, loginRequest.Senha);

            var token = TokenService.GerarToken(user);
            user.Senha = "";
            return new
            {
                user.Id,
                user.Nome,
                Token = token
            };
        } 
    }
}