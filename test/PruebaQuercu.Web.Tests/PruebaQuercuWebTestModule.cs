using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PruebaQuercu.EntityFrameworkCore;
using PruebaQuercu.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace PruebaQuercu.Web.Tests;

[DependsOn(
    typeof(PruebaQuercuWebMvcModule),
    typeof(AbpAspNetCoreTestBaseModule)
)]
public class PruebaQuercuWebTestModule : AbpModule
{
    public PruebaQuercuWebTestModule(PruebaQuercuEntityFrameworkModule abpProjectNameEntityFrameworkModule)
    {
        abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
    }

    public override void PreInitialize()
    {
        Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(PruebaQuercuWebTestModule).GetAssembly());
    }

    public override void PostInitialize()
    {
        IocManager.Resolve<ApplicationPartManager>()
            .AddApplicationPartsIfNotAddedBefore(typeof(PruebaQuercuWebMvcModule).Assembly);
    }
}