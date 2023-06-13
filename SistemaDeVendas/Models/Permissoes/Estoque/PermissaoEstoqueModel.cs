using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.Permissoes.PermissaoUsuarioModels.Estoque
{
    public class PermissaoEstoqueModel
    {
        [Key]
        public int Id { get; set; }
        public PermissaoLocaisEstoque LocaisEstoque { get; set; }
        public PermissaoModel ConsultarEstoque { get; set; }
        public PermissaoMovimentoEstoque MovimentarEstoque { get; set; }
        public PermissaoModel Motivo { get; set; }
        public PermissaoModel TipoEstocagem { get; set; }
        public PermissaoModel TransferenciaInternas { get; set; }
        public PermissaoModel ItensPendentesEntrega { get; set; }
    }
}
