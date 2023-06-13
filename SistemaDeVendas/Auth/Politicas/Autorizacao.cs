using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using SistemaDeVendas.Data;
using SistemaDeVendas.Models.UsuariosModels;
using SistemaDeVendas.Validacoes;
using System.Security.Claims;

namespace SistemaDeVendas.Auth.Politicas
{
    public static class Autorizacao
    {
        public static void PoliticasAutorizacao(AuthorizationOptions options)
        {
            options.AddPolicy("Master", policy =>
            {
                policy.RequireRole("Master");
                policy.RequireAssertion(context =>
                {
                    var usuario = context.User;
                    bool master = UsuarioEMaster(usuario);
                    return master;
                });
            });
        }
        private static bool UsuarioEMaster(ClaimsPrincipal usuario)
        {
            return usuario.IsInRole("Master");
        }
    }
}
