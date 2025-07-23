using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using PruebaQuercu.Owner;
using PruebaQuercu.PropertyType;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaQuercu.Property
{
    //[Table("Property",Schema = "nombredeesquema")] esto para crear un nuevo esquema en la db
    [Table("Property")]
    public class TaskProperty : Entity  // Esto ya incluye el campo 'Id' se usa el long dependindo de la cantidad de registros
    {
        public const int sizeLength = 255;

        // Llave foránea a PropertyType
        public int PropertyTypeId { get; set; }

        [ForeignKey("PropertyTypeId")]
        public virtual TaskPropertyType PropertyType { get; set; } //Donde TaskPropertyType es el nombre de la clase

        // 🔑 Llave foránea a Owner
        public int OwnerId { get; set; }

        [ForeignKey("OwnerId")]
        public virtual TaskOwner Owner { get; set; }

        [Required]
        [StringLength(sizeLength)]
        public string Number { get; set; }

        [Required]
        [StringLength(sizeLength)]
        public string Address { get; set; }

        [Required]
        public decimal Area { get; set; }

        public decimal ConstructionArea { get; set; }


    }

}
