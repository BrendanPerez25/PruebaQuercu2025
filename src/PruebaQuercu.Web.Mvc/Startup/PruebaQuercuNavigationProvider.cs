﻿using Abp.Application.Navigation;
using Abp.Authorization;
using Abp.Localization;
using PruebaQuercu.Authorization;

namespace PruebaQuercu.Web.Startup;

/// <summary>
/// This class defines menus for the application.
/// </summary>
public class PruebaQuercuNavigationProvider : NavigationProvider
{
    public override void SetNavigation(INavigationProviderContext context)
    {
        context.Manager.MainMenu
            .AddItem(
                new MenuItemDefinition(
                    PageNames.About,
                    L("About"),
                    url: "About",
                    icon: "fas fa-info-circle"
                )
            )
            .AddItem(
                new MenuItemDefinition(
                    PageNames.TaskOwners,
                    L("Owners"),
                    url: "TaskOwner/Index",
                    icon: "fas fa-info-circle"
                )
            )
            .AddItem(
                new MenuItemDefinition(
                    PageNames.PropertyType,
                    L("PropertyType"),
                    url: "TaskPropertyType/Index",
                    icon: "fas fa-info-circle"
                )
            )
            .AddItem(
                new MenuItemDefinition(
                    PageNames.CreatePropertyType,
                    L("PropertyType"),
                    url: "TaskPropertyType/Create",
                    icon: "fas fa-info-circle"
                )
            )
            .AddItem(
                new MenuItemDefinition(
                    PageNames.TaskProperty,
                    L("Property"),
                    url: "TaskProperty/Index",
                    icon: "fas fa-info-circle"
                )
            )
            .AddItem(
                new MenuItemDefinition(
                    PageNames.Home,
                    L("HomePage"),
                    url: "",
                    icon: "fas fa-home",
                    requiresAuthentication: true
                )
            ).AddItem(
                new MenuItemDefinition(
                    PageNames.Tenants,
                    L("Tenants"),
                    url: "Tenants",
                    icon: "fas fa-building",
                    permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Tenants)
                )
            ).AddItem(
                new MenuItemDefinition(
                    PageNames.Users,
                    L("Users"),
                    url: "Users",
                    icon: "fas fa-users",
                    permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Users)
                )
            ).AddItem(
                new MenuItemDefinition(
                    PageNames.Roles,
                    L("Roles"),
                    url: "Roles",
                    icon: "fas fa-theater-masks",
                    permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Roles)
                )
            )
            .AddItem( // Menu items below is just for demonstration!
                new MenuItemDefinition(
                    "MultiLevelMenu",
                    L("MultiLevelMenu"),
                    icon: "fas fa-circle"
                ).AddItem(
                    new MenuItemDefinition(
                        "AspNetBoilerplate",
                        new FixedLocalizableString("ASP.NET Boilerplate"),
                        icon: "far fa-circle"
                    ).AddItem(
                        new MenuItemDefinition(
                            "AspNetBoilerplateHome",
                            new FixedLocalizableString("Home"),
                            url: "https://aspnetboilerplate.com?ref=abptmpl",
                            icon: "far fa-dot-circle",
                            target: "_blank"
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            "AspNetBoilerplateTemplates",
                            new FixedLocalizableString("Templates"),
                            url: "https://aspnetboilerplate.com/Templates?ref=abptmpl",
                            icon: "far fa-dot-circle",
                            target: "_blank"
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            "AspNetBoilerplateSamples",
                            new FixedLocalizableString("Samples"),
                            url: "https://aspnetboilerplate.com/Samples?ref=abptmpl",
                            icon: "far fa-dot-circle",
                            target: "_blank"
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            "AspNetBoilerplateDocuments",
                            new FixedLocalizableString("Documents"),
                            url: "https://aspnetboilerplate.com/Pages/Documents?ref=abptmpl",
                            icon: "far fa-dot-circle",
                            target: "_blank"
                        )
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        "AspNetZero",
                        new FixedLocalizableString("ASP.NET Zero"),
                        icon: "far fa-circle"
                    ).AddItem(
                        new MenuItemDefinition(
                            "AspNetZeroHome",
                            new FixedLocalizableString("Home"),
                            url: "https://aspnetzero.com?ref=abptmpl",
                            icon: "far fa-dot-circle",
                            target: "_blank"
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            "AspNetZeroFeatures",
                            new FixedLocalizableString("Features"),
                            url: "https://aspnetzero.com/Features?ref=abptmpl",
                            icon: "far fa-dot-circle",
                            target: "_blank"
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            "AspNetZeroPricing",
                            new FixedLocalizableString("Pricing"),
                            url: "https://aspnetzero.com/Pricing?ref=abptmpl#pricing",
                            icon: "far fa-dot-circle",
                            target: "_blank"
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            "AspNetZeroFaq",
                            new FixedLocalizableString("Faq"),
                            url: "https://aspnetzero.com/Faq?ref=abptmpl",
                            icon: "far fa-dot-circle",
                            target: "_blank"
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            "AspNetZeroDocuments",
                            new FixedLocalizableString("Documents"),
                            url: "https://aspnetzero.com/Documents?ref=abptmpl",
                            icon: "far fa-dot-circle",
                            target: "_blank"
                        )
                    )
                )
            );
    }

    private static ILocalizableString L(string name)
    {
        return new LocalizableString(name, PruebaQuercuConsts.LocalizationSourceName);
    }
}