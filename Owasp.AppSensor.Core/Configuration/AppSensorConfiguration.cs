using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Owasp.AppSensor.Core.Detections;
using Owasp.AppSensor.Core.Responses;

namespace Owasp.AppSensor.Core.Configuration
{
    class AppSensorConfiguration
    {
        public AppSensorConfiguration()
        {
            DetectionPoints = new List<IDetectionPoint>();
            Responses = new List<IEventResponse>();
        }

        public List<IDetectionPoint> DetectionPoints { get; private set; } 

        public List<IEventResponse> Responses { get; private set; } 
    }
}
