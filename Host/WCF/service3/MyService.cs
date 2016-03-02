using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FanTest.WebAPI.Host
{
    [ServiceContract(Name = "MyService", Namespace = "")]
    public class MyService
    {
        [OperationContract]
        [WebGet(UriTemplate = "ReadDT", ResponseFormat = WebMessageFormat.Json)]
        public DataTable ReadDataTable()
        {
            DataTable dt = new DataTable("T1");
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Note", typeof(string));

            for (int i = 0; i < 10; i++)
            {
                DataRow row = dt.NewRow();
                dt.Rows.Add(row);
                row["ID"] = Guid.NewGuid().ToString();
                row["Name"] = i.ToString();
            }

            return dt;
        }


        [OperationContract]
        [WebGet(UriTemplate = "employee/{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public Employee GetEmployee(string id)
        {
            Employee e = new Employee();
            e.Id = id;
            e.Name = "张三";
            e.Department = "测试";
            return e;
        }

        [OperationContract]
        [WebGet(UriTemplate = "/v1/{bizmain}/{objset}/{function}/{args}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public string CallBizFunc1(string bizmain, string objset, string function, string args)
        {
            return string.Format("调用领域方法[领域:{0}][分类:{1}][方法:{2}][参数:{3}]", bizmain, objset, function, args);
        }

        [OperationContract]
        [WebInvoke(UriTemplate = "/v1/{bizmain}/{objset}/{function}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public Stream CallBizFunc2(string bizmain, string objset, string function, Stream stream)
        {
            string strParam;
            try
            {
                using (StreamReader sr = new StreamReader(stream, Encoding.UTF8))
                {
                    strParam = sr.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                strParam = "<Err:" + ex.Message + ">";
            }

            byte[] buffer = Encoding.UTF8.GetBytes(string.Format("调用领域方法[领域:{0}][分类:{1}][方法:{2}][参数:{3}]",
                bizmain, objset, function, strParam));
            return new MemoryStream(buffer);
        }
    }




    [DataContract(Namespace = "http://www.zlsoft.com/")]
    public class Employee
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Department { get; set; }
    }
}
