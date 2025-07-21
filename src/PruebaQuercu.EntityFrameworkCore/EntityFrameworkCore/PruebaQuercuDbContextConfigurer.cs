using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace PruebaQuercu.EntityFrameworkCore;

public static class PruebaQuercuDbContextConfigurer
{
    public static void Configure(DbContextOptionsBuilder<PruebaQuercuDbContext> builder, string connectionString)
    {
        builder.UseSqlServer(connectionString);
    }

    public static void Configure(DbContextOptionsBuilder<PruebaQuercuDbContext> builder, DbConnection connection)
    {
        builder.UseSqlServer(connection);
    }
}
