using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
 {
    public class EmployeeController : Controller
    {
        public String Index()
        {
            return " hello .net  Index";
        }

        public ViewResult Index2()
        {
            return View("Index");
        }
        public IActionResult Index3()
        {
            return Content("emloyee index3 ");
        }
    }
    
  }