using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace NET.Apis.Infrastructure.Persistences.Mssql
{
    public class MssqlAppDbContext(DbContextOptions<MssqlAppDbContext> options, IConfiguration configuration) : AppIdentityDbContext<MssqlAppDbContext>(options)
    {
        private string ConnectionString { get; set; } = configuration.GetConnectionString("MsSQl");

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (string.IsNullOrEmpty(ConnectionString) == false)
            {
                optionsBuilder.UseSqlServer(ConnectionString, b => b.MigrationsAssembly("NET.Apis.DbMigration"));
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
