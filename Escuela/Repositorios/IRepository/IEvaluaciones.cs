namespace Escuela.Repositorios.IRepository
{
    public interface IEvaluaciones : IRepositorio<IEvaluaciones>
    {
        Task<IEvaluaciones> Update(IEvaluaciones entity);
    }
}
