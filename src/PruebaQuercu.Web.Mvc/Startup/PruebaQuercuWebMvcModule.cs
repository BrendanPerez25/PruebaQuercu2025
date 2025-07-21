using Abp.Modules;
using Abp.Reflection.Extensions;
using PruebaQuercu.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace PruebaQuercu.Web.Startup;

[DependsOn(typeof(PruebaQuercuWebCoreModule))]
public class PruebaQuercuWebMvcModule : AbpModule
{
    private readonly IWebHostEnvironment _env;
    private readonly IConfigurationRoot _appConfiguration;

    public PruebaQuercuWebMvcModule(IWebHostEnvironment env)
    {
        _env = env;
        _appConfiguration = env.GetAppConfiguration();
    }

    public override void PreInitialize()
    {
        Configuration.Navigation.Providers.Add<PruebaQuercuNavigationProvider>();
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(PruebaQuercuWebMvcModule).GetAssembly());
    }
}
