using Abp.Application.Services;
using Abp.Domain.Repositories;
using PruebaQuercu.PropertyType.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;

namespace PruebaQuercu.PropertyType
{
    /// <summary>
    /// Servicio de aplicación para gestionar tipos de propiedades de tareas.
    /// </summary>
    public class TaskPropertyTypeAppService : ApplicationService, ITaskPropertyTypeAppService
    {
        private readonly IRepository<TaskPropertyType> _propertyTypeRepository;

        public TaskPropertyTypeAppService(IRepository<TaskPropertyType> propertyTypeRepository)
        {
            _propertyTypeRepository = propertyTypeRepository;
        }

        public async Task<TaskPropertyTypeDto> CreateAsync(CreateTaskPropertyTypeDto input)
        {
            var entity = ObjectMapper.Map<TaskPropertyType>(input); // DTO a entidad
            var inserted = await _propertyTypeRepository.InsertAsync(entity);

            return ObjectMapper.Map<TaskPropertyTypeDto>(inserted); // entidad a DTO
        }

        public async Task<List<TaskPropertyTypeDto>> GetAllAsync()
        {
            var list = await _propertyTypeRepository.GetAllListAsync();
            return ObjectMapper.Map<List<TaskPropertyTypeDto>>(list);
        }

        public async Task<EditTaskPropertyTypeDto> GetByIdAsync(int id)
        {
            var entity = await _propertyTypeRepository.GetAsync(id);
            return ObjectMapper.Map<EditTaskPropertyTypeDto>(entity); // Debe existir el mapa en AutoMapper
        }

        public async Task UpdateAsync(EditTaskPropertyTypeDto input)
        {
            var entity = await _propertyTypeRepository.GetAsync(input.Id);
            ObjectMapper.Map(input, entity); // Mapear cambios DTO → Entidad
            await _propertyTypeRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _propertyTypeRepository.DeleteAsync(id);
        }

    }

    public class TaskPropertyTypeProfile : Profile
    {
        public TaskPropertyTypeProfile()
        {
            CreateMap<TaskPropertyType, CreateTaskPropertyTypeDto>();
            CreateMap<TaskPropertyType, EditTaskPropertyTypeDto>();
            CreateMap<EditTaskPropertyTypeDto, TaskPropertyType>();
            CreateMap<TaskPropertyType, TaskPropertyTypeDto>();
        }
    }
}
