using Abp.MultiTenancy;
using PruebaQuercu.Authorization.Users;

namespace PruebaQuercu.MultiTenancy;

public class Tenant : AbpTenant<User>
{
    public Tenant()
    {
    }

    public Tenant(string tenancyName, string name)
        : base(tenancyName, name)
    {
    }
}
