using Owasp.AppSensor.Core.Logging.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owasp.AppSensor.Log.Sql.Configuration
{
    internal class LogContext : DbContext
    {
        public LogContext() : base("LogConnectionString")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<LogContext>());
        }

        public DbSet<LogEvent> Logs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
