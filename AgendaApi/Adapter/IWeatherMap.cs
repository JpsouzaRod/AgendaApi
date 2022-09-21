using Refit;
using System.Threading.Tasks;

namespace AgendaApi.Adapter
{
    public interface IWeatherMap
    {
        [Get("/weather?array_limit=7&fields=only_results,city_name,forecast,max,min,date,description&key=65ebc8c0&city_name={city}")]
        Task<WeatherResponse> GetWeather(string city);
    }
}
