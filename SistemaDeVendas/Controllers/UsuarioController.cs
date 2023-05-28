using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeVendas.Models;

namespace SistemaDeVendas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        [HttpGet]
        public ActionResult<List<UsuarioModel>> BuscarTodosOsUsuarios()
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult<UsuarioModel> CadastrarUsuario(UsuarioModel usuario)
        {
            return Ok();
        }

        [HttpPut]
        public  ActionResult<UsuarioModel> AlterarUsuario(UsuarioModel usuario, int id)
        {
            return Ok();
        }

        [HttpDelete]
        public ActionResult<UsuarioModel> DeletarUsuario(int id)
        {
            return Ok();
        }
    }
}
