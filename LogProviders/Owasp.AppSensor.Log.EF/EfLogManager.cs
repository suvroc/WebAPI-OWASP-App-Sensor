

using AutoMapper;
using Owasp.AppSensor.Core.Logging;
using Owasp.AppSensor.Core.Logging.Models;
using System;
using System.Linq;

namespace Owasp.AppSensor.Log.EF
{
    public class EfLogManager : ILogManager
    {
        private AppSensorLogContext _logContext;

        public EfLogManager(AppSensorLogContext logContext)
        {
            _logContext = logContext;
        }

        public void Log(LogEvent logEvent)
        {
            // TODO: remove obsolete statement
            var data = Mapper.DynamicMap<LogEvent, LogEventData>(logEvent);
            _logContext.LogEventData.Add(data);
            _logContext.SaveChanges();
        }

        public LogEvent GetLogItem(Guid id)
        {
            return Mapper.DynamicMap<LogEventData, LogEvent>(_logContext.LogEventData.SingleOrDefault(x => x.Id == id));
        }
    }
}
