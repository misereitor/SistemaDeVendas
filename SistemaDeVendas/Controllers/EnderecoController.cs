using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeVendas.Models.GeralModel;
using SistemaDeVendas.Models.RequestModel;
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
        [HttpPost("enderecoentregaempresa")]
        public async Task<ActionResult<EnderecoModel>> AdcionarEnderecoEntregaEmpresa([FromBody] EnderecoEmpresaRequest enderecoRequest)
        {
            EnderecoModel endereco = await _enderecoRepositorio.AdcionarEnderecoEntregaEmpresa(enderecoRequest.IdEmpresa, enderecoRequest.Endereco);
            return Ok(endereco);
        }

        [Authorize]
        [HttpPost("enderecofaturamentoempresa")]
        public async Task<ActionResult<EnderecoModel>> AdcionarEnderecoFaturamentoEmpresa([FromBody] EnderecoEmpresaRequest enderecoRequest)
        {
            EnderecoModel endereco = await _enderecoRepositorio.AdcionarEnderecoFaturamentoEmpresa(enderecoRequest.IdEmpresa, enderecoRequest.Endereco);
            return Ok(endereco);
        }

        [Authorize]
        [HttpPost("enderecocorrespondenciaempresa")]
        public async Task<ActionResult<EnderecoModel>> AdcionarEnderecoCorrespondenciaEmpresa([FromBody] EnderecoEmpresaRequest enderecoRequest)
        {
            EnderecoModel endereco = await _enderecoRepositorio.AdcionarEnderecoCorrespondenciaEmpresa(enderecoRequest.IdEmpresa, enderecoRequest.Endereco);
            return Ok(endereco);
        }

        [Authorize]
        [HttpPost("enderecousuario")]
        public async Task<ActionResult<EnderecoModel>> AdcionarEnderecoDoUsuario([FromBody] EnderecoUsuarioRequest enderecoRequest)
        {
            EnderecoModel endereco = await _enderecoRepositorio.AdcionarEnderecoDoUsuario(enderecoRequest.IdUsuario, enderecoRequest.Endereco);
            return Ok(endereco);
        }

        [Authorize]
        [HttpGet("enderecoentregaempresa")]
        public async Task<ActionResult<ICollection<EnderecoModel>>> BuscaEnderecoEntregaEmpresa([FromBody] EnderecoEmpresaRequest enderecoRequest)
        {
            ICollection<EnderecoModel> endereco = await _enderecoRepositorio.BuscaEnderecoEntregaEmpresa(enderecoRequest.IdEmpresa);
            return Ok(endereco);
        }

        [Authorize]
        [HttpGet("enderecofaturamentoempresa")]
        public async Task<ActionResult<ICollection<EnderecoModel>>> BuscaEnderecoFaturamentoEmpresa([FromBody] EnderecoEmpresaRequest enderecoRequest)
        {
            ICollection<EnderecoModel> endereco = await _enderecoRepositorio.BuscaEnderecoFaturamentoEmpresa(enderecoRequest.IdEmpresa);
            return Ok(endereco);
        }

        [Authorize]
        [HttpGet("enderecocorrespondenciaempresa")]
        public async Task<ActionResult<ICollection<EnderecoModel>>> BuscaEnderecoCorrespondenciaEmpresa([FromBody] EnderecoEmpresaRequest enderecoRequest)
        {
            ICollection<EnderecoModel> endereco = await _enderecoRepositorio.BuscaEnderecoCorrespondenciaEmpresa(enderecoRequest.IdEmpresa);
            return Ok(endereco);
        }

        [Authorize]
        [HttpGet("enderecousuario")]
        public async Task<ActionResult<EnderecoModel>> BuscaEnderecoDoUsuario([FromBody] EnderecoUsuarioRequest enderecoRequest)
        {
            EnderecoModel endereco = await _enderecoRepositorio.BuscaEnderecoDoUsuario(enderecoRequest.IdUsuario);
            return Ok(endereco);
        }

        [Authorize]
        [HttpPut("enderecoentregaempresa")]
        public async Task<ActionResult<EnderecoModel>> AlteraEnderecoEntregaEmpresa([FromBody] EnderecoEmpresaRequest enderecoRequest)
        {
            EnderecoModel enderecoAlterado = await _enderecoRepositorio.AlteraEnderecoEntregaEmpresa(enderecoRequest.IdEmpresa, enderecoRequest.IdEndereco, enderecoRequest.Endereco);
            return Ok(enderecoAlterado);
        }

        [Authorize]
        [HttpPut("enderecofaturamentoempresa")]
        public async Task<ActionResult<EnderecoModel>> AlteraEnderecoFaturamentoEmpresa([FromBody] EnderecoEmpresaRequest enderecoRequest)
        {
            EnderecoModel enderecoAlterado = await _enderecoRepositorio.AlteraEnderecoFaturamentoEmpresa(enderecoRequest.IdEmpresa, enderecoRequest.IdEndereco, enderecoRequest.Endereco);
            return Ok(enderecoAlterado);
        }

        [Authorize]
        [HttpPut("enderecocorrespondenciaempresa")]
        public async Task<ActionResult<EnderecoModel>> AlteraEnderecoCorrespondenciaEmpresa([FromBody] EnderecoEmpresaRequest enderecoRequest)
        {
            EnderecoModel enderecoAlterado = await _enderecoRepositorio.AlteraEnderecoCorrespondenciaEmpresa(enderecoRequest.IdEmpresa, enderecoRequest.IdEndereco, enderecoRequest.Endereco);
            return Ok(enderecoAlterado);
        }

        [Authorize]
        [HttpPut("enderecousuario")]
        public async Task<ActionResult<EnderecoModel>> AlteraEnderecoDoUsuario([FromBody] EnderecoUsuarioRequest enderecoRequest)
        {
            EnderecoModel enderecoAlterado = await _enderecoRepositorio.AlteraEnderecoDoUsuario(enderecoRequest.IdUsuario, enderecoRequest.Endereco);
            return Ok(enderecoAlterado);
        }

        [Authorize]
        [HttpDelete("enderecoentregaempresa")]
        public async Task<ActionResult<EnderecoModel>> DeletaEnderecoEntregaEmpresa([FromBody] EnderecoEmpresaRequest enderecoRequest)
        {
            bool deletar = await _enderecoRepositorio.DeletaEnderecoEntregaEmpresa(enderecoRequest.IdEmpresa, enderecoRequest.IdEndereco);
            return Ok(deletar);
        }

        [Authorize]
        [HttpDelete("enderecofaturamentoempresa")]
        public async Task<ActionResult<EnderecoModel>> DeletaEnderecoFaturamentoEmpresa([FromBody] EnderecoEmpresaRequest enderecoRequest)
        {
            bool deletar = await _enderecoRepositorio.DeletaEnderecoFaturamentoEmpresa(enderecoRequest.IdEmpresa, enderecoRequest.IdEndereco);
            return Ok(deletar);
        }

        [Authorize]
        [HttpDelete("enderecocorrespondenciaempresa")]
        public async Task<ActionResult<EnderecoModel>> DeletaEnderecoCorrespondenciaEmpresa([FromBody] EnderecoEmpresaRequest enderecoRequest)
        {
            bool deletar = await _enderecoRepositorio.DeletaEnderecoCorrespondenciaEmpresa(enderecoRequest.IdEmpresa, enderecoRequest.IdEndereco);
            return Ok(deletar);
        }

        [Authorize]
        [HttpDelete("enderecousuario")]
        public async Task<ActionResult<EnderecoModel>> DeletaEnderecoUsuario([FromBody] EnderecoUsuarioRequest enderecoRequest)
        {
            bool deletar = await _enderecoRepositorio.DeletaEnderecoUsuario(enderecoRequest.IdUsuario);
            return Ok(deletar);
        }
    }
}
