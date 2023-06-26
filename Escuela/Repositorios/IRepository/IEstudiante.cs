using Escuela.Modelo;

namespace Escuela.Repositorios.IRepository
{
    public interface IEstudiante : IRepositorio<Estudiante>
    {
        Task<Estudiante> Update(Estudiante entity);
    }
}
