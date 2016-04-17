

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

        public void Log(InternalLogEvent logEvent)
        {
            // TODO: remove obsolete statement
            var data = Mapper.DynamicMap<InternalLogEvent, LogEventData>(logEvent);
            _logContext.LogEventData.Add(data);
            _logContext.SaveChanges();
        }

        public InternalLogEvent GetLogItem(Guid id)
        {
            return Mapper.DynamicMap<LogEventData, InternalLogEvent>(_logContext.LogEventData.SingleOrDefault(x => x.Id == id));
        }
    }
}
