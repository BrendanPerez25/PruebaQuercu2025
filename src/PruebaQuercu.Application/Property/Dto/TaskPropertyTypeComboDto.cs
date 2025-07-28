using Abp.AutoMapper;
using PruebaQuercu.PropertyType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaQuercu.Property.Dto
{
    [AutoMapFrom(typeof(TaskPropertyType))]
    public class TaskPropertyTypeComboDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
