using LoginFormAspCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LoginFormAspCore.Controllers
{
    //public enum Gender
    //{
    //    Male = 0,
    //    Female = 1,
    //}
    public class HomeController : Controller
    {
        private readonly CodeFirstDbContext context;

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        public HomeController(CodeFirstDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("UserSession") != null)
            {
               return RedirectToAction("Dashboard");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserTable user)
        {
            var userData = context.UserTables.Where(x => x.UserEmail == user.UserEmail && x.UserPassword == user.UserPassword).FirstOrDefault(); 
            if(userData != null)
            {
                HttpContext.Session.SetString("UserSession", userData.UserEmail);
                return RedirectToAction("Dashboard");
            }
            else
            {
                ViewBag.Message = "Login Failed";
            }
            return View();
        }

        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("UserSession") != null)
            {
                ViewBag.MySession = HttpContext.Session.GetString("UserSession");
            }
            else
            {
                return RedirectToAction("Login");
            }
            return View();
        }
        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("UserSession") != null)
            {
                HttpContext.Session.Remove("UserSession");
                return RedirectToAction("Login");
            }
            return View();
        }
        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Signup(UserTable user)
        {
            if(ModelState.IsValid)
            {
               await context.UserTables.AddAsync(user);
               await context.SaveChangesAsync();
               TempData["Success"] = "Registered Successfully";
                return RedirectToAction("Login");
            }
            return View();
        }
        public IActionResult Dropdown()
        {
            List<SelectListItem> Gender = new()
            {
                new SelectListItem {Value = "male", Text="Male"},
                new SelectListItem {Value = "female", Text="Female"},

            };
            ViewBag.Gender = Gender;
            return View();
        }

        public IActionResult Products()
        {
            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Reebok",
                    Description = "description1",
                    Price = 10000,
                    Image = "~/images/download (2).jpg"
                },
                new Product()
                {
                    Id = 1,
                    Name = "Reebok",
                    Description = "description1",
                    Price = 10000,
                    Image = "~/images/images (1).jpg"
                }
            };
            return View(products);
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
