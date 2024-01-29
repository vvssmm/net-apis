using Microsoft.EntityFrameworkCore;

namespace NET.Apis.Infrastructure.Persistences
{
    public class AppDbContext<TDbTypeContext> :DbContext where TDbTypeContext : DbContext
    {
        public AppDbContext(DbContextOptions<TDbTypeContext> options) :base (options)
        {

        }
	}
}
