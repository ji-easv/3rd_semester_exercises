using Microsoft.AspNetCore.Mvc;

namespace apiExercise.Controllers;

[ApiController]
[Route("controller")]
public class ThingController : ControllerBase
{
    private readonly List<Thing> _things = new List<Thing>()
    {
        new Thing()
        {
            Id = 1,
            Name = "Thing 1",
            Age = 10
        },
        new Thing()
        {
            Id = 2,
            Name = "Thing 2",
            Age = 20
        },
        new Thing()
        {
            Id = 3,
            Name = "Thing 3",
            Age = 30
        }
    };
    
    [HttpGet("entity/{id}")]
    public Thing Get([FromRoute] int id)
    {
        HttpContext.Response.StatusCode = 212;
        HttpContext.Response.Headers.Add("Custom-Header", "This is a custom header value");
        return _things.First(thing => thing.Id == id);
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
    public IActionResult Get([FromHeader] string name)
    {
        // Create a custom response header
        HttpContext.Response.Headers.Add("Custom-Header", "This is a custom header value");
        
        return Ok(_things.First(thing => thing.Name == name).Id);
    }

    [HttpPost]
    public IActionResult Create([FromBody] Thing thing)
    {
        return Created("http://localhost:5000/thing/1", thing);
    }
    
    [HttpPut("{id}")]
    public IActionResult Update([FromRoute] int id, [FromBody] Thing thing)
    {
        var thingToUpdate = _things.First(thing => thing.Id == id);
        if (thingToUpdate is null)
        {
            return NotFound();
        }
        
        thingToUpdate.Name = thing.Name;
        thingToUpdate.Age = thing.Age;
        return Ok(thingToUpdate);
    }
    
    [HttpDelete("{id}")]
    public IActionResult Delete([FromRoute] int id)
    {
        var thingToDelete = _things.First(thing => thing.Id == id);
        if (thingToDelete is null)
        {
            return NotFound();
        }
        
        _things.Remove(thingToDelete);
        return Ok();
    }
}