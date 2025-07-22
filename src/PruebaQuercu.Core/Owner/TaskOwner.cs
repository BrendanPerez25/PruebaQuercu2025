using Abp.Domain.Entities;
using PruebaQuercu.Property;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaQuercu.Owner
{
    public class TaskOwner : Entity 
    {

        public const int sizeLength = 255;

        [Required]
        [StringLength(sizeLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(sizeLength)]
        public string Telephone { get; set; }

        [StringLength(sizeLength)]
        public string Email { get; set; }

        [Required]
        [StringLength(sizeLength)]
        public string IdentificationNumber { get; set; }

        [StringLength(sizeLength)]
        public string Address { get; set; }

        public virtual ICollection<TaskProperty> Propertys { get; set; }
    }
}
