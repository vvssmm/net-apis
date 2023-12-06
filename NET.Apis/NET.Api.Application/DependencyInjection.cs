using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using NET.Apis.Domain.Data.QueueService;
using NET.Apis.Domain.NetCoreIdentity;
using NET.Apis.Persistence.EntityFramework;

namespace NET.Api.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            //services.AddMediatR()
            services.AddNetCoreIdentity();
            services.AddSingleton<IListService, ListService>();
            return services;
        }

        private static IServiceCollection AddNetCoreIdentity(this IServiceCollection services)
        {
            services.AddIdentityCore<AplicationUser>()
            .AddEntityFrameworkStores<ApplicationDbContext>();
            services.Configure<IdentityOptions>(options =>
            {
                // Password settings.
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;

                // Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                // User settings.
                options.User.AllowedUserNameCharacters =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = false;
            });
    
            return services;
        }
    }
}