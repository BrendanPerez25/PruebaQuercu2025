using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaQuercu.Owner.Dto
{

    //ACA LO QUE SE HACE ES CREAR LA INSTANCIA QUE VA A ENVIAR Y RECIBIR DATOS PARA QUE EL MODELO
    //NO LO HAGA DIRECTAMENTE ESTE DTO ES PARA CREAR O REGISTRAR OWNERS
    // Este DTO se usa para recibir los datos desde el frontend o cliente cuando se quiere crear un Owner.
    [AutoMapFrom(typeof(TaskOwner))]
    public class CreateTaskOwnerDto
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Telephone { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        public string IdentificationNumber { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

    }
}
