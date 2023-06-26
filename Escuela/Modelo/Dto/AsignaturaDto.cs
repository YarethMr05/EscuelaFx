using System.ComponentModel.DataAnnotations;

namespace Escuela.Modelo.Dto
{
    public class AsignaturaDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string? Nombre { get; set; }
    }
}
