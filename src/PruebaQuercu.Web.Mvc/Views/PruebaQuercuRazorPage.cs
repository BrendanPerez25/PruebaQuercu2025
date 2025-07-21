using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace PruebaQuercu.Web.Views;

public abstract class PruebaQuercuRazorPage<TModel> : AbpRazorPage<TModel>
{
    [RazorInject]
    public IAbpSession AbpSession { get; set; }

    protected PruebaQuercuRazorPage()
    {
        LocalizationSourceName = PruebaQuercuConsts.LocalizationSourceName;
    }
}
