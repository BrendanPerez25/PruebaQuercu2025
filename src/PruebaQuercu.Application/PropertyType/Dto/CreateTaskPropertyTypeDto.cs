using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaQuercu.PropertyType.Dto
{
    [AutoMapFrom(typeof(TaskPropertyType))]
    public class CreateTaskPropertyTypeDto
    {
        [Required]
        [StringLength(255)]
        public string Description { get; set; }
    }
}
