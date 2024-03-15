using Microsoft.AspNetCore.Mvc;
using ModelsAsp.Models;
using ModelsAsp.Repository;
using System.Diagnostics;

namespace ModelsAsp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepository _studentRepository = null;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository = new StudentRepository();
        }

        public List<StudentModel> getAllStudents()
        {
            return _studentRepository.getAllStudents();
        }

        public StudentModel getById(int id)
        {
            return _studentRepository.getStudentById(id);
        }
        public IActionResult Index()
        {
            //var students = new List<StudentModel>
            //{
            //    //new StudentModel
            //    //{
            //    //    rollNo = 1,
            //    //    Name = "Suraj",
            //    //    Gender = "Male",
            //    //    Standard = 11
            //    //},     
            //    //new StudentModel
            //    //{
            //    //    rollNo = 2,
            //    //    Name = "Ronik",
            //    //    Gender =  "Male",
            //    //    Standard = 12
            //    //},     
            //    //new StudentModel
            //    //{
            //    //    rollNo = 3,
            //    //    Name = "Harshit",
            //    //    Gender = "Male",
            //    //    Standard = 10
            //    //},
            //};

            //ViewData["myStudents"] = students;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
