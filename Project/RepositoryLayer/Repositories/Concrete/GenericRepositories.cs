using CoreLayer.BaseEntities;
using RepositoryLayer.Context;
using RepositoryLayer.Repositories.Abstract;
using System.Data.Entity;
using System.Linq.Expressions;

namespace RepositoryLayer.Repositories.Concrete
{
    public class GenericRepositories<T, PK> : IGenericRepositories<T, PK> where T:class,IBaseEntity<PK>, new()
    {
        private readonly AppDbContext _context;

        public GenericRepositories(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddEntityAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public void UpDateEntity(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void DeleteEntity(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public IQueryable<T> GetAllEntityList()
        {
            return _context.Set<T>().AsNoTracking().AsQueryable();
        }

        public IQueryable<T> Where(Expression<Func<T,bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }

        public async Task<T> GetEntityByIdAsync(PK id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
    }
}
