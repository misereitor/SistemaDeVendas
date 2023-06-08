using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels.Pessoas
{
    public class PermissaoPessoasModel
    {
        [Key]
        public int Id { get; set; }
        public Permissoes Fornecedores { get; set; }
        public Permissoes TipoEndereco { get; set; }
        public Permissoes ListasPrecos { get; set; }
        public Permissoes TiposClientes { get; set; }
        public Permissoes TipoDocuimento { get; set; }
        public Permissoes TipoFornecedor { get; set; }
        public PermissaoClientes Clientes { get; set; }
    }
}
