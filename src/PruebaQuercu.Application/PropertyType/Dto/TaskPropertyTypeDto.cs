using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using PruebaQuercu.PropertyType;

namespace PruebaQuercu.PropertyType.Dto
{
    [AutoMapFrom(typeof(TaskPropertyType))]
    public class TaskPropertyTypeDto : EntityDto<int>
    {
        public string Description { get; set; }
    }

}
