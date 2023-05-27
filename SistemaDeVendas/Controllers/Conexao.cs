using Npgsql;

namespace SistemaDeVendas.Controllers
{
    public class Conexao
    {
        public static NpgsqlConnection GetConexao()
        {
            String dadosDeCoenxão = "Server=localhost;Port=5432;User Id=postgres;Password=V!V#tc%001;Database=sistemadevendas;";
            NpgsqlConnection? conexao = new NpgsqlConnection(dadosDeCoenxão);
            try
            {
                conexao.Open();
            }catch (Exception ex)
            {
                Console.WriteLine("Erro de Conexão: " + ex.Message);
            }
            return conexao;
        }

        public static void SetFechaConexao(NpgsqlConnection conexao)
        {
            if(conexao != null)
            {
                try
                {
                    conexao.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao fechar a conexão: " + ex.Message);
                }
            }
        }
    }
}
