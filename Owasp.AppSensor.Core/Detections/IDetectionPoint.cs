using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owasp.AppSensor.Core.Detections
{
    interface IDetectionPoint
    {
        void Configure();

        bool Check(IDetectionPointData detectionPointData);

        string Name { get; }

        DetectionPointType DetectionPointType { get; }
        string Code { get; }
    }
}
