using Abp.AspNetCore.Mvc.Authorization;
using PruebaQuercu.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace PruebaQuercu.Web.Controllers;

[AbpMvcAuthorize]
public class HomeController : PruebaQuercuControllerBase
{
    public ActionResult Index()
    {
        return View();
    }
}
