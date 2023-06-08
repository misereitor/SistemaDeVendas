﻿using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Data.Map;
using SistemaDeVendas.Models.EmpresaModels;
using SistemaDeVendas.Models.GeralModel;
using SistemaDeVendas.Models.GeralModels;
using SistemaDeVendas.Models.UsuariosModels;

namespace SistemaDeVendas.Data
{
    public class ConexaoDBContext : DbContext
    {
        public DbSet<EmpresaModel> Empresas { get; set; }
        public DbSet<ParametrosdeVendasModel> ParametrosDeVendas { get; set; }
        public DbSet<EnderecoModel> Enderecos { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<DadosBancariosModel> DadosBancarios { get; set; }

        public ConexaoDBContext(DbContextOptions<ConexaoDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new EmpresaMap());
            modelBuilder.ApplyConfiguration(new ParametrosDeVendasModelMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new DadosBancariosMap());
        }
    }
}
