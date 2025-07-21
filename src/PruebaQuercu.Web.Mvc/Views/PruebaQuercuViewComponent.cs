using Abp.AspNetCore.Mvc.ViewComponents;

namespace PruebaQuercu.Web.Views;

public abstract class PruebaQuercuViewComponent : AbpViewComponent
{
    protected PruebaQuercuViewComponent()
    {
        LocalizationSourceName = PruebaQuercuConsts.LocalizationSourceName;
    }
}
