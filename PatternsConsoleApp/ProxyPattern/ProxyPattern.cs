using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PatternsConsoleApp.ProxyPattern
{
    public class ProxyPattern
    {

    }
    public class Phone
    {
       private HttpClient client = new HttpClient();
        public List<WeatherForecast> LastLoadedWeather = new List<WeatherForecast>();

        public List<WeatherForecast> GetWeather()
        {
            try
            {
                var task = Task.Run(() => client.GetAsync("http://localhost:5018/WeatherForecast"));
                task.Wait();
                HttpResponseMessage response = task.Result;
                var weather2 = response.Content;
                var weather3 = weather2.ReadAsStringAsync().Result;

                List<WeatherForecast>? weatherForecast =
                JsonSerializer.Deserialize<List<WeatherForecast>>(weather3);

                LastLoadedWeather = new List<WeatherForecast>(weatherForecast);

                //Console.WriteLine(response.Content);
               
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            return LastLoadedWeather;
        }


    }
}
