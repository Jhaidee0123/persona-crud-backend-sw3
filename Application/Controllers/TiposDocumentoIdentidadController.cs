using Domain;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiposDocumentoIdentidadController : ControllerBase
    {
        private readonly ITipoDocumentoIdentidadService _tipoDocumentoIdentidadService;

        public TiposDocumentoIdentidadController(ITipoDocumentoIdentidadService tipoDocumentoIdentidadService)
        {
            _tipoDocumentoIdentidadService = tipoDocumentoIdentidadService;
        }

        [HttpGet]
        public async Task<IEnumerable<TipoDocumentoIdentidad>> GetTiposDocumentoIdentidadAsync()
        {
            return await _tipoDocumentoIdentidadService.GetTiposDocumentoIdentidadAsync();
        }
    }
}