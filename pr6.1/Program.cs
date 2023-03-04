using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace _6
{
    
    internal class Program
    {
        
        static  void Main(string[] args)
        {
            Console.WriteLine("Введите город в котором хотите посмотреть градусы");
            string gorod = Console.ReadLine();
            string url = "https://api.openweathermap.org/data/2.5/weather?q="+gorod+"&units=metric&appid=d73a22636ce225fd4f1d095e2952190b";
            

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            
            
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string response;

            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream())) 
            {
                response = streamReader.ReadToEnd();
                //Console.WriteLine(response);
            }

            WeatherRes weatherRes = JsonConvert.DeserializeObject<WeatherRes>(response);

            Console.WriteLine("в {0} сейчас {1} градусов", weatherRes.Name,weatherRes.main.Temp);

        }

       
    }
}
