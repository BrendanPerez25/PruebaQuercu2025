﻿using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaQuercu.PropertyType.Dto
{
    [AutoMapTo(typeof(TaskPropertyType))]  // Este es clave para tu mapeo
    public class CreateTaskPropertyTypeDto
    {
        [Required]
        [StringLength(255)]
        public string Description { get; set; }
    }

}
