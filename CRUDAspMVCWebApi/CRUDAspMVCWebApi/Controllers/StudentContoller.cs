using CRUDAspMVCWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CRUDAspMVCWebApi.Controllers
{
    public class StudentContoller : Controller
    {
        private readonly string BaseUrl = "https://localhost:7292/api/StudentApi/";
        private HttpClient client = new HttpClient( );
        
        [HttpGet]
        public IActionResult Index()
        {
            List<Student> students = new List<Student>();
            HttpResponseMessage response = client.GetAsync(BaseUrl).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<List<Student>>(result);
                if(data != null)
                {
                    students = data;
                }
            }
            return View(students);
        }
    }
}
