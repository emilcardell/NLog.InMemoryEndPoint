using System;
using System.Linq;
using Nancy;

namespace NLog.InMemoryEndPoint.Nancy
{
    public class EndPointModule : NancyModule
    {
        public EndPointModule()
        {
            Get["/Logs"] = parameters => Response.AsJson(LogEngine.InMemoryTarget.Logs.Take(100));
            Get["/Logs/{loggerName}"] = parameters => Response.AsJson(LogEngine.InMemoryTarget.Logs.Where(log => log.StartsWith(parameters.loggerName + " -", StringComparison.InvariantCultureIgnoreCase)).Take(100));
        }
    }
}
