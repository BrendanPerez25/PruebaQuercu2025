using PruebaQuercu.Roles.Dto;
using System.Collections.Generic;

namespace PruebaQuercu.Web.Models.Users;

public class UserListViewModel
{
    public IReadOnlyList<RoleDto> Roles { get; set; }
}
