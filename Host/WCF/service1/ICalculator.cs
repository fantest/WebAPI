using System;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace FanTest.WebAPI.Host
{
    [ServiceContract(Name = "CalculatorService", Namespace = "")]
    public interface ICalculator
    {
        [OperationContract]
        [WebGet(UriTemplate = "add/{strX},{strY}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string Add(string strX, string strY);
    }
}
