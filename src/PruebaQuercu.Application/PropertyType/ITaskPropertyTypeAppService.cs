using Abp.Application.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using PruebaQuercu.PropertyType.Dto;

namespace PruebaQuercu.PropertyType
{
    public interface ITaskPropertyTypeAppService : IApplicationService
    {
        // Crea un nuevo TaskPropertyType y devuelve el DTO creado (con ID u otros datos generados)
        Task<TaskPropertyTypeDto> CreateAsync(CreateTaskPropertyTypeDto input);

        // Obtiene la lista completa de TaskPropertyType
        Task<List<TaskPropertyTypeDto>> GetAllAsync();

        // Obtiene un TaskPropertyType para editar según su ID
        Task<EditTaskPropertyTypeDto> GetByIdAsync(int id);

        // Actualiza un TaskPropertyType con los datos enviados
        Task UpdateAsync(EditTaskPropertyTypeDto input);
        Task DeleteAsync(int id);

    }
}
