using Nancy;

namespace NLog.InMemoryEndPoint.Nancy.Demo
{
    public class LogBootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(TinyIoC.TinyIoCContainer container, global::Nancy.Bootstrapper.IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);
            LogEngine.ConfigureDefaultInMemoryLog();
        }
    }
}