using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using Persistence.Entities;
using Persistence.Repositories.Interfaces;
using Services.Interfaces;

namespace Services
{
    public class PersonaService : IPersonaService
    {
        private readonly IPersonaRepository _personaRepository;
        private readonly IMapper _mapper;

        public PersonaService(IPersonaRepository personaRepository, IMapper mapper)
        {
            _personaRepository = personaRepository;
            _mapper = mapper;
        }

        public async Task DeletePersonaByIdAsync(int id)
        {
            await _personaRepository.DeletePersonaByIdAsync(id);
        }

        public async Task<Persona> GetPersonaByIdAsync(int id)
        {
            var personaEntity = await _personaRepository.GetPersonaByIdAsync(id);
            return _mapper.Map<Persona>(personaEntity); 
        }

        public async Task<IEnumerable<Persona>> GetPersonasAsync()
        {
            var personasEntity = await _personaRepository.GetPersonasAsync();
            var personas = _mapper.Map<IEnumerable<Persona>>(personasEntity);
            return personas;
        }
        public async Task UpdatePersonaAsync(Persona persona)
        {
            var pesonaEntidad = _mapper.Map<PersonaEntity>(persona);
            await _personaRepository.UpdatePersonaAsync(pesonaEntidad);

        }

        public async Task SavePersonaAsync(Persona persona)
        {
            var personaEntity = _mapper.Map<PersonaEntity>(persona);
            await _personaRepository.SavePersonaAsync(personaEntity);
        }

        public async Task<Persona> ObtenerPersonaPorTipoDocumentoYNumeroDocumento(Persona persona)
        {
            var personaEntity = await _personaRepository.BuscarPersonaPorTipoDocumentoYNumero(persona.TipoDocumentoIdentidadId,persona.NroDocumento);
            return _mapper.Map<Persona>(personaEntity);
        }
    }
}
