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
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaService _personaService;

        public PersonaController(IPersonaService personaService)
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
            persona.Id = id;
            await _personaService.UpdatePersonaAsync(persona);
            return Ok();
        }

        [HttpGet("personaid/{id}")]
        public async Task<ActionResult<Persona>> GetPersonaById([Required] int id)
        {
            return await _personaService.GetPersonaByIdAsync(id);
        } 

        [HttpGet("buscar")]
        public async Task<ActionResult<Persona>> ObtenerPersonaPorTipoDocumentoYNumeroDocumento([FromBody] Persona persona)
        {
            return await _personaService.ObtenerPersonaPorTipoDocumentoYNumeroDocumento(persona);
        }

    }
}