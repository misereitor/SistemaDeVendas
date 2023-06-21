using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Models.EmpresaModels;
using SistemaDeVendas.Models.GeralModels.ContatosModel;
using SistemaDeVendas.Models.GeralModels.DadosBancarios;
using SistemaDeVendas.Models.GeralModels.EnderecoModel;
using SistemaDeVendas.Models.Permissoes;
using SistemaDeVendas.Models.UsuariosModels;

namespace SistemaDeVendas.Data
{
    public class ConexaoDBContext : DbContext
    {
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<DocumentoUsuariosModel> DocumentosUsuarios { get; set; }
        public DbSet<PermissaoModel> Permissoes { get; set; }
        public DbSet<GrupoPermissoesModel> GruposPermissoes { get; set; }
        public DbSet<EnderecoUsuarioModel> EnderecosUsuarios { get; set; }
        public DbSet<EnderecoEmpresaFaturamentoModel> EnderecosEmpresaFaturamento { get; set; }
        public DbSet<EnderecoEmpresaEntregaModel> EnderecosEmpresaEntrega { get; set; }
        public DbSet<EnderecoEmpresaCorrespondenciaModel> EnderecosEmpresaCorrespondencia { get; set; }
        public DbSet<DadosBancariosUsuarioModel> DadosBancariosUsuarios { get; set; }
        public DbSet<DadosBancariosEmpresaModel> DadosBancariosEmpresas { get; set; }
        public DbSet<EmpresaModel> Empresas { get; set; }
        public DbSet<ParametrosdeVendasModel> ParametrosVendas { get; set; }


        public ConexaoDBContext(DbContextOptions<ConexaoDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
        }
    }
}
