using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeVendas.Repositorios.Interfaces.InterfaceProduto;

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

    }
}
