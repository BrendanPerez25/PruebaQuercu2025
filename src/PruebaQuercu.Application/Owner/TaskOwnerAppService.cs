using Abp.Domain.Repositories;
using PruebaQuercu.Owner.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using AutoMapper.Internal.Mappers;
using Abp.Domain.Entities;
using System.Diagnostics;
namespace PruebaQuercu.Owner
{
    public class TaskOwnerAppService : ApplicationService, ITaskOwnerAppService 
    {
        //PERMITE CREAR LA INTERACCION CON LA DB Y EL INT COMO LLAVE PRIMARIA NO COMO LONG
        private readonly IRepository<TaskOwner, int> _taskOwnerRepository;

        // El repositorio es el encargado de interactuar <TaskOwner, int> con la base de datos y en la entidad lo definí como int (Id) en vez de long.
        public TaskOwnerAppService(IRepository<TaskOwner, int> taskOwnerRepository)
        {
            _taskOwnerRepository = taskOwnerRepository;
        }

        //CREAR
        public async Task<TaskOwnerDto> CreateAsync(CreateTaskOwnerDto input)
        {
            var owner = ObjectMapper.Map<TaskOwner>(input); 

            var createdOwner = await _taskOwnerRepository.InsertAsync(owner);
            await CurrentUnitOfWork.SaveChangesAsync();

            return ObjectMapper.Map<TaskOwnerDto>(createdOwner);
        }

        //MOSTRAR
            public async Task<List<TaskOwnerDto>> GetAllAsync() 
            {
                var owners = await _taskOwnerRepository.GetAllListAsync(); //Obtenemos lo registros de la db

                return ObjectMapper.Map<List<TaskOwnerDto>>(owners); //Convertimos de Entity a Dto
            }


        //ELIMINAR
            public async Task DeleteAsync(int id)
            {
                await _taskOwnerRepository.DeleteAsync(id);
            }

        //Editar
        public async Task<TaskOwnerDto> EditAsync(EditTaskOwnerDto input)
        {
            var owner = await _taskOwnerRepository.GetAsync(input.Id);

            // Actualiza campos
            owner.Name = input.Name;
            owner.Telephone = input.Telephone;
            owner.Email = input.Email;
            owner.IdentificationNumber = input.IdentificationNumber;
            owner.Address = input.Address;

            await _taskOwnerRepository.UpdateAsync(owner);
            return ObjectMapper.Map<TaskOwnerDto>(owner);
        }


    }
}
