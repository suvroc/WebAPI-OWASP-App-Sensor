using Owasp.AppSensor.Core.Logging.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Owasp.AppSensor.Log.Sql.Configuration
{
    public class LogEventData
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }
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
        public string RequestHeaders { get; set; }
        public string RequestBody { get; set; }
        public string ResponseHeaders { get; set; }
        public string ReposnseBody { get; set; }
        public string ErrorStackTrace { get; set; }
        public string ErrorMessage { get; set; }
        public string OtherSystemResponse { get; set; }

        // Result
        public string Status { get; set; }
        public string Reason { get; set; }
        public int HttpStatusCode { get; set; }
        public long ResultResponseId { get; set; }
        public string ResultDescription { get; set; }
        public string ResultMessage { get; set; }

        // Record integrity
        public string Hash { get; set; }

    }
}
