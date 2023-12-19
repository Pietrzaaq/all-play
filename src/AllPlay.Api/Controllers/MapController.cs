using AllPlay.Application.Map.Commands;
using AllPlay.Application.Map.Queries;
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
    public async Task<IActionResult> CreateSportEvent(CreateSportEventCommand command)
    {
        await _mediator.Send(command);

        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetSportEvents()
    {
        var result = await _mediator.Send(new BrowseSportEventQuery());

        return Ok(result);
    }
}