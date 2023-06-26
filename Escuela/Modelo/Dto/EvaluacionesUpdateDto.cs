﻿using System.ComponentModel.DataAnnotations;

namespace Escuela.Modelo.Dto
{
    public class EvaluacionesUpdateDto
    {
        [Required]
        public int nota { get; set; }
        public int IdEstudiante { get; set; }
        public int IdAsignatura { get; set; }
    }
}
