using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Data.Entity;
using Newtonsoft.Json.Linq;

namespace Weather_App
{
    public partial class Form3 : Form
    {
        DataTable table = new DataTable("Weathers");
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(User user)
        {
            InitializeComponent();
            if (user.Role != "Admin")
                refreshButton.Visible = false;
        }

        private async void refreshButton_Click(object sender, EventArgs e)
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
                await Weather.AddWeather(weather);
                await dataGridViewPopulate();
            }
        }

        private async Task dataGridViewPopulate()
        {
            using (var db = new WeatherContext())
            {
                var weathers = await (from weather in db.Weathers orderby weather.Date descending select weather).ToListAsync();               
                table.Clear();
                foreach (Weather weather in weathers)
                {
                    table.Rows.Add(weather.WeatherID, weather.Date, weather.General, weather.Description, weather.Temperature, weather.Temperaturemax,
                        weather.Temperaturemin, weather.Pressure, weather.Humidity, weather.WindSpeed);
                }
            }
        }

        private async void Form3_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Date", typeof(string));
            table.Columns.Add("General", typeof(string));
            table.Columns.Add("Description", typeof(string));
            table.Columns.Add("Temperature", typeof(double));
            table.Columns.Add("Temperature Max", typeof(double));
            table.Columns.Add("Temperature Min", typeof(double));
            table.Columns.Add("Pressure", typeof(double));
            table.Columns.Add("Humidity", typeof(double));
            table.Columns.Add("Wind Speed", typeof(double));
            await dataGridViewPopulate();
            dataWeather.DataSource = table;
            dataWeather.Columns[0].Width = 30;
            dataWeather.Columns[1].Width = 106;
            dataWeather.Columns[3].Width = 110;
            dataWeather.Columns[4].Width = 74;
            dataWeather.Columns[5].Width = 74;
            dataWeather.Columns[6].Width = 74;
            dataWeather.Columns[7].Width = 60;
            dataWeather.Columns[8].Width = 60;
            dataWeather.Columns[9].Width = 80;
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            string date = searchTextBox.Text;
            using (var db = new WeatherContext())
            {
                var weathers = await(from weather in db.Weathers orderby weather.Date descending select weather).ToListAsync();
                table.Clear();
                foreach (Weather weather in weathers)
                {
                    if (weather.Date.ToString().Contains(date))
                    {
                        table.Rows.Add(weather.WeatherID, weather.Date, weather.General, weather.Description, weather.Temperature, weather.Temperaturemax,
                        weather.Temperaturemin, weather.Pressure, weather.Humidity, weather.WindSpeed);
                    }                   
                }
            }
        }
    }
}
