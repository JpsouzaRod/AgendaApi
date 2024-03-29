﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace AgendaApi.Adapter.OpenWeatherMap
{
    public class OpenWeatherResponse
    {
        public string cod { get; set; }
        public int message { get; set; }
        public int cnt { get; set; }
        public IEnumerable<Forecast> list { get; set; }
        public City city { get; set; }
    }
    public record Forecast
    {
        public int dt { get; set; }
        public Main main { get; set; }
        public IEnumerable<Weather> weather { get; set; }
        public Clouds clouds { get; set; }
        public Wind wind { get; set; }
        public int visibility { get; set; }
        public float pop { get; set; }
        public Sys sys { get; set; }
        public string dt_txt { get; set; }
    }

    public record Main
    {
        public double temp { get; set; }
        public double feels_like { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public int pressure { get; set; }
        public int sea_level { get; set; }
        public int grnd_level { get; set; }
        public int humidity { get; set; }
        public double temp_kf { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }
    public record Clouds
    {
        public int all { get; set; }
    }

    public class Wind
    {
        public double speed { get; set; }
        public int deg { get; set; }
        public double gust { get; set; }
    }

    public class rain
    {
        [JsonProperty("3h")]
        public float hourly { get; set; }
    }

    public class Sys
    {
        public string pod { get; set; }
    }

    public class City
    {
        public int id { get; set; }
        public string name { get; set; }
        public Coord coord { get; set; }
        public string country { get; set; }
        public double population { get; set; }
        public double timezone { get; set; }
        public double sunrise { get; set; }
        public double sunset { get; set; }
    }

    public class Coord
    {
        public double lat { get; set; }
        public double lon { get; set; }
    }
}