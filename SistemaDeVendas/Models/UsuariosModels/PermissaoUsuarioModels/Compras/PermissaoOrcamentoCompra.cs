using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels.Compras
{
    public class PermissaoOrcamentoCompra
    {
        [Key]
        public int Id { get; set; }
        public Permissoes OrcamentoCompra { get; set; }
        public Permissoes GerarPedido { get; set; }
        public Permissoes Cancelar { get; set; }
        public Permissoes Copiar { get; set; }
    }
}
