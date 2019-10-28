using Persistence.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistence.Repositories.Interfaces
{
    public interface ITipoDocumentoIdentidadRepository
    {
        Task<IEnumerable<TipoDocumentoIdentidadEntity>> GetTiposDocumentoIdentidadAsync();
    }
}
