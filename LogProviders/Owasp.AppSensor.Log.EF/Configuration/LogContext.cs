using Microsoft.Data.Entity;
using Owasp.AppSensor.Log.EF.Configuration;
using Owasp.AppSensor.Log.EF.Models;
using System.Configuration;

namespace Owasp.AppSensor.Log.Sql.Configuration
{
    internal class LogContext : DbContext, ILogContext
    {
        public DbSet<LogEventData> Logs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Visual Studio 2015 | Use the LocalDb 12 instance created by Visual Studio
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["LogConnectionString"].ConnectionString);

            // Visual Studio 2013 | Use the LocalDb 11 instance created by Visual Studio
            // optionsBuilder.UseSqlServer(@"Server=(localdb)\v11.0;Database=EFGetStarted.ConsoleApp.NewDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Make Blog.Url required
            modelBuilder.Entity<LogEventData>()
                .Property(b => b.Id)
                .IsRequired();
        }
    }
}
