using Abp.AutoMapper;
using PruebaQuercu.Owner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaQuercu.Property.Dto
{
    [AutoMapFrom(typeof(TaskOwner))]
    public class TaskOwnerComboDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
