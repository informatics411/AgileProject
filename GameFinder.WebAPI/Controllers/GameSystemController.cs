using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

[Route("api/[Controller]")]
[ApiController]
public class GameSystemController : ControllerBase
{
    private readonly IGameSystemService _Service;
    public GameSystemController(IGameSystemService service)
    {
        _Service = service;
    }

    [HttpPost("Register")]
    public async Task<IActionResult> RegisterGameSystem([FromBody] GameSystemRegister model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var registerResult = await _Service.RegisterGameSystemAsync(model);
        if (registerResult)
        {
            return Ok("Game System was registered");
        }

        return BadRequest("Game system could not be registered");
    }
}