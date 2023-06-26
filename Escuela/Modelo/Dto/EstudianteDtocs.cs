using System.ComponentModel.DataAnnotations;

namespace Escuela.Modelo.Dto
{
    public class EstudianteDtocs
    {
        public int IdEstudiante { get; set; }
        [Required]
        [StringLength(60)]
        public string? Nombre { get; set; }
        [Required]
        public string? Apellido { get; set; }
        [Required]
        [StringLength(255)]
        public string? Direccion { get; set; }

    }
}
