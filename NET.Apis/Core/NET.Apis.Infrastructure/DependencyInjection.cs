using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using NET.Apis.Infrastructure.Persistences.Mssql;

namespace NET.Apis.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAspNetCoreIdentityInfra(this IServiceCollection services)
        {
            //services.AddIdentityCore<AplicationUser>()
            //.AddEntityFrameworkStores<ApplicationDbContext>();
           

            return services;
        }

    }
}