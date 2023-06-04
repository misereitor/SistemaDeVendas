namespace SistemaDeVendas.Models.UsuariosModels.PermissaoUsuarioModels
{
    public class Permissoes
    {
        public int Id { get; set; }
        public bool? PodeAcessar { get; set; }
        public bool? PodeCriar { get; set; }
        public bool? PodeAlterar { get; set; }
        public bool? PodeExcluir { get; set; }
    }
}
