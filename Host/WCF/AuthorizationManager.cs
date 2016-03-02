using System;
using System.Collections.Generic;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace FanTest.WebAPI.Host
{
    public class AuthorizationManager : ServiceAuthorizationManager
    {
        protected override bool CheckAccessCore(OperationContext operationContext)
        {
            //WebOperationContext ctx = WebOperationContext.Current;
            //var auth = ctx.IncomingRequest.Headers[HttpRequestHeader.Authorization];
            //if (string.IsNullOrEmpty(auth) || auth != "fan/123")
            //{
            //    ctx.OutgoingResponse.StatusCode = HttpStatusCode.MethodNotAllowed;
            //    return false;
            //}
            return true;
                        
            //WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.Unauthorized;
        }
    }
}
