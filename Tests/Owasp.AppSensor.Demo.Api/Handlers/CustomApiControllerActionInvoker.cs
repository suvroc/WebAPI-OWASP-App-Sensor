﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;

namespace Owasp.AppSensor.Demo.Api.Handlers
{
    public class CustomApiControllerActionInvoker : ApiControllerActionInvoker
    {
        public override Task<HttpResponseMessage> InvokeActionAsync(HttpActionContext actionContext, CancellationToken cancellationToken)
        {
            var result = base.InvokeActionAsync(actionContext, cancellationToken);

            if (result.Exception != null && result.Exception.GetBaseException() != null)
            {
                var baseException = result.Exception.InnerExceptions[0];//result.Exception.GetBaseException();

                //if (baseException is BusinessLayerException)
                //{
                //    var baseExcept = baseException as BusinessLayerException;
                //    var errorMessagError = new System.Web.Http.HttpError(baseExcept.ErrorDescription)
                //    { { "ErrorCode", baseExcept.ErrorCode } };
                //    return Task.Run<HttpResponseMessage>(() =>
                //    actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, errorMessagError));
                //}
                //else if (baseException is DataLayerException)
                //{
                //    var baseExcept = baseException as DataLayerException;
                //    var errorMessagError = new System.Web.Http.HttpError(baseExcept.ErrorDescription)
                //    { { "ErrorCode", baseExcept.ErrorCode } };
                //    return Task.Run<HttpResponseMessage>(() =>
                //    actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, errorMessagError));
                //}
                //else
                {
                    var errorMessagError = new System.Web.Http.HttpError
                    ("Oops some internal Exception. Please contact your administrator")
                    { { "ErrorCode", 500 } };
                    return Task.Run<HttpResponseMessage>(() =>
                    actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, errorMessagError));
                }
            }

            return base.InvokeActionAsync(actionContext, cancellationToken);
        }
    }
}