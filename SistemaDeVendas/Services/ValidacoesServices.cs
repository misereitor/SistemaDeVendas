using System.Text.RegularExpressions;

namespace SistemaDeVendas.Services
{
    public class ValidacoesServices
    {
        public bool ValidarSenha(string senha) 
        {
            if (string.IsNullOrEmpty(senha))
            {
                return false;
            }
            if (senha.Length < 8)
            {
                return false;
            }
            if (!LetrasMaiusculas(senha))
            {
                Console.WriteLine(senha);
                return false;
            }
            if (!LetrasMinusculas(senha))
            {
                return false;
            }
            if (!Numeros(senha))
            {
                return false;
            }
            if (!Simbolos(senha))
            {
                return false;
            }
            return true;
        }

        private static bool LetrasMaiusculas(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[A-Z]", "").Length;
            Console.WriteLine(rawplacar);
            if (rawplacar <= 0)
            {
                return false;
            }
            return true;
        }

        private static bool LetrasMinusculas(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[a-z]", "").Length;
            if (rawplacar <= 0)
            {
                return false;
            }
            return true;
        }

        private static bool Numeros(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[0-9]", "").Length;
            if (rawplacar <= 0)
            {
                return false;
            }
            return true;
        }

        private static bool Simbolos(string senha)
        {
            int rawplacar = Regex.Replace(senha, "[a-zA-Z0-9]", "").Length;
            if (rawplacar <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
