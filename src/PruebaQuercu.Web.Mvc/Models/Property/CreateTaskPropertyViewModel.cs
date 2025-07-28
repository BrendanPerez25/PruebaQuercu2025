using System.Collections.Generic;
using PruebaQuercu.Property.Dto;

public class CreateTaskPropertyViewModel
{
    public CreateTaskPropertyDto Property { get; set; }
    public List<TaskPropertyTypeComboDto> PropertyTypes { get; set; }
    public List<TaskOwnerComboDto> Owners { get; set; }

    //ACA SE LLAMAN LOS DTOS QUE NECESITO PARA CREAR Y PARA LLENAR LOS COMBOS
}
