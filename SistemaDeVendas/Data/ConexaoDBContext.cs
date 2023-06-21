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

            // Dados iniciais
            modelBuilder.Entity<UsuarioModel>().HasData(
                new UsuarioModel
                {
                    Id = 1,
                    Nome = "Master",
                    Email = "teste@teste.com",
                    Usuario = "suporte",
                    Senha = "V!V#tc%001",
                    Sexo = 0,
                    DataNascimento = DateOnly.Parse("2023-06-10"),
                    Ativo = true,
                    Roles = Enums.UsuarioRoles.Master,
                    TipoPessoa = Enums.TipoPessoa.juridica,
                    OperadorPDV = true,
                    ADMPDV = true,
                    Vendedor = true,
                    Comprador = true,
                    CNPJ = "26467564000122",
                    Telefone = "07536312387"
                });
        }
    }
}
