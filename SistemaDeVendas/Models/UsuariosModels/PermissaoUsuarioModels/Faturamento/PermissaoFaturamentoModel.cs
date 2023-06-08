using SistemaDeVendas.Enums;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels.Faturamento
{
    public class PermissaoFaturamentoModel
    {
        [Key]
        public int Id { get; set; }
        public Permissoes NaturezaOperacao { get; set; }
        public Permissoes MatrizFiscal { get; set; }
        public Permissoes NF { get; set; }
        public Permissoes ManifestoNF { get; set; }
    }
}
