    using PruebaQuercu.Owner.Dto;
    using System.Collections.Generic;

    namespace PruebaQuercu.Web.Models.TaskOwner
    {
        public class TaskOwnerViewModel
        {
            public IReadOnlyList<TaskOwnerDto> TaskOwners { get; set; }

            public TaskOwnerViewModel(IReadOnlyList<TaskOwnerDto> owners) 
            { 
                TaskOwners = owners;
            }
        }
    }
