using Abp.AutoMapper;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaQuercu.Property.Dto
{
    [AutoMapFrom(typeof(TaskProperty))]
    public class TaskPropertyDto : Entity<int> 
    {
        public int PropertyTypeId { get; set; }
        public string PropertyTypeName { get; set; } // Para mostrar el nombre del tipo

        public int OwnerId { get; set; }
        public string OwnerName { get; set; } // Para mostrar el nombre del dueño

        public string Number { get; set; }
        public string Address { get; set; }
        public decimal Area { get; set; }
        public decimal ConstructionArea { get; set; }
    }
}
