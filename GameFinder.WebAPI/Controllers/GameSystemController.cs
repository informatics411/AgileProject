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
}