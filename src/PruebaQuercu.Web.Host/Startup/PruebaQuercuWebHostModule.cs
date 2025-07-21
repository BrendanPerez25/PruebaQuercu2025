using Abp.Modules;
using Abp.Reflection.Extensions;
using PruebaQuercu.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace PruebaQuercu.Web.Host.Startup
{
    [DependsOn(
       typeof(PruebaQuercuWebCoreModule))]
    public class PruebaQuercuWebHostModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PruebaQuercuWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PruebaQuercuWebHostModule).GetAssembly());
        }
    }
}
