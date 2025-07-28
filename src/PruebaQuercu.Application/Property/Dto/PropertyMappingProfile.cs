using AutoMapper;
using PruebaQuercu.Property;
using PruebaQuercu.Property.Dto;

public class PropertyMappingProfile : Profile
{
    public PropertyMappingProfile()
    {
        // Mapeos explícitos entre DTO y entidad
        CreateMap<CreateTaskPropertyDto, TaskProperty>();
        CreateMap<TaskProperty, TaskPropertyDto>();
        // Agrega otros mapeos necesarios aquí
    }
}
