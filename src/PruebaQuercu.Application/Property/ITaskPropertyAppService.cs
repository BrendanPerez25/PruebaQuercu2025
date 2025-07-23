using Abp.Application.Services;
using PruebaQuercu.Property.Dto;
using PruebaQuercu.Property.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaQuercu.Property
{
    public interface ITaskPropertyAppService : IApplicationService
    {
        Task<TaskPropertyDto> CreateAsync(CreateTaskPropertyDto input);
        Task<List<TaskProperty>> GetAllAsync();

    }
}
