using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owasp.AppSensor.Core.Detections
{
    class InvokeUnsupportedHttpMethod : IDetectionPoint
    {
        public InvokeUnsupportedHttpMethod()
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

        public string Name { get { return "Attempt to Invoke Unsupported HTTP Method"; } }
        public DetectionPointType DetectionPointType { get; }
        public string Code { get { return "RE1"; } }
    }
}
