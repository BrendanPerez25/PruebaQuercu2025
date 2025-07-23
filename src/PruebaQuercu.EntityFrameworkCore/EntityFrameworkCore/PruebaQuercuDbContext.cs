using Abp.Zero.EntityFrameworkCore;
using PruebaQuercu.Authorization.Roles;
using PruebaQuercu.Authorization.Users;
using PruebaQuercu.MultiTenancy;
using Microsoft.EntityFrameworkCore;
using PruebaQuercu.Property;
using PruebaQuercu.PropertyType;
using PruebaQuercu.Owner;

namespace PruebaQuercu.EntityFrameworkCore;

public class PruebaQuercuDbContext : AbpZeroDbContext<Tenant, Role, User, PruebaQuercuDbContext>
{
    /* Define a DbSet for each entity of the application */
    public DbSet<TaskProperty> Propertys { get; set; }

    public DbSet<TaskPropertyType> PropertyTypes { get; set; }

    public DbSet<TaskOwner> Owners { get; set; }

    public PruebaQuercuDbContext(DbContextOptions<PruebaQuercuDbContext> options)
        : base(options)
    {
    }
}
