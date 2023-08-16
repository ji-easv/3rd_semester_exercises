using Microsoft.AspNetCore.Mvc;

namespace apiExercise.Controllers;

[ApiController]
[Route("controller")]
public class ThingController : ControllerBase
{
    private readonly List<string> _names = new List<string>() { "John", "Jane", "Jack"};
    
    [HttpGet("entity/{id}")]
    public string Get([FromRoute] int id)
    {
        HttpContext.Response.StatusCode = 212;
        HttpContext.Response.Headers.Add("Custom-Header", "This is a custom header value");
        return _names[id];
    }

    /*
    [HttpGet]
    public object Get([FromQuery] string someKey)
    {
        return _names
            .IndexOf(someKey);
    }
    */
    
    [HttpGet]
    public IActionResult Get([FromHeader] string someKey)
    {
        // Create a custom response header
        HttpContext.Response.Headers.Add("Custom-Header", "This is a custom header value");
        
        return Ok(_names.IndexOf(someKey));
    }
}