using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;
using Persistence.Entities;
using Persistence.Repositories.Interfaces;

namespace Persistence.Repositories
{
    public class TipoDocumentoIdentidadRepository : ITipoDocumentoIdentidadRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public TipoDocumentoIdentidadRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<TipoDocumentoIdentidadEntity>> GetTiposDocumentoIdentidadAsync()
        {
            return await _dbContext.TiposDocumentoIdentidad.ToListAsync();
        }
    }
}
