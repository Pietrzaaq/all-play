using AllPlay.Application.SportEvents.Browse;
using AllPlay.Application.SportEvents.Create;
using AllPlay.Application.SportEvents.Get;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AllPlay.Api.Controllers;

[ApiController]
[Route("api/sport-events")]
public class SportEventsController : ControllerBase
{
    private readonly ISender _mediator;

    public SportEventsController(ISender mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateSportEvent(CreateSportEventCommand command)
    {
        await _mediator.Send(command);

        return NoContent();
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetSportEvent(Guid id)
    {
        var result = await _mediator.Send(new GetSportEventsQuery(id));

        if (result is null)
        {
            return NotFound();
        }

        return Ok(result);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetSportEvents()
    {
        var result = await _mediator.Send(new BrowseSportEventsQuery());

        if (result is null)
        {
            throw new ArgumentNullException();
        }

        return Ok(result);
    }
    
}