using Microsoft.EntityFrameworkCore.Internal;
using System;

namespace SistemaDeVendas.Services
{
    public class TransformarObjetos<TInput, TOutput>
    {
        public TOutput ObjetosTransoformar(TInput objeto01, TOutput objeto02)
        {
            var tipoInput = typeof(TInput);
            var tipoOutput = typeof(TOutput);

            var propriedadesInput = tipoInput.GetProperties();
            var propriedadesOutput = tipoOutput.GetProperties();

            foreach (var propInput in propriedadesInput)
            {
                var propOutput = propriedadesOutput.FirstOrDefault(p => p.Name == propInput.Name);

                if (propOutput != null)
                {
                    var valorInput = propInput.GetValue(objeto01);
                    propOutput.SetValue(objeto02, valorInput);
                }
            }

            return objeto02;
        }
    }
}
