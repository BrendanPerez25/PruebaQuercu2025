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
        Task<List<TaskPropertyDto>> GetAllAsync();
        Task<TaskPropertyCreateDataDto> GetCreateDataAsync(); //OBTENER LA LISTAS CON LOS DATOS DE OWNERS Y DE PROPERTYTYPES

        Task DeleteAsync(int id);

        Task<EditTaskPropertyDto> GetForEditAsync(int id);

        Task UpdateAsync(EditTaskPropertyDto input);

    }
}
