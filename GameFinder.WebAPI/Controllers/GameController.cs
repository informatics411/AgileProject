using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
         private readonly IGameService _service;
    public GameController(IGameService service)
    {
        _service = service;
    }

    [HttpPost("Register")]
    public async Task<IActionResult> RegisterGame([FromBody] GameRegister model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var registerResult = await _service.RegisterGameAsync(model);
        if (registerResult)
        {
            return Ok("Game was registered.");
        }
        return BadRequest("Game could not be registered.");
    }
    }
