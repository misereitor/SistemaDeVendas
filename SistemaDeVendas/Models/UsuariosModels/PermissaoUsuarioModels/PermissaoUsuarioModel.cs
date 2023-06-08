using System.ComponentModel.DataAnnotations;
using SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels.Catalogo;
using SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels.Compras;
using SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels.Estoque;
using SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels.Faturamento;
using SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels.Financeiro;
using SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels.PDV;
using SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels.Pessoas;
using SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels.Relatorios;
using SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels.Vendas;

namespace SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels
{
    public class PermissaoUsuarioModel
    {
        public PermissaoUsuarioModel()
        {
        }

        [Key]
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
        public PermissaoFinacneiroModel Finacneiro { get; set;}
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
