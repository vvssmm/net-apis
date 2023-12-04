using NET.Apis.Domain.Data;

namespace NET.Apis.Persistence.EntityFramework.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            return new GenericRepository<TEntity>(_dbContext);
        }
        public int SaveChange()
        {
            return _dbContext.SaveChanges();
        }
        public Task SaveChangesAsync(CancellationToken cancellation)
        {
            return _dbContext.SaveChangesAsync(cancellation);
        }
        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
