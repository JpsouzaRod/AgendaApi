using Refit;
using System.Threading.Tasks;

namespace AgendaApi.Adapter
{
    public class ServiceWeather
    {
        public async Task<WeatherResponse> GetWeather(string city)
        {
            var weatherMap = RestService.For<IWeatherMap>("https://api.hgbrasil.com");
            return await weatherMap.GetWeather(city);
        }
    }
}
