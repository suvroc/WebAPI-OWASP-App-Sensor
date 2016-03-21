using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owasp.AppSensor.Core.Logging
{
    public class LogEvent
    {
        // When
        public DateTime EventTime { get; set; }
        public DateTime LogTime { get; set; }

        // Security event
        public EventType Type { get; set; }
        public SeverityLevel Severity { get; set; }
        public ConfidenceLevel Confidence { get; set; }
        public Classification Classification { get; set; }
        public string Owner { get; set; }

        // Location
        public string Host { get; set; }
        public string ApplicationName { get; set; }
        public string Port { get; set; }
        public string Protocol { get; set; }
        public HttpMethod HttpMethod { get; set; }
        public string EntryPoint { get; set; }
        public long RequestNumber { get; set; }

        // Request
        public string Purpose { get; set; }
        public string Target { get; set; }

        // User
        public string Source { get; set; }
        public string Identity { get; set; }
        public string HttpUserAgent { get; set; }
        public string ClientFingerprint { get; set; }

        // AppSensor detection
        public long SensorId { get; set; }
        public string SensorLocation { get; set; }
        public long DetectionPointId { get; set; }
        public string Description { get; set; }
        public string Message { get; set; }

        // Optional supporting details
    }
}
