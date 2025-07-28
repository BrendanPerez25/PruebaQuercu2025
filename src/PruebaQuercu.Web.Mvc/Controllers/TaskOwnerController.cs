using Microsoft.AspNetCore.Mvc;
using PruebaQuercu.Controllers;
using PruebaQuercu.Owner;
using PruebaQuercu.Owner.Dto;
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

            var datos = new TaskOwnerViewModel(owners); //CONVIERTE LOS DATOS QUE VIENEN EN EL MODELO QUE SE NECESITA PARA LAS VISTAS

            return View(datos); //retornamos la vista que queremos
        }

          [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<ActionResult> Delete(int id)
        {
            await _taskOwnerAppService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditTaskOwnerDto dto)
        {
            await _taskOwnerAppService.EditAsync(dto);
            return RedirectToAction("Index");
        }


    }
}


