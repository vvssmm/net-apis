using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NET.Apis.Infrastructure.Persistences
{
    public class AppIdentityDbContext<TDbTypeContext>(DbContextOptions<TDbTypeContext> options) : IdentityDbContext<IdentityUser>(options) where TDbTypeContext : DbContext
    {
    }
}
