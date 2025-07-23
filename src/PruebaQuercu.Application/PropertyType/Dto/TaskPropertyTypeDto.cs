using Abp.AutoMapper;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaQuercu.PropertyType.Dto
{
    [AutoMapFrom(typeof(TaskPropertyType))]
    public class TaskPropertyTypeDto : Entity<int>
    {
        public string description { get; set; }
    }
}
