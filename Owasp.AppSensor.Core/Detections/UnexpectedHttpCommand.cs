using System;
using System.Collections.Generic;

namespace Owasp.AppSensor.Core.Detections
{
    class UnexpectedHttpCommand : IDetectionPoint
    {
        public UnexpectedHttpCommand()
        {
            AllowedHttpMethods = new List<string>();
        }

        public List<string> AllowedHttpMethods { get; set; }

        public void Configure()
        {
            throw new NotImplementedException();
        }

        public bool Check(IDetectionPointData detectionPointData)
        {
            // TODO: ad implementation
            return true;
        }

        public string Name { get { return "Unexpected HTTP Command"; } }
        public DetectionPointType DetectionPointType { get { return DetectionPointType.UnexpectedHttpCommand; } }
        public string Code { get { return "RE2"; } }
    }
}
