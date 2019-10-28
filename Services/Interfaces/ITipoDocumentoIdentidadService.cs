using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ITipoDocumentoIdentidadService
    {
        Task<IEnumerable<TipoDocumentoIdentidad>> GetTiposDocumentoIdentidadAsync();
    }
}
