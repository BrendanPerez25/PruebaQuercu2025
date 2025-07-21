using PruebaQuercu.Roles.Dto;
using System.Collections.Generic;

namespace PruebaQuercu.Web.Models.Common;

public interface IPermissionsEditViewModel
{
    List<FlatPermissionDto> Permissions { get; set; }
}