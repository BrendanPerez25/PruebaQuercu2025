using Microsoft.AspNetCore.Mvc;
using PruebaQuercu.Controllers;
using PruebaQuercu.Owner;
using PruebaQuercu.Web.Models.TaskOwner;
using System.Threading.Tasks;

namespace PruebaQuercu.Web.Controllers
{
    public class TaskOwnerController : PruebaQuercuControllerBase
    {

        private readonly ITaskOwnerAppService _taskOwnerAppService; //hace una variable del tipo de interfaz que creamos en el application

        public TaskOwnerController(ITaskOwnerAppService taskOwnerAppService) 
        {

            _taskOwnerAppService = taskOwnerAppService; //Creamos el contrucctor y le asignamos la interfaz del aplication


        }

        public async Task<ActionResult> Index()
        {
            var owners = await _taskOwnerAppService.GetAllAsync(); //llamamos al metodo en del aplication service
            var datos = new TaskOwnerViewModel(owners);
            return View(datos); //retornamos la vista que queremos
        }

    }
}


