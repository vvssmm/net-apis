using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using NET.Apis.Domain.Data;

namespace NET.Apis.Persistence.EntityFramework.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(IDbContextFactory<ApplicationDbContext> contextFactory)
        {
            _dbContext = contextFactory.CreateDbContext();
        }

        public IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            return new GenericRepository<TEntity>(_dbContext);
        }
        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }
        public Task<int> SaveChangesAsync(CancellationToken cancellation)
        {
            return _dbContext.SaveChangesAsync(cancellation);
        }
        public DatabaseFacade GetDatabaseFacade()
        {
            return _dbContext.Database;
        }
        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
