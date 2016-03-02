using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.ServiceModel.Web;

namespace FanTest.WebAPI.Host
{
    public class CalculatorService : ICalculator
    {
        public string Add(string strX, string strY)
        {
            //if (!CheckAuthorization())
            //    return null;

            double x, y;
            x = double.Parse(strX);
            y = double.Parse(strY);
            return (x + y).ToString();
        }

        public double Subtract(double x, double y)
        {
            return x - y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Divide(double x, double y)
        {
            return x / y;
        }

        private bool CheckAuthorization()
        {
            WebOperationContext ctx = WebOperationContext.Current;
            var auth = ctx.IncomingRequest.Headers[HttpRequestHeader.Authorization];
            if (string.IsNullOrEmpty(auth) || auth != "fan/123")
            {
                ctx.OutgoingResponse.StatusCode = HttpStatusCode.MethodNotAllowed;
                return false;
            }
            return true;
        }
    }
}
