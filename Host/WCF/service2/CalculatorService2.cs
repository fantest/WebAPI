using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace FanTest.WebAPI.Host
{
    [ServiceContract(Name = "CalculatorService2", Namespace = "")]
    public class CalculatorService2
    {
        [OperationContract]
        [WebGet(UriTemplate = "add/{strX},{strY}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public string Add(string strX, string strY)
        {
            double x, y;
            x = double.Parse(strX);
            y = double.Parse(strY);
            return (x + y).ToString();
        }
    }
}
