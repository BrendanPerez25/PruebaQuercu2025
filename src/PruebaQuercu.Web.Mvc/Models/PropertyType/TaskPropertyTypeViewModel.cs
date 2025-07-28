using PruebaQuercu.Property.Dto;
using PruebaQuercu.PropertyType.Dto;
using System.Collections.Generic;

namespace PruebaQuercu.Web.Models.PropertyType
{
    public class TaskPropertyTypeViewModel
    {


        public IReadOnlyList<TaskPropertyTypeDto> TaskPropertyType { get; set; }   //cambiar

        public TaskPropertyTypeViewModel(IReadOnlyList<TaskPropertyTypeDto> taskPropertyTypeDtos)
        {
            TaskPropertyType = taskPropertyTypeDtos;
        }


    }
}
