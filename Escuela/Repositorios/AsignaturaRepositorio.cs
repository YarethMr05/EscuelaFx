using Escuela.Datos;
using Escuela.Modelo;
using Escuela.Repositorios.IRepository;

namespace Escuela.Repositorios
{
    public class AsignaturaRepositorio : Repositorio<Asignatura>, IAsignatura
    {
        private readonly EscuelaContext _db;
        public AsignaturaRepositorio(EscuelaContext db) : base(db)
        {
            _db = db;

        }

        public async Task<Asignatura> Update(Asignatura entity)
        {
            _db.Asignatura.Update(entity);
            await _db.SaveChangesAsync();
            await Save();
            return entity;
        }
    }
}
