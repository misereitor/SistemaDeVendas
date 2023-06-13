using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace SistemaDeVendas.Models.Permissoes
{
    public class GrupoPermissoesModel
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public string PermissoesJson { get; set; }

        [NotMapped]
        public Dictionary<string, PermissaoModel> Permissoes
        {
            get => JsonSerializer.Deserialize<Dictionary<string, PermissaoModel>>(PermissoesJson);
            set => PermissoesJson = JsonSerializer.Serialize(value);
        }
        public int EmpresaId { get; internal set; }
    }
}
