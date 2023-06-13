using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.Permissoes.PermissaoUsuarioModels.Compras
{
    public class PermissaoOrcamentoCompra
    {
        [Key]
        public int Id { get; set; }
        public PermissaoModel OrcamentoCompra { get; set; }
        public PermissaoModel GerarPedido { get; set; }
        public PermissaoModel Cancelar { get; set; }
        public PermissaoModel Copiar { get; set; }
    }
}
