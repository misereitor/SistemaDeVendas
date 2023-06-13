using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.Permissoes.PermissaoUsuarioModels.PDV
{
    public class PermissaoPDVModel
    {
        [Key]
        public int Id { get; set; }
        public PermissaoModel Cardapio { get; set; }
        public PermissaoModel OperacoesPDV { get; set; }
        public PermissaoModel NaturezaOperacao { get; set; }
        public PermissaoCupom Devolucoes { get; set; }
    }
}
