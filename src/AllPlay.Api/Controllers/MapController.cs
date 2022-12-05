using AllPlay.Application.Map.Queries;
using AllPlay.Application.Map.Services.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AllPlay.Api.Controllers;

[ApiController]
[Route("map")]
public class MapController : ControllerBase
{
    private readonly ISender _mediator;

    public MapController(ISender mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateMarker(CreateMarkerCommand command)
    {
        var result = await _mediator.Send(command);

        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetMarkers(BrowseMarkerQuery query)
    {
        var result = await _mediator.Send(query);

        if (result is null)
        {
            throw new ArgumentNullException();
        }

        return Ok(result);
    }
    
}