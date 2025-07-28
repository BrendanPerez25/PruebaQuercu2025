    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace PruebaQuercu.Property.Dto
    {
        public class EditTaskPropertyDto : CreateTaskPropertyDto
        {
            [Required]
            public int Id { get; set; }
        }
    }
