
namespace SistemaDeVendas.TratamentoDeErros
{
    public class ShowException
    {
        private readonly RequestDelegate _next;
        public ShowException(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (ErrosException ex)
            {
                context.Response.StatusCode = ex.StatusCode;
                await context.Response.WriteAsync(ex.Message);
            }
        }
    }
}
