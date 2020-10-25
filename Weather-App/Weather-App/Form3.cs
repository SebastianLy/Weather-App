using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

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
            await Weather.ConnectToAPI();
            await dataGridViewPopulate();            
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
            table.Columns.Add("Temperature [°C]", typeof(double));
            table.Columns.Add("Temperature Max [°C]", typeof(double));
            table.Columns.Add("Temperature Min [°C]", typeof(double));
            table.Columns.Add("Pressure [hPa]", typeof(double));
            table.Columns.Add("Humidity [%]", typeof(double));
            table.Columns.Add("Wind Speed [km/h]", typeof(double));
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
            dataWeather.Columns[9].Width = 91;
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
