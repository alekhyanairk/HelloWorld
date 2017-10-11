using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Configuration;
namespace DemoHelloWorld
{
    public class LoadData
    {
        public void HelloWorld(string _apiurl) //Get All Events Records  
        {
            
            using (var client = new WebClient()) //WebClient  
            {
                client.Headers.Add("Content-Type:application/json"); //Content-Type  
                client.Headers.Add("Accept:application/json");
                var result = client.DownloadString(_apiurl); //URI  
                Console.WriteLine(Environment.NewLine + result);
                Console.ReadLine();
            }
        }
    }
}
