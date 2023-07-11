using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeVendas.Models.FornecedorModels;
using SistemaDeVendas.Models.RequestModels;
using SistemaDeVendas.Repositorios.Interfaces.InterfaceFornecedor;
using System.Data;

namespace SistemaDeVendas.Controllers.Fornecedor
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {
        private readonly IFornecedorRepositorio _fornecedorRepositorio;

        public FornecedorController(IFornecedorRepositorio fornecedorRepositorio)
        {
            _fornecedorRepositorio = fornecedorRepositorio;
        }
        [Authorize(Roles = "Master")]
        [HttpGet("buscarporid/{id}")]
        public async Task<ActionResult<FornecedorModel>> BuscarFornecedorPorId(int id)
        {
            FornecedorModel fornecedor = await _fornecedorRepositorio.BuscarFornecedorPorId(id);
            return Ok(fornecedor);
        }
        [Authorize(Roles = "Master")]
        [HttpGet("buscartodos")]
        public async Task<ActionResult<List<FornecedorModel>>> BuscarTodosFornecedores()
        {
            List<FornecedorModel> fornecedores = await _fornecedorRepositorio.BuscarTodosFornecedores();
            return Ok(fornecedores);
        }
        [Authorize(Roles = "Master")]
        [HttpPost("criar")]
        public async Task<ActionResult<FornecedorModel>> CriarFornecedor([FromBody] FornecedorModel fornecedor)
        {
            await _fornecedorRepositorio.CriarFornecedor(fornecedor);
            return Ok(fornecedor);
        }
        [Authorize(Roles = "Master")]
        [HttpPut("alterar")]
        public async Task<ActionResult<FornecedorModel>> AlterarFornecedor([FromBody] FornecedorModel fornecedor)
        {
            FornecedorModel FornecedorAlterador = await _fornecedorRepositorio.AlterarFornecedor(fornecedor.Id, fornecedor);
            return Ok(FornecedorAlterador);
        }
        [Authorize(Roles = "Master")]
        [HttpPut("desativar/{id}")]
        public async Task<ActionResult<bool>> DesativarFornecedor(int id)
        {
            bool desativado = await _fornecedorRepositorio.DesativarFornecedorModelPorId(id);
            return Ok(desativado);
        }
    }
}
