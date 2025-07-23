using Abp.Domain.Repositories;
using PruebaQuercu.Owner.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using AutoMapper.Internal.Mappers;
using Abp.Domain.Entities;
namespace PruebaQuercu.Owner
{
    public class TaskOwnerAppService : ApplicationService, ITaskOwnerAppService 
    {
        //PERMITE CREAR LA INTERACCION CON LA DB Y EL INT COMO LLAVE PRIMARIA NO COMO LONG
        private readonly IRepository<TaskOwner, int> _taskOwnerRepository;

        // El repositorio es el encargado de interactuar <TaskOwner, int> con la base de datos y en la entidad lo defini como int en vez de long.
        public TaskOwnerAppService(IRepository<TaskOwner, int> taskOwnerRepository)
        {
            _taskOwnerRepository = taskOwnerRepository;
        }

        public async Task<TaskOwnerDto> CreateAsync(CreateTaskOwnerDto dto) { //metodo para gaurdar en la db
        
            var owner = ObjectMapper.Map<TaskOwner>(dto); //Convierte el objeto Dto a una entidad por que solo inserta entidades en la base de datos

            var insert = await _taskOwnerRepository.InsertAsync(owner); //Insersion en la base de datos 

            return ObjectMapper.Map<TaskOwnerDto>(insert); // devuelve un dto para mostrar en el front

        }

        public async Task<List<TaskOwnerDto>> GetAllAsync() 
        {
            var owners = await _taskOwnerRepository.GetAllListAsync(); //Obtenemos lo registros de la db

            return ObjectMapper.Map<List<TaskOwnerDto>>(owners); //Convertimos de Entity a Dto
        }
    }
}
