using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private readonly IPersonaService _personaService;

        public PersonasController(IPersonaService personaService)
        {
            _personaService = personaService;
        }

        [HttpGet]
        public async Task<IEnumerable<Persona>> GetPersonasAsync()
        {
            return await _personaService.GetPersonasAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Persona>> GetPersonaByIdAsync([Required] int id)
        {
            var persona = await _personaService.GetPersonaByIdAsync(id);

            if (persona is null)
            {
                return NotFound();
            }

            return persona;
        }

        [HttpPost]
        public async Task<ActionResult> SavePersonaAsync([FromBody] Persona persona)
        {
            await _personaService.SavePersonaAsync(persona);

            return StatusCode(StatusCodes.Status201Created,persona);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePersona(int id)
        {
            await _personaService.DeletePersonaByIdAsync(id);

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Persona>> UpdatePersonaAsync([Required] int id,[FromBody] Persona persona)
        {
            var personaExistente = await _personaService.GetPersonaByIdAsync(id);

            if (personaExistente is null)
            {
                return NotFound();
            }

            personaExistente.Nombre = persona.Nombre;
            personaExistente.Apellido = persona.Apellido;
            personaExistente.NroDocumento = persona.NroDocumento;
            personaExistente.Correo = persona.Correo;
            personaExistente.Telefono = persona.Telefono;

            await _personaService.UpdatePersonaAsync(personaExistente);

            return personaExistente;

        }
    }
}