using System;
using System.Collections.Generic;

namespace Owasp.AppSensor.Log.EF
{
    public partial class LogEventData
    {
        public Guid Id { get; set; }
        public string ApplicationName { get; set; }
        public int Classification { get; set; }
        public string ClientFingerprint { get; set; }
        public int Confidence { get; set; }
        public string Description { get; set; }
        public long DetectionPointId { get; set; }
        public string EntryPoint { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorStackTrace { get; set; }
        public DateTime EventTime { get; set; }
        public string Hash { get; set; }
        public string Host { get; set; }
        public int HttpMethod { get; set; }
        public int HttpStatusCode { get; set; }
        public string HttpUserAgent { get; set; }
        public string Identity { get; set; }
        public DateTime LogTime { get; set; }
        public string Message { get; set; }
        public string OtherSystemResponse { get; set; }
        public string Owner { get; set; }
        public string Port { get; set; }
        public string Protocol { get; set; }
        public string Purpose { get; set; }
        public string Reason { get; set; }
        public string ReposnseBody { get; set; }
        public string RequestBody { get; set; }
        public string RequestHeaders { get; set; }
        public long RequestNumber { get; set; }
        public string ResponseHeaders { get; set; }
        public string ResultDescription { get; set; }
        public string ResultMessage { get; set; }
        public long ResultResponseId { get; set; }
        public long SensorId { get; set; }
        public string SensorLocation { get; set; }
        public int Severity { get; set; }
        public string Source { get; set; }
        public string Status { get; set; }
        public string Target { get; set; }
        public int Type { get; set; }
    }
}
