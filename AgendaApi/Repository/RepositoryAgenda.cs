using AgendaApi.Data;
using AgendaApi.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AgendaApi.Repository
{
    public class RepositoryAgenda : IRepositoryAgenda
    {
        private readonly IMongoCollection<Evento> _agenda;
        public RepositoryAgenda(IDatabaseConfig databaseConfig)
        {
            var client = new MongoClient(databaseConfig.ConnectionString);
            _agenda = client.GetDatabase(databaseConfig.Database).GetCollection<Evento>("Eventos");
        }

        public async Task<bool> AlterarEvento(Evento evento)
        {
            var updateResult = await _agenda.ReplaceOneAsync(
                filter: g => g.Id == evento.Id,
                replacement: evento);

            return updateResult.IsAcknowledged
                && updateResult.ModifiedCount > 0;
        }

        public Evento BuscarEvento(string id)
        {
            return _agenda.Find(p => p.Id == id).FirstOrDefaultAsync().Result;
        }

        public async Task CadastrarEvento(Evento evento)
        {
            await _agenda.InsertOneAsync(evento);
        }

        public IEnumerable<Evento> ListarEventos()
        {
            return _agenda.Find(p => true).ToListAsync().Result;
        }

        public async Task<bool> RemoverEvento(string id)
        {
            FilterDefinition<Evento> filter = Builders<Evento>.Filter.Eq(p => p.Id, id);
            DeleteResult deleteResult = await _agenda.DeleteOneAsync(filter);

            return deleteResult.IsAcknowledged
                && deleteResult.DeletedCount > 0;

        }
    }
}
