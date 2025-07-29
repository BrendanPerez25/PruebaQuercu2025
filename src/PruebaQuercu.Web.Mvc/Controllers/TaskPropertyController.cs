    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using PruebaQuercu.Controllers;
    using PruebaQuercu.Property;
using PruebaQuercu.Property.Dto;
using PruebaQuercu.Web.Models.Property;
    using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace PruebaQuercu.Web.Controllers
{
    public class TaskPropertyController : PruebaQuercuControllerBase
    {
        private readonly ITaskPropertyAppService _taskPropertyAppService;

        public TaskPropertyController(ITaskPropertyAppService taskPropertyAppService)
        {
            _taskPropertyAppService = taskPropertyAppService;
        }
        public async Task<ActionResult> Index()
        {
            var propertys = await _taskPropertyAppService.GetAllAsync();

            var properties = new TaskPropertyViewModel(propertys);

            // 🔴 Cargar datos necesarios para el modal
            var createData = await _taskPropertyAppService.GetCreateDataAsync();
            ViewBag.PropertyTypes = new SelectList(createData.PropertyTypes, "Id", "Description");
            ViewBag.Owners = new SelectList(createData.Owners, "Id", "Name");

            //Logger.Info("Creating a new task with description: ");

            return View(properties);
        }

        public async Task<ActionResult> Create()
        {
            var createData = await _taskPropertyAppService.GetCreateDataAsync();
            //el ViewBag permite pasar datos desde el controlador a la vista de forma rápida y sencilla
            //SelectList es una clase de ASP.NET MVC que crea una lista de opciones para controles <select> (combos o dropdown lists).
            ViewBag.PropertyTypes = new SelectList(createData.PropertyTypes, "Id", "Description");
            ViewBag.Owners = new SelectList(createData.Owners, "Id", "Name");

            return View(new CreateTaskPropertyDto());
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await _taskPropertyAppService.DeleteAsync(id);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public async Task<IActionResult> Edit(EditTaskPropertyDto input)
        {
            if (!ModelState.IsValid)
            {
                // Si lo deseas puedes volver a cargar los datos y retornar la vista del modal, pero por ahora redirigimos
                return RedirectToAction("Index");
            }

            await _taskPropertyAppService.UpdateAsync(input);

            return RedirectToAction("Index");
        }



    }
}