using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace WeatherApi
{
    public class WeatherApi
    {
        private const string API_KEY = "2981a1562ee41583f22775632a4bfd63";
        private const string API_URL = "https://api.openweathermap.org/data/2.5/weather?";
        private const string DEFAULT_PARAMETERS = "&units=metric&lang=cz";
        public const string IMAGE_URL = "http://openweathermap.org/img/wn/";

        //https://api.openweathermap.org/data/2.5/weather?q=Úpice&appid=2981a1562ee41583f22775632a4bfd63&units=metric&lang=cz
        //q = město

        private WebClient _client;

        public WeatherApi()
        {
            _client = new WebClient();
            _client.Encoding = Encoding.UTF8;
        }

        public JObject GetJsonByCityName(string city)
        {

            try
            {
                string data = _client.DownloadString($"{API_URL}q={city}&appid={API_KEY}{DEFAULT_PARAMETERS}");

                return JObject.Parse(data);
            } catch (Exception e)
            {
                Debug.WriteLine(e);
            }

            return null;
        }
    }
}
