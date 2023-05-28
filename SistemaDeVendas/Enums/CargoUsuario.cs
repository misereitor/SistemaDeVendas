using System.ComponentModel;

namespace SistemaDeVendas.Enums
{
    public enum CargoUsuario
    {
        [Description("Acesso total")]
        Gestor = 1,
        [Description("Acesso a venda")]
        Vendedor = 2,
        [Description("Operador de caixa")]
        Caixa = 3,
        [Description("Acesso a consulta de preços")]
        BuscaPreco = 4,
    }
}
