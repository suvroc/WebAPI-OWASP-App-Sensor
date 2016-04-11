using NUnit.Framework;
using Owasp.AppSensor.Core.Logging.Models;
using Owasp.AppSensor.Log.EF;
using Ploeh.AutoFixture;
using System;
using System.Linq;

namespace Owasp.AppSensor.Log.Sql.Test
{
    [TestFixture]
    public class EfLogTest
    {
        //[Test]
        //public void CanInitializeDatabase()
        //{
        //    using (var context = new AppSensorLogContext())
        //    {
        //        var aaa = context.LogEventData.ToList();
        //    }
        //    Assert.Pass("If we're here, it did not crash");
        //}

        //[Test]
        //public void ShouldLogInfo()
        //{
        //    Guid id = Guid.NewGuid();
        //    Fixture fixture = new Fixture();

        //    using (var context = new AppSensorLogContext())
        //    {
        //        var sqlLogManager = new ElLogManager(context);

        //        sqlLogManager.Log(new LogEvent()
        //        {
        //            Id = id,
        //            EventTime = DateTime.Now,
        //            LogTime = DateTime.Now
        //        });

        //        var loadedData = context.LogEventData.ToList();
        //        Assert.IsTrue(loadedData.Count() > 0);
        //    }
        //    Assert.Pass("If we're here, it did not crash");
        //}
    }
}
