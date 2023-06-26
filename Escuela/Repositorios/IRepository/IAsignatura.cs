using Escuela.Modelo;

namespace Escuela.Repositorios.IRepository
{
    public interface IAsignatura : IRepositorio<Asignatura>
    {
        Task<Asignatura> Update(Asignatura entity);
    }
}
