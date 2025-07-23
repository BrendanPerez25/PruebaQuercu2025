using Abp.Application.Services;
using Abp.Domain.Repositories;
using PruebaQuercu.Property.Dto;
using PruebaQuercu.PropertyType.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaQuercu.PropertyType
{
    public class TaskPropertyTypeAppService : ApplicationService, ITaskPropertyTypeAppService
    {
        private readonly IRepository<TaskPropertyType> _propertyTypeRepository;

        public TaskPropertyTypeAppService(IRepository<TaskPropertyType> propertyTypeRepository) { 
        
            _propertyTypeRepository = propertyTypeRepository;
        }

        public async Task<TaskPropertyTypeDto> CreateAsync(CreateTaskPropertyTypeDto input)
        {
            var propertytype = ObjectMapper.Map<TaskPropertyType>(input); // conversion de datos de Dto a Entidad
            var insert = await _propertyTypeRepository.InsertAsync(propertytype);

            return ObjectMapper.Map<TaskPropertyTypeDto>(insert);// conversion de datos de Entida a dDto
        }

        public async Task<List<TaskPropertyTypeDto>> GetAllAsync() 
        {
            var list = await _propertyTypeRepository.GetAllListAsync();

            return ObjectMapper.Map<List<TaskPropertyTypeDto>>(list);
        }
    }
}
