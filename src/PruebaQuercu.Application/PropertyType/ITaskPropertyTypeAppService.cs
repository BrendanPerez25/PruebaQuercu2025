using Abp.Application.Services;
using Microsoft.AspNetCore.Builder;
using PruebaQuercu.PropertyType.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaQuercu.PropertyType
{
    public interface ITaskPropertyTypeAppService : IApplicationService
    {
        //Task<TaskPropertyTypeDto> CreateAsync(CreateTaskPropertyTypeDto input);Se usa cuando desea devolver el objeto creado(cuando se necesita el id u otro dato)
        //Task CreateAsync(CreateTaskPropertyTypeDto input); Se usa cuando no se desea devolver el objeto creado(cuando no se necesita el id u otro dato)
        Task<TaskPropertyTypeDto> CreateAsync(CreateTaskPropertyTypeDto input); //LLAMADO AL METODO DE SU AppService
        Task<List<TaskPropertyTypeDto>> GetAllAsync(); //LLAMADO AL METODO DE SU AppService
    }
}
