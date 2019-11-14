using Persistence.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistence.Repositories.Interfaces
{
    public interface IPersonaRepository
    {
        Task<IEnumerable<PersonaEntity>> GetPersonasAsync();
        Task<PersonaEntity> GetPersonaByIdAsync(int id);
        Task SavePersonaAsync(PersonaEntity persona);
        Task UpdatePersonaAsync(PersonaEntity persona);
        Task DeletePersonaByIdAsync(int id);
        Task<PersonaEntity> BuscarPersonaPorTipoDocumentoYNumero(int numeroDocId, string numeroDoc);
    }
}
