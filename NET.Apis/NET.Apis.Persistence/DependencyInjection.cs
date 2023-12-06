using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NET.Apis.Persistence.EntityFramework;
using static NET.Apis.Shared.Enums;

namespace NET.Apis.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistences(this IServiceCollection services, DbTypes dbType,string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString) == false)
            {
                switch (dbType)
                {
                    case DbTypes.ORACLE:
                        break;
                    case DbTypes.POSTGRE_SQL:
                        services.AddDbContextFactory<ApplicationDbContext>(o => o.UseNpgsql(connectionString));
                        break;
                    default:
                        services.AddDbContextFactory<ApplicationDbContext>(o => o.UseSqlite(connectionString));
                        break;
                }
            }
            return services;
        }
    }
}
