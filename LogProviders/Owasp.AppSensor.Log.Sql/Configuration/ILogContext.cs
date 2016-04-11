using System.Data.Entity;

namespace Owasp.AppSensor.Log.Sql.Configuration
{
    public  interface ILogContext
    {
        DbSet<LogEventData> Logs { get; set; }
        int SaveChanges();
    }
}