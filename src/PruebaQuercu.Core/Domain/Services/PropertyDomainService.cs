using Abp.Domain.Repositories;
using Abp.Domain.Services;
using PruebaQuercu.Property;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaQuercu.Domain.Services
{
    public class PropertyDomainService : DomainService
    {
        //Aca inyectamos la entidad en la que vamos a trabajar IRepository<TaskProperty, int>
        private readonly IRepository<TaskProperty, int> _repositoryTaskProperty; 

        //Inicia la inyeccion del Repositorio
        public PropertyDomainService(IRepository<TaskProperty, int> repositoryTaskProperty)
        {
            _repositoryTaskProperty = repositoryTaskProperty;
        }

        public async Task<bool> CheckOwnerPropertyLimitAsync(int id, int MaxPropertiesPerOwner)
        {

            //llamamos al repositorio y hacemos el llamado al metodo de contar y en este caso contar los id del owner en la base de datos
            var propertyCount = await _repositoryTaskProperty.CountAsync(p => p.OwnerId == id);

            //retorna si el resultado del metodo es true si es mayor y false si es menor
            return propertyCount >= MaxPropertiesPerOwner;

                // EN CASO DE USAR PRUEBAS SE USA ESTE PARA VERIFICAR SI EL DOMAIN SIRVE
                //throw new Abp.UI.UserFriendlyException("Este dueño ya tiene el número máximo de propiedades permitidas (3)."); 

            

        }
    }
}
