using System.ComponentModel.DataAnnotations;

using MessagePack;

namespace L01PO2_2020CD603.Models
{
    public class Publicaciones
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int publicacionId { get; set; }
        public string? titulo { get; set; }
        public string? descripcion { get; set; }
        public int usuarioId { get; set; }


    }
}
