using PruebaQuercu.Debugging;

namespace PruebaQuercu;

public class PruebaQuercuConsts
{
    public const string LocalizationSourceName = "PruebaQuercu";

    public const string ConnectionStringName = "Default";

    public const bool MultiTenancyEnabled = true;


    /// <summary>
    /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
    /// </summary>
    public static readonly string DefaultPassPhrase =
        DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "b197a7298a08489593bea739f3d76d39";
}
