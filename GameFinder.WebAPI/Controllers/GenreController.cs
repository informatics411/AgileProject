using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


[Route("api/[controller]")]
[ApiController]
public class GenreController : ControllerBase
{
    private readonly IGenreService _service;
    public GenreController(IGenreService service)
    {
        _service = service;
    }

[HttpPost]
public async Task<IActionResult> RegisterGenre([FromBody] GenreRegister model)
{
    if (!ModelState.IsValid)
    {
        return BadRequest(ModelState);
    }
    var registerResult = await _service.RegisterGenreAsync(model);
    if (registerResult)
    {
        return Ok("Genre was registered.");
    }
    return BadRequest("Genre could not be registered.");
}
}