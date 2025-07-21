using Abp.Authorization;
using Abp.Runtime.Session;
using PruebaQuercu.Configuration.Dto;
using System.Threading.Tasks;

namespace PruebaQuercu.Configuration;

[AbpAuthorize]
public class ConfigurationAppService : PruebaQuercuAppServiceBase, IConfigurationAppService
{
    public async Task ChangeUiTheme(ChangeUiThemeInput input)
    {
        await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
    }
}
