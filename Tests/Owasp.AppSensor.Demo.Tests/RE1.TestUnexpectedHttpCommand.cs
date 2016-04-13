using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Testing;
using Newtonsoft.Json;
using NUnit.Framework;
using Owasp.AppSensor.Demo.Api;

namespace Owasp.AppSensor.Demo.Tests
{
    [TestFixture]
    public class TestUnexpectedHttpCommand
    {
        [Test]
        public async Task TestGoodMethod()
        {
            try
            {
                using (var server = TestServer.Create<Startup>())
                {
                    var result = await server.HttpClient.GetAsync("api/book");
                    string responseContent = await result.Content.ReadAsStringAsync();
                    var entity = JsonConvert.DeserializeObject<List<string>>(responseContent);

                    Assert.IsTrue(entity.Count == 3);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
