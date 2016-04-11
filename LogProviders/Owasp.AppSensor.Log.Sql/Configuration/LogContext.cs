using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Owasp.AppSensor.Log.Sql.Configuration
{
    internal class LogContext : DbContext, ILogContext
    {
        public LogContext() : base("LogConnectionString")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<LogContext>());
        }

        public DbSet<LogEventData> Logs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
