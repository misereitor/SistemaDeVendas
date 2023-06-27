using SistemaDeVendas.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeVendas.Models.UsuariosModels
{
    [Table("documentoUsuarios")]
    public class DocumentoUsuariosModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public TipoDocumentoUsuarios Tipo { get; set; }
        [Required]
        public byte[] FotoDocumento { get; set; }
        public DateTimeOffset DataCriacao { get; set; } = DateTimeOffset.UtcNow;

        public DocumentoUsuariosModel(int id, TipoDocumentoUsuarios tipo, byte[] fotoDocumento)
        {
            Id = id;
            Tipo = tipo;
            FotoDocumento = fotoDocumento;
        }
    }
}
