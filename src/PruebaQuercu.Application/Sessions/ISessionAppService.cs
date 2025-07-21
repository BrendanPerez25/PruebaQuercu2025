using Abp.Application.Services;
using PruebaQuercu.Sessions.Dto;
using System.Threading.Tasks;

namespace PruebaQuercu.Sessions;

public interface ISessionAppService : IApplicationService
{
    Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
}
