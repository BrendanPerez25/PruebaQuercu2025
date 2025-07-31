using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.UI;
using Castle.Core.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PruebaQuercu.Domain.Services;
using PruebaQuercu.Owner;
using PruebaQuercu.Property.Dto;
using PruebaQuercu.PropertyType;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ILogger = Castle.Core.Logging.ILogger; //1: Import Logging namespace

namespace PruebaQuercu.Property
{
    public class TaskPropertyAppService : ApplicationService, ITaskPropertyAppService
    {
        private readonly IRepository<TaskProperty, int> _propertyRepository;
        private readonly IRepository<TaskPropertyType, int> _propertyTypeRepository;
        private readonly IRepository<TaskOwner, int> _ownerRepository;
        private readonly PropertyDomainService _propertyDomainService;
      
        public ILogger logger { get; set; } //Inyectamos el logger pero no es necesario si se esta usando el ApplicationService ya que viene inyectado en él

        public TaskPropertyAppService(IRepository<TaskProperty, int> propertyRepository, IRepository<TaskPropertyType, int> propertyTypeRepository,IRepository<TaskOwner, int> ownerRepository, PropertyDomainService domainservice) // ILogger<TaskPropertyAppService> logger
        {
            _propertyRepository = propertyRepository;
            _propertyTypeRepository = propertyTypeRepository;
            _ownerRepository = ownerRepository; 
            _propertyDomainService = domainservice;
            logger = NullLogger.Instance; // inicializamos la instancia en el contructor
        }


        //CREAR REGISTRO EN LA DB
        public async Task<TaskPropertyDto> CreateAsync(CreateTaskPropertyDto input)
        {
            //CARGAMOS EL METODO DEL DOMAIN EN UN VARIABLE PARA COMPROBAR Y LANZAR EL ERROR CON SUS VARIABLES DE ID PARA COMPROBAR
            // INT PARA SELECCIONAR EL VALOR MAXIMO DE PROPIEDADES QUE TIENE UN OWNER
            var checkOwner = await _propertyDomainService.CheckOwnerPropertyLimitAsync(input.OwnerId,3);

            if (checkOwner)
            {
               
                throw new UserFriendlyException("Este dueño ya tiene el número máximo de propiedades permitidas (3).");
            }
            var property = ObjectMapper.Map<TaskProperty>(input);

          

            var insert = await _propertyRepository.InsertAsync(property);

           

            return ObjectMapper.Map<TaskPropertyDto>(insert);
        }

        //OBTENER TODOS LOS REGISTROS DE PROPIEDADES CON NOMBRE DE TIPO Y PROPIETARIO
        public async Task<List<TaskPropertyDto>> GetAllAsync()
        {
            logger.Info("Esto es un mensaje de prueba para verificar el logger."); //LA BOLITA AL LADO IZQUIERDO ES UN BreakPoint-Debuger
            logger.Error("Esto es un mensaje de prueba para verificar errores en logger.");
            logger.Error("Esto es un mensaje de prueba para verificar errores en logger.");
            logger.Error("Esto es un mensaje de prueba para verificar errores en logger.");

            var properties = await _propertyRepository
                .GetAllIncluding(p => p.PropertyType, p => p.Owner)
                .ToListAsync();

            return ObjectMapper.Map<List<TaskPropertyDto>>(properties);
        }

        // NUEVO: OBTENER LISTAS DE PROPERTY TYPES Y OWNERS PARA LLENAR COMBOS ESTO EN ELA CLASE DE ABAJO 
        public async Task<TaskPropertyCreateDataDto> GetCreateDataAsync()
        {
            var propertyTypes = await _propertyTypeRepository.GetAllListAsync();
            var owners = await _ownerRepository.GetAllListAsync();

            return new TaskPropertyCreateDataDto
            {
                PropertyTypes = propertyTypes.Select(pt => new TaskPropertyTypeComboDto
                {
                    Id = pt.Id,
                    Description = pt.Description
                }).ToList(),

                Owners = owners.Select(o => new TaskOwnerComboDto
                {
                    Id = o.Id,
                    Name = o.Name
                }).ToList()
            };
        }
        public async Task DeleteAsync(int id)
        {
            await _propertyRepository.DeleteAsync(id);
        }

        public async Task<EditTaskPropertyDto> GetForEditAsync(int id)
        {
            var entity = await _propertyRepository.GetAsync(id);

            var dto = ObjectMapper.Map<EditTaskPropertyDto>(entity);

            return dto;
        }
        public async Task UpdateAsync(EditTaskPropertyDto input)
        {
            var entity = await _propertyRepository.GetAsync(input.Id);

            ObjectMapper.Map(input, entity); // mapea los cambios
            await _propertyRepository.UpdateAsync(entity);
        }

    }


    // DTO para enviar los combos al cliente
    public class TaskPropertyCreateDataDto
    {
        public List<TaskPropertyTypeComboDto> PropertyTypes { get; set; }
        public List<TaskOwnerComboDto> Owners { get; set; }
    }

}
