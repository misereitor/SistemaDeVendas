using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeVendas.Models.ProdutoModels;
using SistemaDeVendas.Repositorios.Interfaces.InterfaceProduto;
using System.Data;

namespace SistemaDeVendas.Controllers.Produto
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProtudoController : ControllerBase
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        public ProtudoController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        [HttpPost("criar")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<ProdutoModel>> CriarProduto([FromBody] ProdutoModel produto)
        {
            ProdutoModel produtoNovo = await _produtoRepositorio.CriarProduto(produto);
            return Ok(produtoNovo);
        }

        [HttpPut("Alterar")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<ProdutoModel>> AlterarProduto([FromBody] ProdutoModel produto)
        {
            ProdutoModel produtoAlterado = await _produtoRepositorio.AlterarProduto(produto);
            return Ok(produtoAlterado);
        }

        [HttpGet("buscartodos")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<List<ProdutoModel>>> BuscarTodosProdutos()
        {
            List<ProdutoModel> produtos = await _produtoRepositorio.BuscarTodosProdutos();
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<List<ProdutoModel>>> BuscarProdutoPorId(int id)
        {
            ProdutoModel produto = await _produtoRepositorio.BuscarProdutoPorId(id);
            return Ok(produto);
        }

        [HttpPut("desativar/{id}")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<bool>> DesativarProduto(int id)
        {
            bool desativar = await _produtoRepositorio.DesativarProdutoPorId(id);
            return Ok(desativar);
        }
    }
}
