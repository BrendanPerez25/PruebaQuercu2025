using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaQuercu.PropertyType.Dto
{
    public class EditTaskPropertyTypeDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }
    }

}

// Este DTO se usa para editar un TaskPropertyType existente
