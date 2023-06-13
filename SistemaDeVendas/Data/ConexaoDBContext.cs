using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Data.Map;
using SistemaDeVendas.Models.EmpresaModels;
using SistemaDeVendas.Models.GeralModel;
using SistemaDeVendas.Models.GeralModels;
using SistemaDeVendas.Models.Permissoes;
using SistemaDeVendas.Models.UsuariosModels;

namespace SistemaDeVendas.Data
{
    public class ConexaoDBContext : DbContext
    {
        public DbSet<EmpresaModel> Empresas { get; set; }
        public DbSet<GrupoPermissoesModel> GrupoPermissoes { get; set; }
        public DbSet<PermissaoModel> Permissoes { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<ContatosModel> Contatos { get; set; }
        public DbSet<DadosBancariosModel> DadosBancarios { get; set; }
        public DbSet<DocumentoUsuariosModel> DocumentosUsuarios { get; set; }
        public DbSet<EnderecoModel> Enderecos { get; set; }
        public DbSet<ParametrosdeVendasModel> ParametrosdeVendas { get; set; }

        public ConexaoDBContext(DbContextOptions<ConexaoDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmpresaModelMap());
            modelBuilder.ApplyConfiguration(new GrupoPermissaoMap());
            modelBuilder.ApplyConfiguration(new PermissaoModelMap());
            modelBuilder.ApplyConfiguration(new UsuarioModelMap());
            modelBuilder.ApplyConfiguration(new DocumentoUsuarioModelMap());
            modelBuilder.ApplyConfiguration(new ContatosModelMap());
            modelBuilder.ApplyConfiguration(new DadosBancariosMap());
            modelBuilder.ApplyConfiguration(new EnderecoModelMap());
            modelBuilder.ApplyConfiguration(new ParametrosDeVendasModelMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
