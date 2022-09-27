using AgendaApi.Adapter;
using AgendaApi.Adapter.OpenWeatherMap;
using AgendaApi.Models;
using AgendaApi.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AgendaApi.Usecase
{
    public class UsecaseEvento : IUsecaseEvento
    {
        private readonly IRepositoryAgenda _agenda;
        private WeatherMapAPI service = new WeatherMapAPI();

        public UsecaseEvento(IRepositoryAgenda agenda)
        {
            _agenda = agenda;
        }

        public Task<EventoResponse> BuscarEventos(string titulo)
        {
            var eventos = _agenda.BuscarEvento(titulo);
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<EventoResponse>> ListarEventos()
        {
            var eventos = _agenda.ListarEventos();
            throw new System.NotImplementedException("teste");
        }
    }
}
