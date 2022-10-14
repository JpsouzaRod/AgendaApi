using AgendaApi.Adapter;
using AgendaApi.Adapter.OpenWeatherMap;
using AgendaApi.Models;
using AgendaApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaApi.Usecase
{
    public interface IUsecaseEvento
    {
        IEnumerable<EventoResponse> ListarEventos();
        EventoResponse BuscarEvento(string id);
    }
    public class UsecaseEvento : IUsecaseEvento
    {
        private readonly IRepositoryAgenda _agenda;
        private WeatherMapAPI service = new WeatherMapAPI();
        private IEnumerable<Forecast> _forecast;
        public UsecaseEvento(IRepositoryAgenda agenda)
        {
            _agenda = agenda;
            _forecast = service.GetWeather().Result.list;
        }

        public EventoResponse BuscarEvento(string id)
        {
            var evento = _agenda.BuscarEvento(id);

            var forecast = _forecast.Select(x => new
            {
                day = DateTime.Parse(x.dt_txt),
                temp_max = x.main.temp_max,
                temp_min = x.main.temp_min,
                description = x.weather.FirstOrDefault().description,
                pop = x.pop * 100
            })
                .OrderBy(x => Math.Abs(x.day.Ticks - DateTime.Parse(evento.DtHoraInicio).Ticks))
                .FirstOrDefault();

            var previsao = new PrevisaoTempo(forecast);

            return new EventoResponse(evento, previsao);
        }

        public IEnumerable<EventoResponse> ListarEventos()
        {
            var eventos = _agenda.ListarEventos();
            var _forecast = service.GetWeather().Result.list;
            var lista = new List<EventoResponse>();

            eventos = eventos.Where(x => DateTime.Parse(x.DtHoraInicio) <= DateTime.Now.AddDays(5));

            foreach (var evento in eventos)
            {
                var forecast = _forecast.Select(x => new
                {
                    day = DateTime.Parse(x.dt_txt),
                    temp_max = x.main.temp_max,
                    temp_min = x.main.temp_min,
                    description = x.weather.FirstOrDefault().description,
                    pop = x.pop * 100
                })
                .OrderBy(x => Math.Abs(x.day.Ticks - DateTime.Parse(evento.DtHoraInicio).Ticks))
                .FirstOrDefault();

                var previsao = new PrevisaoTempo(forecast);

                lista.Add(new EventoResponse(evento, previsao));
            }

            return lista;
        }
    }
}
