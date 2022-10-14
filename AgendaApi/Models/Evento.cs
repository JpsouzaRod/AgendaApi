using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace AgendaApi.Models
{
    public record Evento
    {
        public Evento(string id,
                      string titulo,
                      string local,
                      string dtHoraInicio,
                      string dtHoraFim)
        {
            Titulo = titulo;
            Local = local;
            DtHoraInicio = dtHoraInicio;
            DtHoraFim = dtHoraFim;
            Id = id is null ? Guid.NewGuid().ToString() : id;
        }

        [BsonId]
        public string Id { get; private set; }
        public string Titulo { get; set; }
        public string Local { get; set; }
        public string DtHoraInicio { get; set; }
        public string DtHoraFim { get; set; }
    }
}
