using CoreLayer.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories.Abstract
{
    public interface IGenericRepositories<T, PK> where T:class,IBaseEntity<PK>, new()
    {
        Task AddEntityAsync(T entity);
        void UpDateEntity(T entity);
        void DeleteEntity(T entity);
        IQueryable<T> GetAllEntityList();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<T> GetEntityByIdAsync(PK id);

        }
}
