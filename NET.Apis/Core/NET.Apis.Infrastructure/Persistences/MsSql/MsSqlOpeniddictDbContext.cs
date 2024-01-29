using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace NET.Apis.Infrastructure.Persistences.Mssql
{
    public class MsSqlOpeniddictDbContext(DbContextOptions<MsSqlOpeniddictDbContext> options, IConfiguration configuration) : AppDbContext<MsSqlOpeniddictDbContext>(options)
    {
        private string ConnectionString { get; set; } = configuration.GetConnectionString("MsSQl:OpenidDict");

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (string.IsNullOrEmpty(ConnectionString) == false)
            {
                optionsBuilder.UseSqlServer(ConnectionString, b => b.MigrationsAssembly("NET.Apis.DbMigration"));
                optionsBuilder.UseOpenIddict();
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
