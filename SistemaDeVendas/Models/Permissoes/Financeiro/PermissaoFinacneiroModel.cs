using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.Permissoes.PermissaoUsuarioModels.Financeiro
{
    public class PermissaoFinacneiroModel
    {
        [Key]
        public int Id { get; set; }
        public PermissaoModel OFX { get; set; }
        public PermissaoModel ConciliacaoBancaria { get; set; }
        public PermissaoModel ContasCorrentes { get; set; }
        public PermissaoModel ContasGerenciais { get; set; }
        public PermissaoModel RecuperacaoCredito { get; set; }
        public PermissaoModel RecebimentoMultContas { get; set; }
        public PermissaoModel PagamentoMultContas { get; set; }
        public PermissaoModel FluxoCaixa { get; set; }
        public PermissaoModel TipoPagamento { get; set; }
        public PermissaoModel SaldoExtratoIntegrados { get; set; }
        public PermissaoModel ConciliaFacil { get; set; }
        public PermissaoPagamentos Pagamentos { get; set; }
        public PermissaoRecebimentos Recebimentos { get; set; }
        public PermissaoMovimentoCaixa MovimentoCaixa { get; set; }
    }
}
