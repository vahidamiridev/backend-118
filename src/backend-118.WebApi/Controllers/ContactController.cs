using Microsoft.AspNetCore.Mvc;

namespace backend_118.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ContactController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { Message = "Contact API is working!" });

    }
}
