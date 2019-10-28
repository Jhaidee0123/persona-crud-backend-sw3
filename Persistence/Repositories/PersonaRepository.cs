using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;
using Persistence.Entities;
using Persistence.Repositories.Interfaces;

namespace Persistence.Repositories
{
    public class PersonaRepository : IPersonaRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public PersonaRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task DeletePersonaByIdAsync(int id)
        {
            var persona = await _dbContext.Personas.FirstOrDefaultAsync(persona => persona.Id == id);
            _dbContext.Personas.Remove(persona);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<PersonaEntity> GetPersonaByIdAsync(int id)
        {
            return await _dbContext.Personas.FirstOrDefaultAsync(persona => persona.Id == id);
        }

        public async Task<IEnumerable<PersonaEntity>> GetPersonasAsync()
        {
            return await _dbContext.Personas.ToListAsync();
        }
        public async Task UpdatePersonaAsync(PersonaEntity persona)
        {
            _dbContext.Personas.Update(persona);
            await _dbContext.SaveChangesAsync();
        }

        public async Task SavePersonaAsync(PersonaEntity persona)
        {
            _dbContext.Personas.Add(persona);
            await _dbContext.SaveChangesAsync();
        }

    }
}
