﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaDeVendas.Models.EmpresaModels;
using SistemaDeVendas.Models.UsuariosModels;
using SistemaDeVendas.Repositorios.Interfaces.InteerfaceEmpresa;

namespace SistemaDeVendas.Controllers.Empresa
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        private readonly IEmpresaRepositorio _empresaRepositorio;
        public EmpresaController(IEmpresaRepositorio empresaRepositorio)
        {
            _empresaRepositorio = empresaRepositorio;
        }

        [Authorize(Roles = "Master")]
        [HttpGet]
        public async Task<ActionResult<List<EmpresaModel>>> BuscarTodasEmpresas()
        {
            List<EmpresaModel> empresas = await _empresaRepositorio.BuscarTodosAsEmpresas();
            return Ok(empresas);
        }

        [Authorize(Roles = "Master")]
        [HttpGet("{id}")]
        public async Task<ActionResult<EmpresaModel>> BuscarEmpresasPorId([FromHeader] int id)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(id);
            return Ok(empresa);
        }


        [Authorize(Roles = "Master")]
        [HttpPost("criar")]
        public async Task<ActionResult<EmpresaModel>> CriarEmpresa([FromBody] EmpresaModel empresa)
        {
            if (empresa == null)
            {
                Console.WriteLine("Usuário não pode ser nulo");
                return BadRequest();
            }
            EmpresaModel novaEmpresa = await _empresaRepositorio.CriarEmpresa(empresa);
            return Ok(novaEmpresa);
        }
        [Authorize(Roles = "Master")]
        [HttpPut("{id}")]
        public async Task<ActionResult<EmpresaModel>> AlterarEmpresa(int id, [FromBody] EmpresaModel empresa)
        {
            EmpresaModel empresaAlterada = await _empresaRepositorio.AlterarEmpresa(empresa, id);
            return Ok(empresaAlterada);
        }

        [Authorize(Roles = "Master")]
        [HttpDelete("{id}")]
        public async Task<ActionResult<EmpresaModel>> DeletarEmpresa(int id)
        {
            bool empresaDeletada = await _empresaRepositorio.DeletarEmpresa(id);
            return Ok(empresaDeletada);
        }
    }
}
