using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsConsoleApp.ProxyPattern
{
    public class Student
    {


        public void GetWeather()
        {
            Phone stPhone = new Phone();
            var weatherList = stPhone.GetWeather();
            foreach (var weather in weatherList)
            {
                Console.WriteLine($"Date: {weather.Date}, TempC: {weather.TemperatureC}, TempF: {weather.TemperatureF}, Summary: {weather.Summary}");
               
            }
        }
    }

    
}
