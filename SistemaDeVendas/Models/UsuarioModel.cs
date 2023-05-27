namespace SistemaDeVendas.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Empresa { get; set; }
        public int CNPJ { get; set; }
        public string Funcao { get; set; }
        public bool Ativo { get; set; }
        public int Permissao { get; set; }

        public UsuarioModel()
        {
        }
        public UsuarioModel(int id, string nome, string email, string senha, string empresa, int cnpj, string funcao, bool ativo, int permissao)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Empresa = empresa;
            CNPJ = cnpj;
            Funcao = funcao;
            Ativo = ativo;
            Permissao = permissao;
        }
    }
}
