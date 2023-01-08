using AllPlay.Application.Commands;
using AllPlay.Application.Common.Abstractions;
using AllPlay.Application.Queries;
using Microsoft.AspNetCore.Mvc;

namespace AllPlay.Api.Controllers;

[ApiController]
[Route("areas")]
public class AreasController : ControllerBase
{
    private readonly IDispatcher _dispatcher;

    public AreasController(IDispatcher dispatcher)
    {
        _dispatcher = dispatcher;
    }

    [HttpPost]
    public async Task<IActionResult> CreateArea(CreateAreaCommand command)
    {
        await _dispatcher.SendAsync(command with {Id = Guid.NewGuid()});

        return Ok();
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetArea(Guid id)
    {
        var result = await _dispatcher.QueryAsync(new GetAreaQuery(id));

        if (result is null)
        {
            return NotFound();
        }

        return Ok(result);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetSportEvents()
    {
        var result = await _dispatcher.QueryAsync(new BrowseAreasQuery());

        if (result is null)
        {
            return NotFound();
        }

        return Ok(result);
    }
    
}