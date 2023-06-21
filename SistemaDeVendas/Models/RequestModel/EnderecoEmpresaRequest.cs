using SistemaDeVendas.Models.GeralModels.EnderecoModel;

namespace SistemaDeVendas.Models.RequestModel
{
    public class EnderecoEmpresaRequest
    {
        public int IdEmpresa { get; set; }
        public int IdEndereco { get; set; }
        public EnderecoEmpresaCorrespondenciaModel EnderecoCorrespondencia { get; set; }
        public EnderecoEmpresaFaturamentoModel EnderecoFaturamento { get; set; }
        public EnderecoEmpresaEntregaModel EnderecoEntrega { get; set; }

        public EnderecoEmpresaRequest(int idEmpresa, int idEndereco, EnderecoEmpresaCorrespondenciaModel enderecoCorrespondencia, EnderecoEmpresaFaturamentoModel enderecoFaturamento, EnderecoEmpresaEntregaModel enderecoEntrega)
        {
            IdEmpresa = idEmpresa;
            IdEndereco = idEndereco;
            EnderecoCorrespondencia = enderecoCorrespondencia;
            EnderecoFaturamento = enderecoFaturamento;
            EnderecoEntrega = enderecoEntrega;
        }
    }
}
