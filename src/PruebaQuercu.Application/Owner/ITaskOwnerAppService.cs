using Abp.Application.Services;
using PruebaQuercu.Owner.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaQuercu.Owner
{
    public interface ITaskOwnerAppService : IApplicationService 
    {
        Task<TaskOwnerDto> CreateAsync(CreateTaskOwnerDto input); // Crear
        Task<List<TaskOwnerDto>> GetAllAsync(); // Mostrar todos
        Task DeleteAsync(int id); // Eliminar registro

        Task<TaskOwnerDto> EditAsync(EditTaskOwnerDto input);

    }
}
