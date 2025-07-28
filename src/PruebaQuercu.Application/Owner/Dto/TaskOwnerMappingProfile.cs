using AutoMapper;
using PruebaQuercu.Owner;
using PruebaQuercu.Owner.Dto;

namespace PruebaQuercu.Owner.Dto
{
    public class TaskOwnerMappingProfile : Profile
    {
        public TaskOwnerMappingProfile()
        {
            CreateMap<CreateTaskOwnerDto, TaskOwner>();
            CreateMap<TaskOwner, CreateTaskOwnerDto>();

            
        }
    }

}
