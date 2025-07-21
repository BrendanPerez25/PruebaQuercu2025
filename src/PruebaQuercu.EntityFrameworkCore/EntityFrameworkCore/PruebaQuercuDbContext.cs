using Abp.Zero.EntityFrameworkCore;
using PruebaQuercu.Authorization.Roles;
using PruebaQuercu.Authorization.Users;
using PruebaQuercu.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace PruebaQuercu.EntityFrameworkCore;

public class PruebaQuercuDbContext : AbpZeroDbContext<Tenant, Role, User, PruebaQuercuDbContext>
{
    /* Define a DbSet for each entity of the application */

    public PruebaQuercuDbContext(DbContextOptions<PruebaQuercuDbContext> options)
        : base(options)
    {
    }
}
