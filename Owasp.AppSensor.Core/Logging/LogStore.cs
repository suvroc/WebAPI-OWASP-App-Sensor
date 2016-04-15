using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Owasp.AppSensor.Core.Logging.Models;

namespace Owasp.AppSensor.Core.Logging
{
    class LogStore : ILogStore
    {
        private readonly ILogManager _logManager;

        public LogStore(ILogManager logManager)
        {
            _logManager = logManager;
        }

        public void Log(LogEvent logEvent)
        {
            // TODO: here we can add a message to Engine task queue
            _logManager.Log(logEvent);
        }
    }
}
