using Abp.Application.Services;
using PruebaQuercu.Authorization.Accounts.Dto;
using System.Threading.Tasks;

namespace PruebaQuercu.Authorization.Accounts;

public interface IAccountAppService : IApplicationService
{
    Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

    Task<RegisterOutput> Register(RegisterInput input);
}
