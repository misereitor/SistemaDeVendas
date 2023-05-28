using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using SistemaDeVendas.Models;

namespace SistemaDeVendas.Data
{
    public class ConexaoDBContex : DbContext
    {
        public DbSet<UsuarioModel> usuarioModels { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder.UseNpgsql(
                "Server = localhost; " +
                "Port=5432;User Id = postgres; " +
                "Password=V!V#tc%001;" +
                "Database=sistemadevendas;");
    }
}
