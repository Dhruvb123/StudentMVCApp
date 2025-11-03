using Microsoft.AspNetCore.Mvc;
using MVCCourse.Context;
using MVCCourse.Models;

namespace MVCCourse.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDBContext _dbContext;

        public StudentController(AppDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public IActionResult Index()
        {
            var students = _dbContext.Students.ToList();
            return View(students);
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddStudent(Students student)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Students.Add(student);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            TempData["ErrorMessage"] = "Validation failed. Please check the entered data.";
            return RedirectToAction("Error");
        }

        public IActionResult Error()
        {
            return View();
        }

    }
}
