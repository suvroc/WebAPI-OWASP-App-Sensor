using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Owasp.AppSensor.Log.EF
{
    public partial class AppSensorLogContext : DbContext, IAppSensorLogContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=localhost;Initial Catalog=AppSensorLog;Integrated Security=True;MultipleActiveResultSets=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LogEventData>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.LogTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<__MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey });

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasColumnType("varbinary");

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });
        }

        public virtual DbSet<LogEventData> LogEventData { get; set; }
        public virtual DbSet<__MigrationHistory> __MigrationHistory { get; set; }
    }
}