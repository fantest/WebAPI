using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Text;

namespace FanTest.WebAPI.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            //要先添加urlacl，否则需要以管理员身份运行。

            WebServiceHost wsHost = new WebServiceHost(typeof(CalculatorService));
            wsHost.Open();
            ServiceEndpoint endpoinit = wsHost.Description.Endpoints[0];
            Console.WriteLine("{0,-8}: {1}", "Address", endpoinit.Address);
            Console.WriteLine("{0,-8}: {1}", "Binding", endpoinit.Binding);
            Console.WriteLine("{0,-8}: {1}", "Contract", endpoinit.Contract.ContractType);
            Console.WriteLine("");

            WebServiceHost wsHost2 = new WebServiceHost(typeof(CalculatorService2));
            wsHost2.Open();
            endpoinit = wsHost2.Description.Endpoints[0];
            Console.WriteLine("{0,-8}: {1}", "Address", endpoinit.Address);
            Console.WriteLine("{0,-8}: {1}", "Binding", endpoinit.Binding);
            Console.WriteLine("{0,-8}: {1}", "Contract", endpoinit.Contract.ContractType);
            Console.WriteLine("");

            WebServiceHost wsHost3 = new WebServiceHost(typeof(MyService));
            wsHost3.Open();
            endpoinit = wsHost3.Description.Endpoints[0];
            Console.WriteLine("{0,-8}: {1}", "Address", endpoinit.Address);
            Console.WriteLine("{0,-8}: {1}", "Binding", endpoinit.Binding);
            Console.WriteLine("{0,-8}: {1}", "Contract", endpoinit.Contract.ContractType);
            Console.WriteLine("");

            Console.WriteLine("测试地址:");
            Console.WriteLine("http://localhost:8800/service3/v1/MPI/PKG_PAT_ARCH/GET_PAT_CARD_INFO$LIST/id=1");
            Console.WriteLine("http://localhost:8800/service3/ReadDT");
            Console.WriteLine("http://localhost:8800/service3/employee/1");
            Console.WriteLine("http://localhost:8800/service3/help");
            Console.WriteLine("");
            Console.WriteLine("按回车键(Enter)关闭服务...");
            Console.ReadLine();
            wsHost.Close();
            wsHost2.Close();
            wsHost3.Close();
        }
    }
}


/*
//ServiceHost serviceHost = new ServiceHost(typeof(CalculatorService));
//WSHttpBinding binding = new WSHttpBinding();
//serviceHost.AddServiceEndpoint(typeof(ICalculator), binding, "http://localhost:8800/service");
////ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
////behavior.HttpGetEnabled = true;
////behavior.HttpGetUrl = new Uri("http://localhost:8800/service");
////serviceHost.Description.Behaviors.Add(behavior);
//serviceHost.Open();
//serviceHost.Close();
                       

//WebServiceHost wsHost = new WebServiceHost(typeof(CalculatorService),
//    new Uri("http://localhost:8800/service"));

//var listener = new HttpListener();
//listener.Prefixes.Add("http://localhost:8000/webconsole/");
//listener.Start();
//Console.WriteLine("listening");
//while (true)
//{
//    HttpListenerContext context = listener.GetContext();
//}
*/