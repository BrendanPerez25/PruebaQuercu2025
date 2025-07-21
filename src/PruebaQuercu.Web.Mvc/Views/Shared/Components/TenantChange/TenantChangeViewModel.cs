using Abp.AutoMapper;
using PruebaQuercu.Sessions.Dto;

namespace PruebaQuercu.Web.Views.Shared.Components.TenantChange;

[AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
public class TenantChangeViewModel
{
    public TenantLoginInfoDto Tenant { get; set; }
}
