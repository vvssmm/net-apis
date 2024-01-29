﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace NET.Apis.Infrastructure.Persistences.Mssql
{
    public class MsSqlAppDbContext(DbContextOptions<MsSqlAppDbContext> options, IConfiguration configuration) : AppIdentityDbContext<MsSqlAppDbContext>(options)
    {
        private string ConnectionString { get; set; } = configuration.GetConnectionString("MsSQl:AppData");

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
