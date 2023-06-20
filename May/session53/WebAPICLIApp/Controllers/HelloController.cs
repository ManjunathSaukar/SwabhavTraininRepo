using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/v1/[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet(Name="GetHello")]
    public IActionResult GetHello(){
        return Ok("Hello From Get");
    }
}