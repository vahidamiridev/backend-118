using Microsoft.AspNetCore.Mvc;

namespace MyProject.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var num = 0;
            Console.WriteLine("=============>start");
            for (int i = 0; i < 3; i++)
            {
                num += 1;
                Console.WriteLine($"Iteration {i}, num = {num}");
            }
        return Ok(new { Temp = 66, Condition = "windy" });
            
        } 
    }
}
