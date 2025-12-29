using CoreLayer.BaseEntities;
using RepositoryLayer.Repositories.Abstract;
namespace RepositoryLayer.UnitOfWork.Abstract
{
    public interface IUnitOfWork
    {
        void Commit();
        Task CommitAsync();
        IGenericRepositories<T, PK> GetGenericRepository<T, PK>() where T: class,IBaseEntity<PK>,new();
        ValueTask DisposeAsync();
    }
}
