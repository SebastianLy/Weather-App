using System;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Weather_App
{
    class Weather
    {
        public int WeatherID { get; set; }
        public DateTime Date { get; set; }
        public string General { get; set; }
        public string Description { get; set; }
        public double Temperature { get; set; }
        public double Temperaturemax { get; set; }
        public double Temperaturemin { get; set; }
        public double Pressure { get; set; }
        public double Humidity { get; set; }
        public double WindSpeed { get; set; }

        private async static Task AddWeather(Weather weather)
        {
            using (var db = new WeatherContext())
            {
                db.Weathers.Add(weather);
                await db.SaveChangesAsync();
            }
        }

        public async static Task ConnectToAPI()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://rapidapi.p.rapidapi.com/weather?q=Warsaw%2Cpl&lat=0&lon=0&id=2172797&lang=en&units=metric"),
                Headers =
                {
                    { "x-rapidapi-host", "community-open-weather-map.p.rapidapi.com" },
                    { "x-rapidapi-key", "4c036d1935msh33f69cb8c1de538p18f1cbjsn2aaba1dbab11" },

                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                JObject jo = JObject.Parse(body);
                Weather weather = new Weather();
                weather.Date = DateTime.UtcNow;
                weather.General = jo["weather"][0]["main"].ToString();
                weather.Description = jo["weather"][0]["description"].ToString();
                weather.Temperature = double.Parse(jo["main"]["temp"].ToString());
                weather.Temperaturemax = double.Parse(jo["main"]["temp_max"].ToString());
                weather.Temperaturemin = double.Parse(jo["main"]["temp_min"].ToString());
                weather.Pressure = double.Parse(jo["main"]["pressure"].ToString());
                weather.Humidity = double.Parse(jo["main"]["humidity"].ToString());
                weather.WindSpeed = double.Parse(jo["wind"]["speed"].ToString());
                await AddWeather(weather);
            }
        }
    }

    class WeatherContext: DbContext
    {
        public DbSet<Weather> Weathers { get; set; }
    }
}
