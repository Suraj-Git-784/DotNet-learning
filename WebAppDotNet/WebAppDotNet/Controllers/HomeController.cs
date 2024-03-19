using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppDotNet.Models;
using WebAppDotNet.Repository;

namespace WebAppDotNet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
     //   private readonly StudentRepository _studentRepository = null;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
           // _studentRepository = new StudentRepository();

        }
        //public List<StudentModel> getAllStudents()
        //{
        //    return _studentRepository.getAllStudents();
        //}
        //public StudentModel getById(int id) 
        //{ 
        //    return _studentRepository.getStudentById(id);
        //}
        public IActionResult Index()
        {
   //         List<StudentModel> students = new List<StudentModel>
   //         {
   //             new StudentModel
   //             {
   //                 RollNo = 1,
   //                 Name = "Suraj",
   //                 Gender = "Male",
   //                 Standard = 12
   //             },

			//		 new StudentModel
			//	{
			//		RollNo = 2,
			//		Name = "Ronik",
			//		Gender = "Male",
			//		Standard = 12
			//	},
			//			  new StudentModel
			//	{
			//		RollNo = 3,
			//		Name = "Harshit",
			//		Gender = "Male",
			//		Standard = 12
			//	}
			//};
            //EmployeeModel emp = new EmployeeModel()
            //{
            //    EmpId = 1,
            //    EmpName = "Suraj",
            //    EmpSalary = 20000,
            //    EmpDesignation = "Web Dev"
            //};

            //ViewData["EmployeeDetails"] = emp;
            //ViewBag.EmployeeDetails = emp;
            //TempData["EmployeeDetails"] = emp;


            //EmployeeModel obj = new EmployeeModel()
            //{
            //   EmpId = 1,
            //   EmpName = "Suraj",
            //   EmpDesignation = "Manager",
            //   EmpSalary = 50000
            //};
            //return View(obj);
            return View();
        }
        [HttpPost]
        public IActionResult Index(EmployeeModel emp)
        {
            return View();
            //if(ModelState.IsValid)
            //{
            //    return "Name is: " + emp.Name;
            //}else
            //{
            //    return "Validation failed...";
            //}
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About() 
        {
            return View();
        }
        public int Contact(int id)
        {
            return id;
        }
        public string Details(int id, string name)
        {
            return "Id is: " + id +  " Name is: " + name;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
