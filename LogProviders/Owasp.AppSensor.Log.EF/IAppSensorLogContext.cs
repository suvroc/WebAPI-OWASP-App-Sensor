using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Owasp.AppSensor.Log.EF
{
    public partial interface IAppSensorLogContext
    {
        DbSet<LogEventData> LogEventData { get; set; }
        DbSet<__MigrationHistory> __MigrationHistory { get; set; }
    }
}