using PruebaQuercu.Roles.Dto;
using System.Collections.Generic;

namespace PruebaQuercu.Web.Models.Roles;

public class RoleListViewModel
{
    public IReadOnlyList<PermissionDto> Permissions { get; set; }
}
