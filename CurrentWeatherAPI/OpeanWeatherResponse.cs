namespace CurrentWeatherAPI
{
    public class OpeanWeatherResponse
    {
        public Main Main { get; set; }
    }

    public class WeatherDescription
    {
        public string Main { get; set; }
    }

    public class Main
    {
        public string Temp { get; set; }
    }
}