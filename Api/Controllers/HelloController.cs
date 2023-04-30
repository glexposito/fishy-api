using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public IResult Hello()
    {
        return Results.Ok("Hello Fishy!") ;
    }
}
