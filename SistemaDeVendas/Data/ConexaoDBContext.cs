using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Models.EmpresaModels;
using SistemaDeVendas.Models.FinanceiroModel;
using SistemaDeVendas.Models.FornecedorModels;
using SistemaDeVendas.Models.GeralModels;
using SistemaDeVendas.Models.GeralModels.DadosBancarios;
using SistemaDeVendas.Models.GeralModels.EnderecoModel;
using SistemaDeVendas.Models.Permissoes;
using SistemaDeVendas.Models.ProdutoModels;
using SistemaDeVendas.Models.ProdutoModels.PartesProdutoModel;
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
        public DbSet<ContasAReceberModel> ContasAReceber { get; set; }
        public DbSet<ContasAPagarModel> ContasAPagar { get; set; }
        public DbSet<FornecedorModel> Forcededor { get; set; }
        public DbSet<ProdutoModel> Produto { get; set; }
        public DbSet<TipoProdutoModel> TipoProduto { get; set; }
        public DbSet<UnidadeProdutoModel> UnidadeProduto { get; set; }
        public DbSet<CategoriaProdutoModel> CategoriaProduto { get; set; }
        public DbSet<MarcaProdutoModel> MarcaProduto { get; set; }
        public DbSet<FinalidadeProdutoModel> FinalidadeProduto { get; set; }
        public DbSet<RCMProdutoModel> RCMProduto { get; set; }


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
                    Senha = "4a9ccbd733db5bd7d6c09acdb551b94504aa2738195b955dd0fa64f5145a9369",
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
