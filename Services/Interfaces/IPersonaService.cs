using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IPersonaService
    {
        Task<IEnumerable<Persona>> GetPersonasAsync();
        Task<Persona> GetPersonaByIdAsync(int id);
        Task SavePersonaAsync(Persona persona);
        Task DeletePersonaByIdAsync(int id);
        Task UpdatePersonaAsync(Persona persona);
        Task<Persona> ObtenerPersonaPorTipoDocumentoYNumeroDocumento(Persona persona);
    }
}
