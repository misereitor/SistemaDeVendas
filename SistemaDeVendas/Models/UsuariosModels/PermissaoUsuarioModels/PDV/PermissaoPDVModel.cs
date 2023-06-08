using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels.PDV
{
    public class PermissaoPDVModel
    {
        [Key]
        public int Id { get; set; }
        public Permissoes Cardapio { get; set; }
        public Permissoes OperacoesPDV { get; set; }
        public Permissoes NaturezaOperacao { get; set; }
        public PermissaoCupom Devolucoes { get; set; }
    }
}
