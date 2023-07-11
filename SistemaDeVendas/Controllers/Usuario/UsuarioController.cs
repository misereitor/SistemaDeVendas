using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeVendas.Models.RepositorioModel;
using SistemaDeVendas.Models.RequestModels;
using SistemaDeVendas.Models.UsuariosModels;
using SistemaDeVendas.Repositorios;
using SistemaDeVendas.Repositorios.Interfaces.InterfaceUsuario;
using SistemaDeVendas.Validacoes;

namespace SistemaDeVendas.Controllers.Usuario
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuariosRepositorio _usuariosRepositorio;
        public UsuarioController(IUsuariosRepositorio usuariosRepositorio)
        {
            _usuariosRepositorio = usuariosRepositorio;
        }

        [Authorize(Roles = "Master")]
        [HttpGet]
        public async Task<ActionResult<List<RetornoUsuario>>> BuscarTodosOsUsuarios()
        {
            Console.WriteLine("Aqui");
            List<RetornoUsuario> usuarios = await _usuariosRepositorio.BuscarTodosOsUsuarios();
            return Ok(usuarios);
        }

        [Authorize(Roles = "Master")]
        [HttpGet("{id}")]
        public async Task<ActionResult<RetornoUsuario>> BuscarUsuarioPorID(int id)
        {
            RetornoUsuario usuario = await _usuariosRepositorio.BuscarUsuarioPorId(id);
            return Ok(usuario);
        }

        [Authorize(Roles = "Master")]
        [HttpPost]
        public async Task<ActionResult<UsuarioModel>> CriarUsuario([FromBody] UsuarioModel usuario)
        {
            if (usuario == null)
            {
                Console.WriteLine("Usuário não pode ser nulo");
                return BadRequest();
            }
            UsuarioModel novoUsuario = await _usuariosRepositorio.CriarUsuario(usuario);
            return Ok(novoUsuario);
        }

        [Authorize(Roles = "Master")]
        [HttpPut("alterar/{id}")]
        public async Task<ActionResult<RetornoUsuario>> AlterarUsuario([FromBody] AlteradorUsuario usuario, int id)
        {
            Console.WriteLine(id);
            if (usuario == null)
            {
                Console.WriteLine("Usuário não pode ser nulo");
                return BadRequest();
            }
            RetornoUsuario editarUsaurio = await _usuariosRepositorio.AlterarUsuario(usuario, id);
            return Ok(editarUsaurio);
        }

        [Authorize(Roles = "Master")]
        [HttpPut("alterarsenha/{id}")]
        public async Task<ActionResult<bool>> AlterarUsuario([FromBody] SenhaRequest senha, int id)
        {
            bool alterarSenha = await _usuariosRepositorio.AlterarSenha(senha, id);
            return Ok(alterarSenha);
        }

        [Authorize(Roles = "Master")]
        [HttpDelete("{id}")]
        public async Task<ActionResult<UsuarioModel>> DeletarUsuario(int id)
        {
            bool usuarioDeletado = await _usuariosRepositorio.DeletarUsuario(id);
            return Ok(usuarioDeletado);
        }
    }
}
