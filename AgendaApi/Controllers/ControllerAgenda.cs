using AgendaApi.Models;
using AgendaApi.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AgendaApi.Controller
{

    [Route("api/v1/")]
    [ApiController]
    public class ControllerAgenda : ControllerBase
    {
        private readonly IRepositoryAgenda _agenda;
        public ControllerAgenda(IRepositoryAgenda agenda)
        {
            _agenda = agenda;
        }


        [HttpGet]
        [Route("agenda")]
        public ActionResult<IEnumerable<Evento>> ListarEventos()
        {
            return Ok(_agenda.ListarEventos());
        }

        [HttpGet]
        [Route("agenda/{id}")]
        public async Task<ActionResult<Evento>> BuscarEvento(string id)
        {
            var evento = _agenda.BuscarEvento(id);
            if (evento == null)
            {
                return NotFound();
            }
            return Ok(evento);
        }

        [HttpPost]
        [Route("agenda")]
        public async Task<ActionResult<Evento>> CadastrarEvento(Evento evento)
        {
            await _agenda.CadastrarEvento(evento);
            return Created("", (evento));
        }

        [HttpPut]
        [Route("agenda")]
        public async Task<ActionResult> AlterarEvento(Evento evento)
        {
            var eventoAtualizado = await _agenda.AlterarEvento(evento);

            if (!eventoAtualizado)
            {
                return NotFound();
            }
            return Ok(eventoAtualizado);
        }

        [HttpDelete]
        [Route("agenda")]
        public async Task<ActionResult> RemoverEvento(string id)
        {
            var eventoRemovido = await _agenda.RemoverEvento(id);

            if (!eventoRemovido)
            {
                return NotFound();
            }
            return Ok(eventoRemovido);
        }
    }
}
