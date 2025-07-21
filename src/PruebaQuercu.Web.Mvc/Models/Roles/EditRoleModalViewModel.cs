using Abp.AutoMapper;
using PruebaQuercu.Roles.Dto;
using PruebaQuercu.Web.Models.Common;

namespace PruebaQuercu.Web.Models.Roles;

[AutoMapFrom(typeof(GetRoleForEditOutput))]
public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
{
    public bool HasPermission(FlatPermissionDto permission)
    {
        return GrantedPermissionNames.Contains(permission.Name);
    }
}
