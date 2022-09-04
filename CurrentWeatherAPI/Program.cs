using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;

namespace CurrentWeatherAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var weatherURL = "https://api.openweathermap.org/data/2.5/weather?q=jacksonville&appid=785e70a516418c2508b78cd5ce39e1f2&units=imperial";

            var client = new HttpClient();

            var response = client.GetStringAsync(weatherURL).Result;

            var result = JsonConvert.DeserializeObject<OpeanWeatherResponse>(response);

            var temp = result.Main.Temp;

            Console.WriteLine($"The temperature in Jacksonville is: {temp}");
        }
    }
}