﻿using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeVendas.Models.UsuariosModels;
using SistemaDeVendas.Repositorios;
using SistemaDeVendas.Repositorios.Interfaces;
using SistemaDeVendas.Validacoes;

namespace SistemaDeVendas.Controllers
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
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<List<UsuarioModel>>> BuscarTodosOsUsuarios()
        {
            List<UsuarioModel> usuarios = await _usuariosRepositorio.BuscarTodosOsUsuarios();
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioModel>> BuscarUsuarioPorID(int id)
        {
            UsuarioModel usuario = await _usuariosRepositorio.BuscarUsuarioPorId(id);
            return Ok(usuario);
        }

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

        [HttpPut("{id}")]
        public async Task<ActionResult<UsuarioModel>> AlterarUsuario([FromBody] UsuarioModel usuario, int id)
        {
            if (usuario == null)
            {
                Console.WriteLine("Usuário não pode ser nulo");
                return BadRequest();
            }
            usuario.Id = id;
            await _usuariosRepositorio.AlterarUsuario(usuario, id);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<UsuarioModel>> DeletarUsuario(int id)
        {
            bool usuarioDeletado = await _usuariosRepositorio.DeletarUsuario(id);
            return Ok(usuarioDeletado);
        }
    }
}
