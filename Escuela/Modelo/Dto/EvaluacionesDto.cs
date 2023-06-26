using System.ComponentModel.DataAnnotations;

namespace Escuela.Modelo.Dto
{
    public class EvaluacionesDto
    {
        [Required]
        public int nota { get; set; }
        public DateTime FechaEcaluacion { get; set; }
        public int IdEstudiante { get; set; }       
        public int IdAsignatura { get; set; }     

    }
}
