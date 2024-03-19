using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebAppDotNet.Models;
using WebAppDotNet.Repository;

namespace WebAppDotNet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //   private readonly StudentRepository _studentRepository = null;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //   // _studentRepository = new StudentRepository();

        //}
        private readonly EmployeeDbContext employeeDB;
        public HomeController(EmployeeDbContext employeeDB)
        {
            this.employeeDB = employeeDB;
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

            //         new StudentModel
            //    {
            //        RollNo = 2,
            //        Name = "Ronik",
            //        Gender = "Male",
            //        Standard = 12
            //    },
            //              new StudentModel
            //    {
            //        RollNo = 3,
            //        Name = "Harshit",
            //        Gender = "Male",
            //        Standard = 12
            //    }
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
            var empData = employeeDB.Employees.ToList();
            return View(empData);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(EmployeeModel emp)
        {
            if(ModelState.IsValid)
            {
              await  employeeDB.Employees.AddAsync(emp);
              await  employeeDB.SaveChangesAsync();
                TempData["insert_success"] = "Created...";
                return RedirectToAction("Index", "Home");
            }
            return View(emp);
        }
        [HttpPost]
        public IActionResult Index(EmployeeModel emp)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
            }
            return View();
            //if(ModelState.IsValid)
            //{
            //    return "Name is: " + emp.Name;
            //}else
            //{
            //    return "Validation failed...";
            //}
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || employeeDB.Employees == null)
            {
                return NotFound();
            }
            var empData = await employeeDB.Employees.FirstOrDefaultAsync(x => x.Id == id);
            return View(empData);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || employeeDB.Employees == null)
            {
                return NotFound();
            }
            var empData = await employeeDB.Employees.FindAsync(id);
            return View(empData);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int? id, EmployeeModel emp) {
            if(ModelState.IsValid)
            {
                employeeDB.Employees.Update(emp);
                await employeeDB.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(emp);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || employeeDB.Employees == null)
            {
                return NotFound();
            }

            var empData = await employeeDB.Employees.FirstOrDefaultAsync(x => x.Id == id);
            return View(empData);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var empData = await employeeDB.Employees.FindAsync(id);
            if(empData != null)
            {
                employeeDB.Employees.Remove(empData);
            }
            await employeeDB.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
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



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
