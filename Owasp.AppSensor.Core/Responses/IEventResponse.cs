using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owasp.AppSensor.Core.Responses
{
    // https://www.owasp.org/index.php/AppSensor_ResponseActions
    interface IEventResponse
    {
        void ExecuteAction();
        void Configure();
    }
}
