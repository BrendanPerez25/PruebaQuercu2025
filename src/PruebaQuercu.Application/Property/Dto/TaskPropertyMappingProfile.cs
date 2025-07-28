using AutoMapper;
using PruebaQuercu.Property;
using PruebaQuercu.Property.Dto;

namespace PruebaQuercu.Property.Dto
{
    public class TaskPropertyMappingProfile : Profile
    {
        public TaskPropertyMappingProfile()
        {
            CreateMap<TaskProperty, TaskPropertyDto>()
                .ForMember(dest => dest.PropertyTypeName, opt => opt.MapFrom(src => src.PropertyType.Description))
                .ForMember(dest => dest.OwnerName, opt => opt.MapFrom(src => src.Owner.Name));

            CreateMap<TaskPropertyDto, TaskProperty>(); // Si necesitas edición inversa
        }
    }
}
