using Microsoft.EntityFrameworkCore;

namespace NET.Apis.Infrastructure.Persistences
{
    public class AppDbContext<TDbTypeContext>(DbContextOptions<TDbTypeContext> options) : DbContext(options) where TDbTypeContext : DbContext
    {
    }
}
