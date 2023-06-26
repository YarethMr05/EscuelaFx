using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Escuela.Modelo
{
    public class Evaluaciones
    {
        [Required]
        public int nota { get; set; }

        public DateTime FechaEcaluacion { get; set; }

        public int IdEstudiante { get; set; }
        [ForeignKey ("IdEstudiante")]
        public Estudiante Estudiante { get; set; }
       
        public int IdAsignatura { get; set; }
        [ForeignKey("IdAsignatura")]
        public Asignatura Asignatura { get; set; }

        

    }
}
