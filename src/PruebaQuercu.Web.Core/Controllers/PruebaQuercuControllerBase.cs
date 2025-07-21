using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace PruebaQuercu.Controllers
{
    public abstract class PruebaQuercuControllerBase : AbpController
    {
        protected PruebaQuercuControllerBase()
        {
            LocalizationSourceName = PruebaQuercuConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
