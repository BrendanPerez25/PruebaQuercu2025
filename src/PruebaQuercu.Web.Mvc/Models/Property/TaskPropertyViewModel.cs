using PruebaQuercu.Property.Dto;
using System.Collections.Generic;

namespace PruebaQuercu.Web.Models.Property
{
    public class TaskPropertyViewModel
    {
        public IReadOnlyList<TaskPropertyDto> Properties { get; set; } //LLamamos al dto que extrae lo datos

        public TaskPropertyViewModel(IReadOnlyList<TaskPropertyDto> properties)
        {
            Properties = properties;
        }
    }
}
