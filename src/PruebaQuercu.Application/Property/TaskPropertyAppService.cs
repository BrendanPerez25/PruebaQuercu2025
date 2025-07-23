using Abp.Application.Services;
using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaQuercu.Property.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaQuercu.Property
{
    public class TaskPropertyAppService : ApplicationService, IApplicationService
    {
        private readonly IRepository<TaskProperty, int> _propertyRepository;

        public TaskPropertyAppService(IRepository<TaskProperty, int> propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }

        //CREAR REGISTRO EN LA DB
        public async Task<TaskPropertyDto> CreateAsync(CreateTaskPropertyDto input) 
        {
            var property = ObjectMapper.Map<TaskProperty>(input);
            var insert = await _propertyRepository.InsertAsync(property);

            return ObjectMapper.Map<TaskPropertyDto>(insert);
        }

        //OBTENER LOS REGISTROS DE LA DB
        public async Task<List<TaskPropertyDto>> GetAllAsync() 
        {
            var propertys = await _propertyRepository.GetAllIncluding(p => p.PropertyType, propertySelectors => propertySelectors.Owner).ToListAsync();
            return ObjectMapper.Map<List<TaskPropertyDto>>(propertys);
        }
    }
}
