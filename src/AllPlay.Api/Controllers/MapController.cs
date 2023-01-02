using AllPlay.Application.Abstractions;
using AllPlay.Application.Map.Commands;
using AllPlay.Application.Map.Queries;
using Microsoft.AspNetCore.Mvc;

namespace AllPlay.Api.Controllers;

[ApiController]
[Route("map")]
public class MapController : ControllerBase
{
    private readonly IDispatcher _dispatcher;

    public MapController(IDispatcher dispatcher)
    {
        _dispatcher = dispatcher;
    }

    [HttpPost]
    public async Task<IActionResult> CreateMarker(CreateMarkerCommand command)
    {
        await _dispatcher.SendAsync(command);

        return Ok();
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetMarker(Guid id)
    {
        var result = await _dispatcher.QueryAsync(new GetMarkerQuery(id));

        if (result is null)
        {
            return NotFound();
        }

        return Ok(result);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetMarkers()
    {
        var result = await _dispatcher.QueryAsync(new BrowseMarkerQuery());

        if (result is null)
        {
            throw new ArgumentNullException();
        }

        return Ok(result);
    }
    
}