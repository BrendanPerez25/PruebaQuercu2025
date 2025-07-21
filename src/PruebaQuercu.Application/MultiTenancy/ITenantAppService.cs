using Abp.Application.Services;
using PruebaQuercu.MultiTenancy.Dto;

namespace PruebaQuercu.MultiTenancy;

public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
{
}

