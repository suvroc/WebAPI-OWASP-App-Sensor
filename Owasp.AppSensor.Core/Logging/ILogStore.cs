using Owasp.AppSensor.Core.Logging.Models;

namespace Owasp.AppSensor.Core.Logging
{
    interface ILogStore
    {
        void Log(LogEvent logEvent);
    }
}
