using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeVendas.Models.ProdutoModels.PartesProdutoModel;
using SistemaDeVendas.Repositorios.Interfaces.InterfaceProduto;
using System.Collections.Generic;

namespace SistemaDeVendas.Controllers.Produto
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartesProdutoController : ControllerBase
    {
        private readonly IPartesProdutoRepositorio _partesProdutoRepositorio;

        public PartesProdutoController(IPartesProdutoRepositorio partesProdutoRepositorio)
        {
            _partesProdutoRepositorio = partesProdutoRepositorio;
        }

        [HttpPost("criar/categoriaproduto")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<CategoriaProdutoModel>> AdicionarCategoriaProduto([FromBody] CategoriaProdutoModel categoriaProduto)
        {
            CategoriaProdutoModel categoria = await _partesProdutoRepositorio.AdicionarCategoriaProduto(categoriaProduto);
            return Ok(categoria);
        }

        [HttpPost("criar/finalidadeproduto")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<FinalidadeProdutoModel>> AdicionarFinalidadeProduto([FromBody] FinalidadeProdutoModel finalidadeProduto)
        {
            FinalidadeProdutoModel finalidade = await _partesProdutoRepositorio.AdicionarFinalidadeProduto(finalidadeProduto);
            return Ok(finalidade);
        }

        [HttpPost("criar/marcaproduto")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<MarcaProdutoModel>> AdicionarMarcaProduto([FromBody] MarcaProdutoModel marcaProduto)
        {
            MarcaProdutoModel marca = await _partesProdutoRepositorio.AdicionarMarcaProduto(marcaProduto);
            return Ok(marca);
        }

        [HttpPost("criar/rcmproduto")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<RCMProdutoModel>> AdicionarRCMProduto([FromBody] RCMProdutoModel RCMProduto)
        {
            RCMProdutoModel rCM = await _partesProdutoRepositorio.AdicionarRCMProduto(RCMProduto);
            return Ok(rCM);
        }

        [HttpPost("criar/tipoproduto")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<TipoProdutoModel>> AdicionarTipoProduto([FromBody] TipoProdutoModel tipoProduto)
        {
            TipoProdutoModel tipo = await _partesProdutoRepositorio.AdicionarTipoProduto(tipoProduto);
            return Ok(tipo);
        }

        [HttpPost("criar/unidadeproduto")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<UnidadeProdutoModel>> AdicionarUnidadeProduto([FromBody] UnidadeProdutoModel unidadeProduto)
        {
            UnidadeProdutoModel unidade = await _partesProdutoRepositorio.AdicionarUnidadeProduto(unidadeProduto);
            return Ok(unidade);
        }


        [HttpGet("buscarporid/categoriaproduto/{id}")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<CategoriaProdutoModel>> BuscarCategoriaProdutoPorId(int id)
        {
            CategoriaProdutoModel categoria = await _partesProdutoRepositorio.BuscarCategoriaProdutoPorId(id);
            return Ok(categoria);
        }

        [HttpGet("buscarporid/finalidadeproduto/{id}")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<FinalidadeProdutoModel>> BuscarFinalidadeProdutoPorId(int id)
        {
            FinalidadeProdutoModel finalidade = await _partesProdutoRepositorio.BuscarFinalidadeProdutoPorId(id);
            return Ok(finalidade);
        }

        [HttpGet("buscarporid/marcaproduto/{id}")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<MarcaProdutoModel>> BuscarMarcaProdutoPorId(int id)
        {
            MarcaProdutoModel marca = await _partesProdutoRepositorio.BuscarMarcaProdutoPorId(id);
            return Ok(marca);
        }

        [HttpGet("buscarporid/rcmproduto/{id}")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<RCMProdutoModel>> BuscarRCMProdutoPorId(int id)
        {
            RCMProdutoModel rCM = await _partesProdutoRepositorio.BuscarRCMProdutoPorId(id);
            return Ok(rCM);
        }

        [HttpGet("buscarporid/tipoproduto/{id}")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<TipoProdutoModel>> BuscarTiposProdutoPorId(int id)
        {
            TipoProdutoModel tipo = await _partesProdutoRepositorio.BuscarTiposProdutoPorId(id);
            return Ok(tipo);
        }

        [HttpGet("buscarporid/unidadeproduto/{id}")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<UnidadeProdutoModel>> BuscarUnidadeProdutoPorId(int id)
        {
            UnidadeProdutoModel unidade = await _partesProdutoRepositorio.BuscarUnidadeProdutoPorId(id);
            return Ok(unidade);
        }


        [HttpGet("buscartodos/categoriaproduto")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<List<FinalidadeProdutoModel>>> BuscarTodasFinalidadesProduto()
        {
            List<FinalidadeProdutoModel> categoria = await _partesProdutoRepositorio.BuscarTodasFinalidadesProduto();
            return Ok(categoria);
        }

        [HttpGet("buscartodos/finalidadeproduto")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<List<CategoriaProdutoModel>>> BuscarTodosCategoriasProduto()
        {
            List<CategoriaProdutoModel> finalidade = await _partesProdutoRepositorio.BuscarTodosCategoriasProduto();
            return Ok(finalidade);
        }

        [HttpGet("buscartodos/marcaproduto")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<List<RCMProdutoModel>>> BuscarTodosRCMProduto()
        {
            List<RCMProdutoModel> marca = await _partesProdutoRepositorio.BuscarTodosRCMProduto();
            return Ok(marca);
        }

        [HttpGet("buscartodos/rcmproduto")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<List<MarcaProdutoModel>>> BuscarTodossMarcasProduto()
        {
            List<MarcaProdutoModel> rCM = await _partesProdutoRepositorio.BuscarTodossMarcasProduto();
            return Ok(rCM);
        }

        [HttpGet("buscartodos/tipoproduto")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<List<TipoProdutoModel>>> BuscarTodosTiposProduto()
        {
            List < TipoProdutoModel> tipo = await _partesProdutoRepositorio.BuscarTodosTiposProduto();
            return Ok(tipo);
        }

        [HttpGet("buscartodos/unidadeproduto")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<List<UnidadeProdutoModel>>> BuscarTodosUnidadesProduto()
        {
            List<UnidadeProdutoModel> unidade = await _partesProdutoRepositorio.BuscarTodosUnidadesProduto();
            return Ok(unidade);
        }


        [HttpDelete("deletar/categoriaproduto/{id}")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<bool>> DeletarCategoriaProduto(int id)
        {
            bool deleta = await _partesProdutoRepositorio.DeletarCategoriaProduto(id);
            return Ok(deleta);
        }

        [HttpDelete("deletar/finalidadeproduto/{id}")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<bool>> DeletarFinalidadeProduto(int id)
        {
            bool deleta = await _partesProdutoRepositorio.DeletarFinalidadeProduto(id);
            return Ok(deleta);
        }

        [HttpDelete("deletar/marcaproduto/{id}")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<bool>> DeletarMarcaProduto(int id)
        {
            bool deleta = await _partesProdutoRepositorio.DeletarMarcaProduto(id);
            return Ok(deleta);
        }

        [HttpDelete("deletar/rcmproduto/{id}")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<bool>> DeletarRCMProduto(int id)
        {
            bool deleta = await _partesProdutoRepositorio.DeletarRCMProduto(id);
            return Ok(deleta);
        }

        [HttpDelete("deletar/tipoproduto/{id}")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<bool>> DeletarTipoProduto(int id)
        {
            bool deleta = await _partesProdutoRepositorio.DeletarTipoProduto(id);
            return Ok(deleta);
        }

        [HttpDelete("deletar/unidadeproduto/{id}")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<bool>> DeletarUnidadeProduto(int id)
        {
            bool deleta = await _partesProdutoRepositorio.DeletarUnidadeProduto(id);
            return Ok(deleta);
        }


        [HttpGet("buscarporid/categoriaproduto/{id}")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<CategoriaProdutoModel>> EditarCategoriaProduto([FromBody] CategoriaProdutoModel categoriaProduto, int id)
        {
            CategoriaProdutoModel categoria = await _partesProdutoRepositorio.EditarCategoriaProduto(id, categoriaProduto);
            return Ok(categoria);
        }

        [HttpGet("buscarporid/finalidadeproduto/{id}")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<FinalidadeProdutoModel>> EditarFinalidadeProduto([FromBody] FinalidadeProdutoModel finalidadeProduto, int id)
        {
            FinalidadeProdutoModel finalidade = await _partesProdutoRepositorio.EditarFinalidadeProduto(id, finalidadeProduto);
            return Ok(finalidade);
        }

        [HttpGet("buscarporid/marcaproduto/{id}")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<MarcaProdutoModel>> EditarMarcaProduto([FromBody] MarcaProdutoModel marcaProduto, int id)
        {
            MarcaProdutoModel marca = await _partesProdutoRepositorio.EditarMarcaProduto(id, marcaProduto);
            return Ok(marca);
        }

        [HttpGet("buscarporid/rcmproduto/{id}")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<RCMProdutoModel>> EditarRCMProduto([FromBody] RCMProdutoModel RCMProduto, int id)
        {
            RCMProdutoModel rCM = await _partesProdutoRepositorio.EditarRCMProduto(id, RCMProduto);
            return Ok(rCM);
        }

        [HttpGet("buscarporid/tipoproduto/{id}")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<TipoProdutoModel>> EditarTipoProduto([FromBody] TipoProdutoModel tipoProduto, int id)
        {
            TipoProdutoModel tipo = await _partesProdutoRepositorio.EditarTipoProduto(id, tipoProduto);
            return Ok(tipo);
        }

        [HttpGet("buscarporid/unidadeproduto/{id}")]
        [Authorize(Roles = "Master")]
        public async Task<ActionResult<UnidadeProdutoModel>> EditarUnidadeProduto([FromBody] UnidadeProdutoModel unidadeProduto, int id)
        {
            UnidadeProdutoModel unidade = await _partesProdutoRepositorio.EditarUnidadeProduto(id, unidadeProduto);
            return Ok(unidade);
        }
    }
}
