namespace SistemaDeVendas.Models.RequestModels
{
    public class SenhaRequest
    {
        public string Senha { get; set; }
        public SenhaRequest() 
        { 
            Senha = string.Empty;
        }
    }
}
