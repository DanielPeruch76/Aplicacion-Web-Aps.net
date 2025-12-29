using RepositoryLayer.Context;
using RepositoryLayer.Repositories.Abstract;
using RepositoryLayer.Repositories.Concrete;
using RepositoryLayer.UnitOfWork.Abstract;


namespace RepositoryLayer.UnitOfWork.Concrete
{
    public class UnitOfWorks : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWorks(AppDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public ValueTask DisposeAsync()
        {
            return _context.DisposeAsync();
        }

        IGenericRepositories<T,PK> IUnitOfWork.GetGenericRepository<T,PK>()
        {
            return new GenericRepositories<T,PK>(_context);
        }
    }
}
