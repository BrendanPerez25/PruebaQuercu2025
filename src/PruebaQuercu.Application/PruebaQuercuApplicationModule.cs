using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PruebaQuercu.Authorization;

namespace PruebaQuercu;

[DependsOn(
    typeof(PruebaQuercuCoreModule),
    typeof(AbpAutoMapperModule))]
public class PruebaQuercuApplicationModule : AbpModule
{
    public override void PreInitialize()
    {
        Configuration.Authorization.Providers.Add<PruebaQuercuAuthorizationProvider>();
    }

    public override void Initialize()
    {
        var thisAssembly = typeof(PruebaQuercuApplicationModule).GetAssembly();

        IocManager.RegisterAssemblyByConvention(thisAssembly);

        Configuration.Modules.AbpAutoMapper().Configurators.Add(
            // Scan the assembly for classes which inherit from AutoMapper.Profile
            cfg => cfg.AddMaps(thisAssembly)
        );
    }
}
