using Abp.AutoMapper;
using Abp.Configuration.Startup;
using Abp.Dependency;
using Abp.Modules;
using Abp.Net.Mail;
using Abp.TestBase;
using Abp.Zero.Configuration;
using Abp.Zero.EntityFrameworkCore;
using PruebaQuercu.EntityFrameworkCore;
using PruebaQuercu.Tests.DependencyInjection;
using Castle.MicroKernel.Registration;
using NSubstitute;
using System;

namespace PruebaQuercu.Tests;

[DependsOn(
    typeof(PruebaQuercuApplicationModule),
    typeof(PruebaQuercuEntityFrameworkModule),
    typeof(AbpTestBaseModule)
    )]
public class PruebaQuercuTestModule : AbpModule
{
    public PruebaQuercuTestModule(PruebaQuercuEntityFrameworkModule abpProjectNameEntityFrameworkModule)
    {
        abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        abpProjectNameEntityFrameworkModule.SkipDbSeed = true;
    }

    public override void PreInitialize()
    {
        Configuration.UnitOfWork.Timeout = TimeSpan.FromMinutes(30);
        Configuration.UnitOfWork.IsTransactional = false;

        // Disable static mapper usage since it breaks unit tests (see https://github.com/aspnetboilerplate/aspnetboilerplate/issues/2052)
        Configuration.Modules.AbpAutoMapper().UseStaticMapper = false;

        Configuration.BackgroundJobs.IsJobExecutionEnabled = false;

        // Use database for language management
        Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

        RegisterFakeService<AbpZeroDbMigrator<PruebaQuercuDbContext>>();

        Configuration.ReplaceService<IEmailSender, NullEmailSender>(DependencyLifeStyle.Transient);
    }

    public override void Initialize()
    {
        ServiceCollectionRegistrar.Register(IocManager);
    }

    private void RegisterFakeService<TService>() where TService : class
    {
        IocManager.IocContainer.Register(
            Component.For<TService>()
                .UsingFactoryMethod(() => Substitute.For<TService>())
                .LifestyleSingleton()
        );
    }
}
