using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Escuela.Modelo
{
    public class Estudiante
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string? Nombre { get; set; }
        [Required]
        [StringLength(60)]
        public string? Apellido { get; set; }
        [Required]
        [StringLength(255)]
        public string? Direccion { get; set; }

    }
}
