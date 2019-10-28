using AutoMapper;
using Domain;
using Persistence.Entities;

namespace Services.MappingProfiles
{
    public class TipoDocumentoIdentidadProfile : Profile
    {
        public TipoDocumentoIdentidadProfile()
        {
            CreateMap<TipoDocumentoIdentidadEntity, TipoDocumentoIdentidad>().ReverseMap();
        }
    }
}
