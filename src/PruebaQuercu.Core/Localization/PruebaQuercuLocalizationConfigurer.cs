using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace PruebaQuercu.Localization;

public static class PruebaQuercuLocalizationConfigurer
{
    public static void Configure(ILocalizationConfiguration localizationConfiguration)
    {
        localizationConfiguration.Sources.Add(
            new DictionaryBasedLocalizationSource(PruebaQuercuConsts.LocalizationSourceName,
                new XmlEmbeddedFileLocalizationDictionaryProvider(
                    typeof(PruebaQuercuLocalizationConfigurer).GetAssembly(),
                    "PruebaQuercu.Localization.SourceFiles"
                )
            )
        );
    }
}
