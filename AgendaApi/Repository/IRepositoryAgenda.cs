using AgendaApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AgendaApi.Repository
{
    public interface IRepositoryAgenda
    {
        Task CadastrarEvento(Evento evento);
        Task<bool> AlterarEvento(Evento evento);
        Evento BuscarEvento(string titulo);
        IEnumerable<Evento> ListarEventos();
        Task<bool> RemoverEvento(string titulo);

    }
}
