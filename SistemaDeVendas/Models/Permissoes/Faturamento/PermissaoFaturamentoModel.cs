using SistemaDeVendas.Enums;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.Permissoes.PermissaoUsuarioModels.Faturamento
{
    public class PermissaoFaturamentoModel
    {
        [Key]
        public int Id { get; set; }
        public PermissaoModel NaturezaOperacao { get; set; }
        public PermissaoModel MatrizFiscal { get; set; }
        public PermissaoModel NF { get; set; }
        public PermissaoModel ManifestoNF { get; set; }
    }
}
