using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeVendas.Models.GeralModels.EnderecoModel;
using SistemaDeVendas.Models.RequestModel;
using SistemaDeVendas.Repositorios.Interfaces.InterfaceModelsGeral;

namespace SistemaDeVendas.Controllers.Endereco
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

        [Authorize(Roles = "Master")]
        [HttpPost("enderecoentregaempresa")]
        public async Task<ActionResult<EnderecoEmpresaEntregaModel>> AdcionarEnderecoEntregaEmpresa([FromBody] EnderecoEmpresaRequest enderecoRequest)
        {
            EnderecoEmpresaEntregaModel endereco = await _enderecoRepositorio.AdcionarEnderecoEntregaEmpresa(enderecoRequest.IdEmpresa, enderecoRequest.EnderecoEntrega);
            return Ok(endereco);
        }

        [Authorize(Roles = "Master")]
        [HttpPost("enderecofaturamentoempresa")]
        public async Task<ActionResult<EnderecoEmpresaFaturamentoModel>> AdcionarEnderecoFaturamentoEmpresa([FromBody] EnderecoEmpresaRequest enderecoRequest)
        {
            EnderecoEmpresaFaturamentoModel endereco = await _enderecoRepositorio.AdcionarEnderecoFaturamentoEmpresa(enderecoRequest.IdEmpresa, enderecoRequest.EnderecoFaturamento);
            return Ok(endereco);
        }

        [Authorize(Roles = "Master")]
        [HttpPost("enderecocorrespondenciaempresa")]
        public async Task<ActionResult<EnderecoEmpresaCorrespondenciaModel>> AdcionarEnderecoCorrespondenciaEmpresa([FromBody] EnderecoEmpresaRequest enderecoRequest)
        {
            EnderecoEmpresaCorrespondenciaModel endereco = await _enderecoRepositorio.AdcionarEnderecoCorrespondenciaEmpresa(enderecoRequest.IdEmpresa, enderecoRequest.EnderecoCorrespondencia);
            return Ok(endereco);
        }

        [Authorize(Roles = "Master")]
        [HttpPost("enderecousuario")]
        public async Task<ActionResult<EnderecoUsuarioModel>> AdcionarEnderecoDoUsuario([FromBody] EnderecoUsuarioRequest enderecoRequest)
        {
            EnderecoUsuarioModel endereco = await _enderecoRepositorio.AdcionarEnderecoDoUsuario(enderecoRequest.IdUsuario, enderecoRequest.Endereco);
            return Ok(endereco);
        }

        [Authorize(Roles = "Master")]
        [HttpGet("enderecoentregaempresa")]
        public async Task<ActionResult<ICollection<EnderecoEmpresaEntregaModel>>> BuscaEnderecoEntregaEmpresa([FromBody] EnderecoEmpresaRequest enderecoRequest)
        {
            ICollection<EnderecoEmpresaEntregaModel> endereco = await _enderecoRepositorio.BuscaEnderecoEntregaEmpresa(enderecoRequest.IdEmpresa);
            return Ok(endereco);
        }

        [Authorize(Roles = "Master")]
        [HttpGet("enderecofaturamentoempresa")]
        public async Task<ActionResult<ICollection<EnderecoEmpresaFaturamentoModel>>> BuscaEnderecoFaturamentoEmpresa([FromBody] EnderecoEmpresaRequest enderecoRequest)
        {
            ICollection<EnderecoEmpresaFaturamentoModel> endereco = await _enderecoRepositorio.BuscaEnderecoFaturamentoEmpresa(enderecoRequest.IdEmpresa);
            return Ok(endereco);
        }

        [Authorize(Roles = "Master")]
        [HttpGet("enderecocorrespondenciaempresa")]
        public async Task<ActionResult<ICollection<EnderecoEmpresaCorrespondenciaModel>>> BuscaEnderecoCorrespondenciaEmpresa([FromBody] EnderecoEmpresaRequest enderecoRequest)
        {
            ICollection<EnderecoEmpresaCorrespondenciaModel> endereco = await _enderecoRepositorio.BuscaEnderecoCorrespondenciaEmpresa(enderecoRequest.IdEmpresa);
            return Ok(endereco);
        }

        [Authorize(Roles = "Master")]
        [HttpGet("enderecousuario")]
        public async Task<ActionResult<EnderecoUsuarioModel>> BuscaEnderecoDoUsuario([FromBody] EnderecoUsuarioRequest enderecoRequest)
        {
            EnderecoUsuarioModel endereco = await _enderecoRepositorio.BuscaEnderecoDoUsuario(enderecoRequest.IdUsuario);
            return Ok(endereco);
        }

        [Authorize(Roles = "Master")]
        [HttpPut("enderecoentregaempresa")]
        public async Task<ActionResult<EnderecoEmpresaEntregaModel>> AlteraEnderecoEntregaEmpresa([FromBody] EnderecoEmpresaRequest enderecoRequest)
        {
            EnderecoEmpresaEntregaModel enderecoAlterado = await _enderecoRepositorio.AlteraEnderecoEntregaEmpresa(enderecoRequest.IdEmpresa, enderecoRequest.IdEndereco, enderecoRequest.EnderecoEntrega);
            return Ok(enderecoAlterado);
        }

        [Authorize(Roles = "Master")]
        [HttpPut("enderecofaturamentoempresa")]
        public async Task<ActionResult<EnderecoEmpresaFaturamentoModel>> AlteraEnderecoFaturamentoEmpresa([FromBody] EnderecoEmpresaRequest enderecoRequest)
        {
            EnderecoEmpresaFaturamentoModel enderecoAlterado = await _enderecoRepositorio.AlteraEnderecoFaturamentoEmpresa(enderecoRequest.IdEmpresa, enderecoRequest.IdEndereco, enderecoRequest.EnderecoFaturamento);
            return Ok(enderecoAlterado);
        }

        [Authorize(Roles = "Master")]
        [HttpPut("enderecocorrespondenciaempresa")]
        public async Task<ActionResult<EnderecoEmpresaCorrespondenciaModel>> AlteraEnderecoCorrespondenciaEmpresa([FromBody] EnderecoEmpresaRequest enderecoRequest)
        {
            EnderecoEmpresaCorrespondenciaModel enderecoAlterado = await _enderecoRepositorio.AlteraEnderecoCorrespondenciaEmpresa(enderecoRequest.IdEmpresa, enderecoRequest.IdEndereco, enderecoRequest.EnderecoCorrespondencia);
            return Ok(enderecoAlterado);
        }

        [Authorize(Roles = "Master")]
        [HttpPut("enderecousuario")]
        public async Task<ActionResult<EnderecoUsuarioModel>> AlteraEnderecoDoUsuario([FromBody] EnderecoUsuarioRequest enderecoRequest)
        {
            EnderecoUsuarioModel enderecoAlterado = await _enderecoRepositorio.AlteraEnderecoDoUsuario(enderecoRequest.IdUsuario, enderecoRequest.Endereco);
            return Ok(enderecoAlterado);
        }

        [Authorize(Roles = "Master")]
        [HttpDelete("enderecoentregaempresa")]
        public async Task<ActionResult<EnderecoUsuarioModel>> DeletaEnderecoEntregaEmpresa([FromBody] EnderecoEmpresaRequest enderecoRequest)
        {
            bool deletar = await _enderecoRepositorio.DeletaEnderecoEntregaEmpresa(enderecoRequest.IdEmpresa, enderecoRequest.IdEndereco);
            return Ok(deletar);
        }

        [Authorize(Roles = "Master")]
        [HttpDelete("enderecofaturamentoempresa")]
        public async Task<ActionResult<EnderecoUsuarioModel>> DeletaEnderecoFaturamentoEmpresa([FromBody] EnderecoEmpresaRequest enderecoRequest)
        {
            bool deletar = await _enderecoRepositorio.DeletaEnderecoFaturamentoEmpresa(enderecoRequest.IdEmpresa, enderecoRequest.IdEndereco);
            return Ok(deletar);
        }

        [Authorize(Roles = "Master")]
        [HttpDelete("enderecocorrespondenciaempresa")]
        public async Task<ActionResult<EnderecoUsuarioModel>> DeletaEnderecoCorrespondenciaEmpresa([FromBody] EnderecoEmpresaRequest enderecoRequest)
        {
            bool deletar = await _enderecoRepositorio.DeletaEnderecoCorrespondenciaEmpresa(enderecoRequest.IdEmpresa, enderecoRequest.IdEndereco);
            return Ok(deletar);
        }

        [Authorize(Roles = "Master")]
        [HttpDelete("enderecousuario")]
        public async Task<ActionResult<EnderecoUsuarioModel>> DeletaEnderecoUsuario([FromBody] EnderecoUsuarioRequest enderecoRequest)
        {
            bool deletar = await _enderecoRepositorio.DeletaEnderecoUsuario(enderecoRequest.IdUsuario);
            return Ok(deletar);
        }
    }
}
