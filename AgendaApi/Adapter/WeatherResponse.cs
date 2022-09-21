using Newtonsoft.Json;
using System.Collections.Generic;

namespace AgendaApi.Adapter
{
    public record WeatherResponse
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("city_name")]
        public string City_name { get; set; }

        [JsonProperty("forecast")]
        public IEnumerable<Forecast> Forecast { get; set; }
    }

    public record Forecast
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("max")]
        public float Max { get; set; }

        [JsonProperty("min")]
        public float Min { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}