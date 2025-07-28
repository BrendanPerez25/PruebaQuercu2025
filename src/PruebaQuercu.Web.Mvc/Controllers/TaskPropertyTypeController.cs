using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PruebaQuercu.Controllers;
using PruebaQuercu.PropertyType;
using PruebaQuercu.PropertyType.Dto;
using PruebaQuercu.Web.Models.PropertyType;
using System.Threading.Tasks;

namespace PruebaQuercu.Web.Controllers
{
    public class TaskPropertyTypeController : PruebaQuercuControllerBase
    {
        private readonly ITaskPropertyTypeAppService _taskPropertyTypeAppService;

        public TaskPropertyTypeController(ITaskPropertyTypeAppService taskPropertyTypeAppService)
        {
            _taskPropertyTypeAppService = taskPropertyTypeAppService;
        }

        // Acción para listar
        public async Task<ActionResult> Index()
        {
            var propertyTypes = await _taskPropertyTypeAppService.GetAllAsync();
            var datos = new TaskPropertyTypeViewModel(propertyTypes);
            return View(datos);
        }


        //Registro de datos 

        // Acción para mostrar el formulario de creación
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // Acción para recibir el formulario y guardar en la base de datos
        [HttpPost]
        public async Task<ActionResult> Create(CreateTaskPropertyTypeDto input)
        {
            if (ModelState.IsValid)
            {
                await _taskPropertyTypeAppService.CreateAsync(input);
                return RedirectToAction("Index");
            }

            return View(input);
        }

        //Metodo que busca el registro por id y lo envia a la vista de editar
        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            var propertyTypeDto = await _taskPropertyTypeAppService.GetByIdAsync(id);
            if (propertyTypeDto == null)
            {
                return NotFound();
            }
            return View(propertyTypeDto);
        }

        [HttpPost]
        public async Task<ActionResult> Update(EditTaskPropertyTypeDto input)
        {
            if (ModelState.IsValid)
            {
                await _taskPropertyTypeAppService.UpdateAsync(input);
                return RedirectToAction("Index");
            }
            return View("Edit", input);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(int id)
        {
            await _taskPropertyTypeAppService.DeleteAsync(id);
            return RedirectToAction("Index");
        }




    }
}         
