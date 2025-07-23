using Abp.AutoMapper;
using PruebaQuercu.Owner;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaQuercu.Property.Dto
{
    [AutoMapFrom(typeof(TaskOwner))]
    public class CreateTaskPropertyDto 
    
    {
        [Required]
        public int PropertyTypeId { get; set; }

        [Required]
        public int OwnerId { get; set; }

        [Required]
        [StringLength(255)]
        public string Number { get; set; }

        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        [Required]
        public decimal Area { get; set; }

        public decimal ConstructionArea { get; set; }
    }   
}
