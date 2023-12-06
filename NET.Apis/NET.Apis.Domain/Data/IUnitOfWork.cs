using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.Apis.Domain.Data
{
    public interface IUnitOfWork
    {
        DatabaseFacade GetDatabaseFacade();
        Task<int> SaveChangesAsync(CancellationToken cancellation);
        int SaveChanges();
        IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
    }
}
