using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace SistemaDeVendas.Models.Permissoes
{
    [Table("grupoPermissoes")]
    public class GrupoPermissoesModel
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string PermissoesJson { get; set; } = string.Empty;

        [NotMapped]
        public Dictionary<string, PermissaoModel>? Permissoes
        {
            get
            {
                try
                {
                    return JsonSerializer.Deserialize<Dictionary<string, PermissaoModel>>(PermissoesJson);
                }
                catch (JsonException ex)
                {
                    // Lida com a exceção de desserialização aqui, se necessário
                    Console.WriteLine($"Erro de desserialização JSON: {ex.Message}");
                    return null; // Retorna null ou um valor padrão, se a desserialização falhar
                }
            }
            set => PermissoesJson = JsonSerializer.Serialize(value);
        }

        public GrupoPermissoesModel()
        {
        }

        public GrupoPermissoesModel(int id, string nome, string permissoesJson, Dictionary<string, PermissaoModel>? permissoes)
        {
            Id = id;
            Nome = nome;
            PermissoesJson = permissoesJson;
            Permissoes = permissoes;
        }
    }
}
