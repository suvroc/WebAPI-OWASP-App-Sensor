using System.Data.Entity.Migrations;

namespace Owasp.AppSensor.Log.Sql.Configuration
{
    internal sealed class Configuration : DbMigrationsConfiguration<LogContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
        protected override void Seed(LogContext context)
        {
        }
    }
}
