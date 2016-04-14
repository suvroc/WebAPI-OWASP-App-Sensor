using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owasp.AppSensor.Core.Responses
{
    interface IEventResponse
    {
        void ExecuteAction();
        void Configure();
    }
}
