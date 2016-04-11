using Microsoft.Data.Entity;
using Owasp.AppSensor.Log.EF.Models;

namespace Owasp.AppSensor.Log.EF.Configuration
{
    public  interface ILogContext
    {
        DbSet<LogEventData> Logs { get; set; }
        int SaveChanges();
    }
}