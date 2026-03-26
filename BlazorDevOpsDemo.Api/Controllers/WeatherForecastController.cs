using Microsoft.AspNetCore.Mvc;

namespace BlazorDevOpsDemo.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            message = "Hello Perritin",
            date = DateTime.Now
        });
    }
}