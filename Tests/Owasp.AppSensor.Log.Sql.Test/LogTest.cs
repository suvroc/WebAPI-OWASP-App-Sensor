using NUnit.Framework;
using Owasp.AppSensor.Core.Logging.Models;
using Owasp.AppSensor.Log.Sql.Configuration;
using Ploeh.AutoFixture;
using System;
using System.Linq;

namespace Owasp.AppSensor.Log.Sql.Test
{
    [TestFixture]
    public class LogTest
    {
        [Test]
        [Category("RequireDatabase")]
        public void CanInitializeDatabase()
        {
            using (var context = new LogContext())
            {
                var aaa = context.Logs.ToList();
            }
            Assert.Pass("If we're here, it did not crash");
        }

        [Test]
        [Category("RequireDatabase")]
        public void ShouldLogInfo()
        {
            Guid id = Guid.NewGuid();
            Fixture fixture = new Fixture();


            using (var context = new LogContext())
            {
                var sqlLogManager = new SqlLogManager(context);

                sqlLogManager.Log(new InternalLogEvent()
                {
                    Id = id,
                    EventTime = DateTime.Now,
                    LogTime = DateTime.Now
                });

                var loadedData = context.Logs.ToList();
                Assert.IsTrue(loadedData.Count() > 0);
            }
            Assert.Pass("If we're here, it did not crash");
        }
    }
}
