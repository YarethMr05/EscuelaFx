using System.ComponentModel.DataAnnotations;

namespace Escuela.Modelo.Dto
{
    public class AsignaturaCrearDto
    {
        [Required]
        [StringLength(30)]
        public string? Nombre { get; set; }
    }
}
