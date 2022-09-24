namespace AgendaApi.Models
{
    public class EventoResponse
    {
        public EventoResponse(Evento evento, PrevisaoTempo previsaoTempo)
        {
            Evento = evento;
            PrevisaoTempo = previsaoTempo;
        }

        public Evento Evento { get; set; }
        public PrevisaoTempo PrevisaoTempo { get; set; }
    }
}
