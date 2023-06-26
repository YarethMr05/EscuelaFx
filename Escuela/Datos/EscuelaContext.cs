using Escuela.Modelo;
using Microsoft.EntityFrameworkCore;

namespace Escuela.Datos
{
    public class EscuelaContext : DbContext
    {
        public EscuelaContext(DbContextOptions<EscuelaContext> options) : base(options)
        {

        }

        DbSet<Asignatura> Asignatura { get; set; }
        DbSet<Estudiante> Estudiantes { get; set; }
        DbSet<Evaluaciones> Evalaciones { get; set; }

    }
}
