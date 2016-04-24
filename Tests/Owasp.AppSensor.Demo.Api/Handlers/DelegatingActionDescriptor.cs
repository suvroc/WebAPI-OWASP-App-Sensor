using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Owasp.AppSensor.Demo.Api.Handlers
{
    public class DelegatingActionDescriptor : HttpActionDescriptor
    {
        private readonly string _actionName;
        private readonly HttpActionDescriptor _originalActionDescriptor;

        public DelegatingActionDescriptor(string actionName, HttpActionDescriptor originalActionDescriptor)
        {
            _actionName = actionName;
            _originalActionDescriptor = originalActionDescriptor;
        }

        public override string ActionName
        {
            get { return _actionName; }
        }

        public override Task<object> ExecuteAsync(HttpControllerContext controllerContext, IDictionary<string, object> arguments, System.Threading.CancellationToken cancellationToken)
        {
            return _originalActionDescriptor.ExecuteAsync(controllerContext, arguments, cancellationToken);
        }

        public override Collection<HttpParameterDescriptor> GetParameters()
        {
            return _originalActionDescriptor.GetParameters();
        }

        public override Type ReturnType
        {
            get { return _originalActionDescriptor.ReturnType; }
        }

        public override HttpActionBinding ActionBinding
        {
            get
            {
                return _originalActionDescriptor.ActionBinding;
            }
            set
            {
                _originalActionDescriptor.ActionBinding = value;
            }
        }

        public override bool Equals(object obj)
        {
            return _originalActionDescriptor.Equals(obj);
        }

        public override Collection<T> GetCustomAttributes<T>()
        {
            return _originalActionDescriptor.GetCustomAttributes<T>();
        }

        public override Collection<FilterInfo> GetFilterPipeline()
        {
            return _originalActionDescriptor.GetFilterPipeline();
        }

        public override Collection<IFilter> GetFilters()
        {
            return _originalActionDescriptor.GetFilters();
        }

        public override int GetHashCode()
        {
            return _originalActionDescriptor.GetHashCode();
        }

        public override ConcurrentDictionary<object, object> Properties
        {
            get
            {
                return _originalActionDescriptor.Properties;
            }
        }

        public override IActionResultConverter ResultConverter
        {
            get
            {
                return _originalActionDescriptor.ResultConverter;
            }
        }

        public override Collection<HttpMethod> SupportedHttpMethods
        {
            get
            {
                return _originalActionDescriptor.SupportedHttpMethods;
            }
        }
    }
}