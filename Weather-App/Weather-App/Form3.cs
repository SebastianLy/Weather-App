using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft;
using Newtonsoft.Json.Linq;

namespace Weather_App
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(User user)
        {
            InitializeComponent();
            if (user.Role != "Admin")
                button1.Visible = false;
        }

        private async void button1_Click(object sender, EventArgs e)
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
                MessageBox.Show(body);
                JObject jo = JObject.Parse(body);
                Weather weather = new Weather();
                weather.General = jo["weather"][0]["main"].ToString();
                weather.Description = jo["weather"][0]["description"].ToString();
                weather.Temperature = double.Parse(jo["main"]["temp"].ToString());
                weather.Temperaturemax = double.Parse(jo["main"]["temp_max"].ToString());
                weather.Temperaturemin = double.Parse(jo["main"]["temp_min"].ToString());
                weather.Pressure = double.Parse(jo["main"]["pressure"].ToString());
                weather.Humidity = double.Parse(jo["main"]["humidity"].ToString());
                weather.WindSpeed = double.Parse(jo["wind"]["speed"].ToString());
                weather.Date = DateTime.UtcNow;
                await Weather.AddWeather(weather);
            }
        }
    }
}
