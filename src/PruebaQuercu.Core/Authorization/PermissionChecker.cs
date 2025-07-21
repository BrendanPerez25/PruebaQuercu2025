using Abp.Authorization;
using PruebaQuercu.Authorization.Roles;
using PruebaQuercu.Authorization.Users;

namespace PruebaQuercu.Authorization;

public class PermissionChecker : PermissionChecker<Role, User>
{
    public PermissionChecker(UserManager userManager)
        : base(userManager)
    {
    }
}
