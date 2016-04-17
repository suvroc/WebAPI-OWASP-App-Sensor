using Owasp.AppSensor.Core.Logging.Models;

namespace Owasp.AppSensor.Core.Logging
{
    public interface ILogManager
    {
        void Log(InternalLogEvent logEvent);
    }
}
