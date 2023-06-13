using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.Permissoes.PermissaoUsuarioModels.Pessoas
{
    public class PermissaoPessoasModel
    {
        [Key]
        public int Id { get; set; }
        public PermissaoModel Fornecedores { get; set; }
        public PermissaoModel TipoEndereco { get; set; }
        public PermissaoModel ListasPrecos { get; set; }
        public PermissaoModel TiposClientes { get; set; }
        public PermissaoModel TipoDocuimento { get; set; }
        public PermissaoModel TipoFornecedor { get; set; }
        public PermissaoClientes Clientes { get; set; }
    }
}
