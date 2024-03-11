using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace weather2.Models
{
    internal class Weather
    {
        [JsonPropertyName("weather")]
        public List<WeatherInfo>? WeatherInfo { get; set; }

        [JsonPropertyName("main")]
        public Main? Main { get; set; }
    }
}
