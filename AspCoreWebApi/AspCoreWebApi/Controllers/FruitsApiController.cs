using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsApiController : ControllerBase
    {
        public List<string> Fruits = new List<string>()
        {
            "Apple",
            "Banana",
            "Cherry"
        };

        [HttpGet]
        public List<string> GetFruits()
        {
            return Fruits;
        }

        [HttpGet("{id}")]
        public string GetFruitsByIndex(int id)
        {
            return Fruits.ElementAt(id);
        }
    }
}
