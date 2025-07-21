using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PruebaQuercu.Configuration;
using PruebaQuercu.EntityFrameworkCore;
using PruebaQuercu.Migrator.DependencyInjection;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;

namespace PruebaQuercu.Migrator;

[DependsOn(typeof(PruebaQuercuEntityFrameworkModule))]
public class PruebaQuercuMigratorModule : AbpModule
{
    private readonly IConfigurationRoot _appConfiguration;

    public PruebaQuercuMigratorModule(PruebaQuercuEntityFrameworkModule abpProjectNameEntityFrameworkModule)
    {
        abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

        _appConfiguration = AppConfigurations.Get(
            typeof(PruebaQuercuMigratorModule).GetAssembly().GetDirectoryPathOrNull()
        );
    }

    public override void PreInitialize()
    {
        Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
            PruebaQuercuConsts.ConnectionStringName
        );

        Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        Configuration.ReplaceService(
            typeof(IEventBus),
            () => IocManager.IocContainer.Register(
                Component.For<IEventBus>().Instance(NullEventBus.Instance)
            )
        );
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(PruebaQuercuMigratorModule).GetAssembly());
        ServiceCollectionRegistrar.Register(IocManager);
    }
}
