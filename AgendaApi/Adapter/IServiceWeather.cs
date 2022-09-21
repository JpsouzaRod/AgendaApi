using System.Threading.Tasks;

namespace AgendaApi.Adapter
{
    public interface IServiceWeather
    {
        Task<WeatherResponse> GetWeather(string city);
    }
}
