using Microsoft.AspNetCore.Mvc;

namespace MVCCourse.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
