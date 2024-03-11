using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace weather2.Models
{
    internal class WeatherInfo
    {
        [JsonPropertyName("description")]
        public string? Main { get; set; }

        [JsonPropertyName("icon")]
        public string? Icon { get; set; }
    }
}
