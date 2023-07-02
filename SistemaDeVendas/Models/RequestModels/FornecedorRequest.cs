using SistemaDeVendas.Models.FornecedorModels;

namespace SistemaDeVendas.Models.RequestModels
{
    public class FornecedorRequest
    {
        public int Id { get; set; }
        public FornecedorModel Fornecedor { get; set; }
        public FornecedorRequest() 
        { 
            Fornecedor = new FornecedorModel();
        }
    }
}
