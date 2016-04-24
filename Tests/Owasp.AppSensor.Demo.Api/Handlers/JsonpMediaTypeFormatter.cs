using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace Owasp.AppSensor.Demo.Api.Handlers
{
    public class JsonpMediaTypeFormatter : JsonMediaTypeFormatter
    {
        private readonly string _callbackQueryParameter;

        public JsonpMediaTypeFormatter(string callbackQueryParameter)
        {
            _callbackQueryParameter = callbackQueryParameter ?? "callback";
            SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/json"));
            SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/javascript"));
        }

        public JsonpMediaTypeFormatter() : this(null) { }

        private string CallbackFunction { get; set; }


        public override Task WriteToStreamAsync(Type type, object value, Stream writeStream, HttpContent content, TransportContext transportContext)
        {
            var isJsonp = !string.IsNullOrEmpty(CallbackFunction);

            return Task.Factory.StartNew(() =>
            {
                using (StreamWriter streamWriter = new StreamWriter(writeStream))
                {
                    if (isJsonp)
                    {
                        streamWriter.Write(CallbackFunction + "(");
                        streamWriter.Flush();
                    }

                    base.WriteToStreamAsync(type, value, writeStream, content, transportContext).Wait();

                    if (isJsonp)
                    {
                        streamWriter.Write(")");
                        streamWriter.Flush();
                    }
                }
            });
        }

        public override MediaTypeFormatter GetPerRequestFormatterInstance(Type type, HttpRequestMessage request, MediaTypeHeaderValue mediaType)
        {
            var formatter = new JsonpMediaTypeFormatter(_callbackQueryParameter)
            {
                CallbackFunction = GetJsonCallbackFunction(request)
            };

            return formatter;
        }

        private string GetJsonCallbackFunction(HttpRequestMessage request)
        {
            if (request.Method != HttpMethod.Get) return null;

            var query = request.RequestUri.ParseQueryString();
            var queryVal = query[_callbackQueryParameter];

            if (string.IsNullOrEmpty(queryVal)) return null;

            return queryVal;
        }
    }
}