using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace WeatherApi
{
    public partial class Form1 : Form

    {
        private WeatherApi _api;

        public Form1()
        {
            InitializeComponent();

            _api = new WeatherApi();
        }

        private void _btnSearch_Click(object sender, EventArgs e)
        {
            string city = _txtCityName.Text;
            if (!string.IsNullOrWhiteSpace(city))
            {

                if (_api.GetJsonByCityName(city) != null)
                {
                    JObject weather = _api.GetJsonByCityName(city);

                    _lblTown.Text = city;
                    _lblTemp.Text = $"{weather["main"]["temp"]} °C ({weather["main"]["feels_like"]} °C)";
                    _lblDesc.Text = weather["weather"][0]["description"].ToString();
                    _lblWind.Text = $"{weather["wind"]["speed"]} m/s Směr: {weather["wind"]["deg"]}";
                    _lblCloudy.Text = weather["clouds"]["all"].ToString();
                    _lblHumidity.Text = weather["main"]["humidity"].ToString();
                    _lblSunrise.Text = GetDateTime(uint.Parse(weather["sys"]["sunrise"].ToString())).TimeOfDay.ToString();
                    _lblSunset.Text = GetDateTime(uint.Parse(weather["sys"]["sunrise"].ToString())).TimeOfDay.ToString();

                    _imgWeather.Load($"{WeatherApi.IMAGE_URL}{weather["weather"][0]["icon"]}@2x.png");
                } else
                {
                    MessageBox.Show("Toto město nelze nalézt v databázi!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private DateTime GetDateTime(uint timeInUnix)
        {
            DateTime dateTime = new DateTime(1970,1,1,0,0,0,0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(timeInUnix).ToLocalTime();

            return dateTime;
        }

    }
}
