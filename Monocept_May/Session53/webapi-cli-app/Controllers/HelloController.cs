using Microsoft.AspNetCore.Mvc;

namespace webapi_cli_app.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public IActionResult GetHello(){
        return Ok("Hello From Get!!");
    }
}