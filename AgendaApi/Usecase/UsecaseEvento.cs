using AgendaApi.Adapter;
using AgendaApi.Models;
using AgendaApi.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AgendaApi.Usecase
{
    public class UsecaseEvento : IUsecaseEvento
    {
        private readonly IRepositoryAgenda _agenda;
        private ServiceWeather service = new ServiceWeather();
        public IEnumerable<Forecast> _previsaoTempo { get; private set; }


        public UsecaseEvento(IRepositoryAgenda agenda)
        {
            _previsaoTempo = GetWeather();
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

        private IEnumerable<Forecast> GetWeather()
        {
            var weatherResponse = service.GetWeather().Result;
            return weatherResponse.Forecast;
        }
    }
}
