using Refit;
using System.Threading.Tasks;

namespace AgendaApi.Adapter.OpenWeatherMap
{
    public class WeatherMapAPI : IWeatherMapAPI
    {
        public async Task<OpenWeatherResponse> GetWeather()
        {
            var weatherMap = RestService.For<IWeatherMapAPI>("https://api.openweathermap.org");
            return await weatherMap.GetWeather();
        }
    }
}
