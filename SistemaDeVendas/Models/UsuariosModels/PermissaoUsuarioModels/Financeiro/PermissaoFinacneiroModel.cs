using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels.Financeiro
{
    public class PermissaoFinacneiroModel
    {
        [Key]
        public int Id { get; set; }
        public Permissoes OFX { get; set; }
        public Permissoes ConciliacaoBancaria { get; set; }
        public Permissoes ContasCorrentes { get; set; }
        public Permissoes ContasGerenciais { get; set; }
        public Permissoes RecuperacaoCredito { get; set; }
        public Permissoes RecebimentoMultContas { get; set; }
        public Permissoes PagamentoMultContas { get; set; }
        public Permissoes FluxoCaixa { get; set; }
        public Permissoes TipoPagamento { get; set; }
        public Permissoes SaldoExtratoIntegrados { get; set; }
        public Permissoes ConciliaFacil { get; set; }
        public PermissaoPagamentos Pagamentos { get; set; }
        public PermissaoRecebimentos Recebimentos { get; set; }
        public PermissaoMovimentoCaixa MovimentoCaixa { get; set; }
    }
}
