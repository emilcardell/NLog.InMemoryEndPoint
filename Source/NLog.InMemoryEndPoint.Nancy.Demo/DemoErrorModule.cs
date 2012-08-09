using Nancy;

namespace NLog.InMemoryEndPoint.Nancy.Demo
{
    public class DemoErrorModule : NancyModule
    {
        public DemoErrorModule()
        {
            Get["/CreateError"] = parameters =>
            {
                Logger logger = LogManager.GetLogger("Example");
                logger.Debug("log message");

                Logger logger2 = LogManager.GetLogger("Example2");
                logger2.Debug("log message");

                return "Error Logged";
            };
        }
    }
}