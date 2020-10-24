using System;
using System.Data.Entity;
using System.Threading.Tasks;

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
        public async static Task AddWeather(Weather weather)
        {
            using (var db = new WeatherContext())
            {
                db.Weathers.Add(weather);
                await db.SaveChangesAsync();
            }
        }
    }

    class WeatherContext: DbContext
    {
        public DbSet<Weather> Weathers { get; set; }
    }
}
