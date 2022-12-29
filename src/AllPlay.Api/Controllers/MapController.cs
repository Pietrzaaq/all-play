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

    [HttpGet]
    public async Task<IActionResult> GetMarkers(BrowseMarkerQuery query)
    {
        var result = await _dispatcher.QueryAsync(query);

        if (result is null)
        {
            throw new ArgumentNullException();
        }

        return Ok(result);
    }
    
}