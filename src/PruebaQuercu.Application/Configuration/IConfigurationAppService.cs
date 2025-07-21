using PruebaQuercu.Configuration.Dto;
using System.Threading.Tasks;

namespace PruebaQuercu.Configuration;

public interface IConfigurationAppService
{
    Task ChangeUiTheme(ChangeUiThemeInput input);
}
