﻿using SistemaDeVendas.Models.UsuariosModels;

namespace SistemaDeVendas.Repositorios.Interfaces.InterfaceUsuario
{
    public interface IUsuariosRepositorio
    {
        Task<List<UsuarioModel>> BuscarTodosOsUsuarios();
        Task<UsuarioModel> BuscarUsuarioPorId(int id);
        Task<UsuarioModel> CriarUsuario(UsuarioModel usuario);
        Task<UsuarioModel> AlterarUsuario(UsuarioModel usuario, int id);
        Task<bool> DeletarUsuario(int id);
    }
}