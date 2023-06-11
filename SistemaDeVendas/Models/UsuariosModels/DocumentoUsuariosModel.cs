using SistemaDeVendas.Enums;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models.UsuariosModels
{
    public class DocumentoUsuariosModel
    {
        public DocumentoUsuariosModel()
        {
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public TipoDocumentoUsuarios Tipo { get; set; }
        [Required]
        public byte[] FotoDocumento { get; set; }
        public int? UsuarioId { get; set; }
    }
}
