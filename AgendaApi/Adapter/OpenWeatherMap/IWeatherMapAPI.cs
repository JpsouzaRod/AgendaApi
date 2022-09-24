using Refit;
using System.Threading.Tasks;

namespace AgendaApi.Adapter.OpenWeatherMap
{
    public interface IWeatherMapAPI
    {
        [Get("/data/2.5/forecast?lat=-1.455833&lon=-48.503887&cnt=40&appid=abb64352ef5be5b8f9679fd8e255f82d&lang=pt_br&units=metric")]
        Task <OpenWeatherResponse> GetWeather();
    }
}
