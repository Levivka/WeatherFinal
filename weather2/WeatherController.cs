using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using weather2.Models;

namespace weather2
{
    internal class WeatherController
    {
        public HttpClient client = new HttpClient();


        public async Task<Weather> GetWeather(string city)
        {
            try
            {
                string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid=d397a995d6b587ba479889ad3dc3cf56&units=metric";
                var resp = await client.GetFromJsonAsync<Weather>(url);
                return resp;
            }
            catch
            {
                return null;
            }
        }
    }
}
