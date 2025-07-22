using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaQuercu.Property;
using Castle.MicroKernel.Registration;



namespace PruebaQuercu.PropertyType
{

    public class TaskPropertyType : Entity 
    {

        public const int sizeLength = 255;

        [Required]
        [StringLength(sizeLength)]
        public string Description { get; set; }

        public virtual ICollection<TaskProperty> Propertys { get; set; }

    }
}
