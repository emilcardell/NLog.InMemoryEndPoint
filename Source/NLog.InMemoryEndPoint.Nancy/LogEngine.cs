using NLog.Targets;

namespace NLog.InMemoryEndPoint.Nancy
{
    public class LogEngine
    {
        public static MemoryTarget InMemoryTarget = new MemoryTarget();
        public static void ConfigureDefaultInMemoryLog()
        {
            InMemoryTarget.Layout = "${logger} - ${date} ::: ${message}";
            Config.SimpleConfigurator.ConfigureForTargetLogging(InMemoryTarget, LogLevel.Debug);
        }
    }
}
