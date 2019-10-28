using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using Persistence.Repositories.Interfaces;
using Services.Interfaces;

namespace Services
{
    public class TipoDocumentoIdentidadService : ITipoDocumentoIdentidadService
    {
        private readonly ITipoDocumentoIdentidadRepository _tipoDocumentoIdentidadRepository;
        private readonly IMapper _mapper;

        public TipoDocumentoIdentidadService(ITipoDocumentoIdentidadRepository tipoDocumentoIdentidadRepository, IMapper mapper)
        {
            _tipoDocumentoIdentidadRepository = tipoDocumentoIdentidadRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TipoDocumentoIdentidad>> GetTiposDocumentoIdentidadAsync()
        {
            var tiposDocumentoIdentidadEntity = await _tipoDocumentoIdentidadRepository.GetTiposDocumentoIdentidadAsync();
            var tiposDocumentoIdentidad = _mapper.Map<IEnumerable<TipoDocumentoIdentidad>>(tiposDocumentoIdentidadEntity);
            return tiposDocumentoIdentidad;
        }
    }
}
