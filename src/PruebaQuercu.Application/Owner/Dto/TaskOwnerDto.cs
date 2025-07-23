using Abp.AutoMapper;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaQuercu.Owner.Dto
{
    // Este DTO se usa para devolver datos al cliente. Por ejemplo, al mostrar la lista o detalle de un Owner.
    [AutoMapFrom(typeof(TaskOwner))]
    public class TaskOwnerDto : Entity<int> //Hereda el Id automáticamente por que lo necesitamos para mostrar un registro especifico o eliminar
    {
        public string Name { get; set; }

        public string Telephone { get; set; }

        public string Email { get; set; }

        public string IdentificationNumber { get; set; }

        public string Address { get; set; }

    } 
}
