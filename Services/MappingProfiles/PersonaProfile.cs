using AutoMapper;
using Domain;
using Persistence.Entities;

namespace Services.MappingProfiles
{
    public class PersonaProfile : Profile
    {
        public PersonaProfile()
        {
            CreateMap<PersonaEntity, Persona>()
                .ForMember(dest => dest.TipoDocumentoIdentidad, act => act.MapFrom(src => src.TipoDocumentoIdentidad))
                .ReverseMap();
        }
    }
}
