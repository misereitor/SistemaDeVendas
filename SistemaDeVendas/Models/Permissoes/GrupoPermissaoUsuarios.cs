using SistemaDeVendas.Models.Permissoes.PermissaoUsuarioModels.Catalogo;
using SistemaDeVendas.Models.Permissoes.PermissaoUsuarioModels.Compras;
using SistemaDeVendas.Models.Permissoes.PermissaoUsuarioModels.Estoque;
using SistemaDeVendas.Models.Permissoes.PermissaoUsuarioModels.Faturamento;
using SistemaDeVendas.Models.Permissoes.PermissaoUsuarioModels.Financeiro;
using SistemaDeVendas.Models.Permissoes.PermissaoUsuarioModels.PDV;
using SistemaDeVendas.Models.Permissoes.PermissaoUsuarioModels.Pessoas;
using SistemaDeVendas.Models.Permissoes.PermissaoUsuarioModels.Relatorios;
using SistemaDeVendas.Models.Permissoes.PermissaoUsuarioModels.Vendas;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.Permissoes
{
    public class GrupoPermissaoUsuarios
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public PermissaoCatalogoModel Catalogo { get; set; }
        [Required]
        public PermissaoCompasModel Compas { get; set; }
        [Required]
        public PermissaoEstoqueModel Estoque { get; set; }
        [Required]
        public PermissaoFaturamentoModel Faturamento { get; set; }
        [Required]
        public PermissaoFinacneiroModel Finacneiro { get; set; }
        [Required]
        public PermissaoPDVModel PDV { get; set; }
        [Required]
        public PermissaoPessoasModel Pessoas { get; set; }
        [Required]
        public PermissaoRelatorioModel Relatorio { get; set; }
        [Required]
        public PermissaoVendasModel Vendas { get; set; }
    }
}
