using System;
using System.Net;
using System.Configuration;

namespace DemoHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string _apiurl = ConfigurationManager.AppSettings["APIURL"];
            LoadData obj = new LoadData();
            obj.HelloWorld(_apiurl);
           
        }
    }
  
}
