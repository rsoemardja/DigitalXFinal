using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Script.Serialization;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Json;

namespace DigitalXMVC.Models
{
    public class CustomerService
    {
        private string BASE_URL = "http://localhost:10583/AuthService.svc";

        public bool create(CustomerService customer)
        {
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Customer));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, customer);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webclient = new WebClient();
                webclient.Headers["Content-type"] = "application/json";
                webclient.Encoding = Encoding.UTF8;
                webclient.UploadString(BASE_URL + "create", "post", data);

                return true;
            }
            catch
            {

                return false;
            }
        }


    }
}