using NUnit.Framework;
using Owasp.AppSensor.Log.Sql.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owasp.AppSensor.Log.Sql.Test
{
    [TestFixture]
    public class LogTest
    {
        [Test]
        public void CanInitializeDatabase()
        {
            using (var context = new LogContext())
            {
                var aaa = context.Logs.ToList();
            }
            Assert.Pass("If we're here, it did not crash");
        }
    }
}
