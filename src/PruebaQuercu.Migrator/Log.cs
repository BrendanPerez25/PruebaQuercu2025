using Abp.Dependency;
using Abp.Timing;
using Castle.Core.Logging;
using System;

namespace PruebaQuercu.Migrator;

public class Log : ITransientDependency
{
    public ILogger Logger { get; set; }

    public Log()
    {
        Logger = NullLogger.Instance;
    }

    public void Write(string text)
    {
        Console.WriteLine(Clock.Now.ToString("yyyy-MM-dd HH:mm:ss") + " | " + text);
        Logger.Info(text);
    }
}
