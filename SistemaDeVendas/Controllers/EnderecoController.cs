using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeVendas.Models.GeralModel;
using SistemaDeVendas.Repositorios.Interfaces;

namespace SistemaDeVendas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        
        private readonly IEnderecoRepositorio _enderecoRepositorio;
        public EnderecoController(IEnderecoRepositorio enderecoRepositorio)
        {
            _enderecoRepositorio = enderecoRepositorio;
        }

        [Authorize]
        [HttpPost("enderecoentregaempresa/{id}")]
        public async Task<ActionResult<EnderecoModel>> AdcionarEnderecoEntregaEmpresa(int id, [FromBody] EnderecoModel entregaEmpresa)
        {
            EnderecoModel endereco = await _enderecoRepositorio.AdcionarEnderecoEntregaEmpresa(id, entregaEmpresa);
            return Ok(endereco);
        }

        [Authorize]
        [HttpPost("enderecofaturamentoempresa/{id}")]
        public async Task<ActionResult<EnderecoModel>> AdcionarEnderecoFaturamentoEmpresa(int id, [FromBody] EnderecoModel entregaEmpresa)
        {
            EnderecoModel endereco = await _enderecoRepositorio.AdcionarEnderecoFaturamentoEmpresa(id, entregaEmpresa);
            return Ok(endereco);
        }

        [Authorize]
        [HttpPost("enderecocorrespondenciaempresa/{id}")]
        public async Task<ActionResult<EnderecoModel>> AdcionarEnderecoCorrespondenciaEmpresa(int id, [FromBody] EnderecoModel entregaEmpresa)
        {
            EnderecoModel endereco = await _enderecoRepositorio.AdcionarEnderecoCorrespondenciaEmpresa(id, entregaEmpresa);
            return Ok(endereco);
        }

        [Authorize]
        [HttpPost("enderecousuario/{id}")]
        public async Task<ActionResult<EnderecoModel>> AdcionarEnderecoDoUsuario(int id, [FromBody] EnderecoModel entregaEmpresa)
        {
            EnderecoModel endereco = await _enderecoRepositorio.AdcionarEnderecoDoUsuario(id, entregaEmpresa);
            return Ok(endereco);
        }

        [Authorize]
        [HttpGet("enderecoentregaempresa/{id}")]
        public async Task<ActionResult<ICollection<EnderecoModel>>> BuscaEnderecoEntregaEmpresa(int id)
        {
            ICollection<EnderecoModel> endereco = await _enderecoRepositorio.BuscaEnderecoEntregaEmpresa(id);
            return Ok(endereco);
        }

        [Authorize]
        [HttpGet("enderecofaturamentoempresa/{id}")]
        public async Task<ActionResult<ICollection<EnderecoModel>>> BuscaEnderecoFaturamentoEmpresa(int id)
        {
            ICollection<EnderecoModel> endereco = await _enderecoRepositorio.BuscaEnderecoFaturamentoEmpresa(id);
            return Ok(endereco);
        }

        [Authorize]
        [HttpGet("enderecocorrespondenciaempresa/{id}")]
        public async Task<ActionResult<ICollection<EnderecoModel>>> BuscaEnderecoCorrespondenciaEmpresa(int id)
        {
            ICollection<EnderecoModel> endereco = await _enderecoRepositorio.BuscaEnderecoCorrespondenciaEmpresa(id);
            return Ok(endereco);
        }

        [Authorize]
        [HttpGet("enderecousuario/{id}")]
        public async Task<ActionResult<EnderecoModel>> BuscaEnderecoDoUsuario(int id)
        {
            EnderecoModel endereco = await _enderecoRepositorio.BuscaEnderecoDoUsuario(id);
            return Ok(endereco);
        }

        [Authorize]
        [HttpPut("enderecoentregaempresa/{id}")]
        public async Task<ActionResult<EnderecoModel>> AlteraEnderecoEntregaEmpresa(int idEmpresa, int idEndereco, EnderecoModel endereco)
        {
            EnderecoModel enderecoAlterado = await _enderecoRepositorio.AlteraEnderecoEntregaEmpresa(idEmpresa, idEndereco, endereco);
            return Ok(enderecoAlterado);
        }

        [Authorize]
        [HttpPut("enderecofaturamentoempresa/{id}")]
        public async Task<ActionResult<EnderecoModel>> AlteraEnderecoFaturamentoEmpresa(int idEmpresa, int idEndereco, EnderecoModel endereco)
        {
            EnderecoModel enderecoAlterado = await _enderecoRepositorio.AlteraEnderecoFaturamentoEmpresa(idEmpresa, idEndereco, endereco);
            return Ok(enderecoAlterado);
        }

        [Authorize]
        [HttpPut("enderecocorrespondenciaempresa/{id}")]
        public async Task<ActionResult<EnderecoModel>> AlteraEnderecoCorrespondenciaEmpresa(int idEmpresa, int idEndereco, EnderecoModel endereco)
        {
            EnderecoModel enderecoAlterado = await _enderecoRepositorio.AlteraEnderecoCorrespondenciaEmpresa(idEmpresa, idEndereco, endereco);
            return Ok(enderecoAlterado);
        }

        [Authorize]
        [HttpPut("enderecousuario/{id}")]
        public async Task<ActionResult<EnderecoModel>> AlteraEnderecoDoUsuario(int idUsuario, int idEndereco, EnderecoModel endereco)
        {
            EnderecoModel enderecoAlterado = await _enderecoRepositorio.AlteraEnderecoEntregaEmpresa(idUsuario, idEndereco, endereco);
            return Ok(enderecoAlterado);
        }

        [Authorize]
        [HttpDelete("enderecoentregaempresa/{id}")]
        public async Task<ActionResult<EnderecoModel>> DeletaEnderecoEntregaEmpresa(int idEmpresa, int idEndereco)
        {
            bool deletar = await _enderecoRepositorio.DeletaEnderecoEntregaEmpresa(idEmpresa, idEndereco);
            return Ok(deletar);
        }

        [Authorize]
        [HttpDelete("enderecofaturamentoempresa/{id}")]
        public async Task<ActionResult<EnderecoModel>> DeletaEnderecoFaturamentoEmpresa(int idEmpresa, int idEndereco)
        {
            bool deletar = await _enderecoRepositorio.DeletaEnderecoFaturamentoEmpresa(idEmpresa, idEndereco);
            return Ok(deletar);
        }

        [Authorize]
        [HttpDelete("enderecocorrespondenciaempresa/{id}")]
        public async Task<ActionResult<EnderecoModel>> DeletaEnderecoCorrespondenciaEmpresa(int idEmpresa, int idEndereco)
        {
            bool deletar = await _enderecoRepositorio.DeletaEnderecoCorrespondenciaEmpresa(idEmpresa, idEndereco);
            return Ok(deletar);
        }

        [Authorize]
        [HttpDelete("enderecousuario/{id}")]
        public async Task<ActionResult<EnderecoModel>> DeletaEnderecoUsuario(int idUsuario)
        {
            bool deletar = await _enderecoRepositorio.DeletaEnderecoUsuario(idUsuario);
            return Ok(deletar);
        }
    }
}
