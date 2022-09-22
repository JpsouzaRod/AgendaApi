using AgendaApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AgendaApi.Usecase
{
    public interface IUsecaseEvento
    {
        Task<IEnumerable<EventoResponse>> ListarEventos();
        Task<EventoResponse> BuscarEventos(string titulo);
    }
}
