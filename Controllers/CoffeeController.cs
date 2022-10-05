using Microsoft.AspNetCore.Mvc;
using API_Interactive_Lab_1.Models;

namespace API_Interactive_Lab_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeController : ControllerBase
    {
        [HttpGet("{name}")]
        public Coffee Get(string? name)
        {
            return new Coffee { Id = (name != null ? 3 : -1), Name = name ?? "latte" };
        }

        [HttpGet("lover")]
        public string Get()
        {
            return "I like coffee!";
        }
    }
}
