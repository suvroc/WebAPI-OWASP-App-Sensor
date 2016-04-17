using Owasp.AppSensor.Core.Logging;
using Owasp.AppSensor.Core.Logging.Models;
using Owasp.AppSensor.Log.Sql.Configuration;
using AutoMapper;
using System;
using System.Linq;

namespace Owasp.AppSensor.Log.Sql
{
    // TODO: integrations with other systems
    public class SqlLogManager : ILogManager
    {
        private ILogContext _logContext;

        public SqlLogManager(ILogContext logContext)
        {
            _logContext = logContext;
        }

        public void Log(InternalLogEvent logEvent)
        {
            // TODO: remove obsolete statement
            var data = Mapper.DynamicMap<InternalLogEvent, LogEventData>(logEvent);
            _logContext.Logs.Add(data);
            _logContext.SaveChanges();
        }

        public InternalLogEvent GetLogItem(Guid id)
        {
            return Mapper.DynamicMap<LogEventData, InternalLogEvent>(_logContext.Logs.SingleOrDefault(x => x.Id == id));
        }
    }
}
