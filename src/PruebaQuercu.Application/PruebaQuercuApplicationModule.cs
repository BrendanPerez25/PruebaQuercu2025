using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PruebaQuercu.Authorization;
using PruebaQuercu.Owner.Dto;
using PruebaQuercu.Property.Dto;

namespace PruebaQuercu;

[DependsOn(
    typeof(PruebaQuercuCoreModule),
    typeof(AbpAutoMapperModule))]
public class PruebaQuercuApplicationModule : AbpModule
{
    public override void PreInitialize()
    {
        Configuration.Authorization.Providers.Add<PruebaQuercuAuthorizationProvider>();

        Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
        {
            mapper.AddProfile<TaskOwnerMappingProfile>();
        });

        Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
        {
            cfg.AddProfile<TaskPropertyMappingProfile>();
        });

        Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
        {
            cfg.AddProfile<PropertyMappingProfile>();
        });

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
