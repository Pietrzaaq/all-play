using AllPlay.Application.Commands;
using AllPlay.Application.Common.Abstractions;
using AllPlay.Application.Queries;
using Microsoft.AspNetCore.Mvc;

namespace AllPlay.Api.Controllers;

[ApiController]
[Route("sport-events")]
public class SportEventsController : ControllerBase
{
    private readonly IDispatcher _dispatcher;

    public SportEventsController(IDispatcher dispatcher)
    {
        _dispatcher = dispatcher;
    }

    [HttpPost]
    public async Task<IActionResult> CreateSportEvent(CreateSportEventCommand command)
    {
        await _dispatcher.SendAsync(command with {Id = Guid.NewGuid()});

        return NoContent();
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetSportEvent(Guid id)
    {
        var result = await _dispatcher.QueryAsync(new GetSportEventsQuery(id));

        if (result is null)
        {
            return NotFound();
        }

        return Ok(result);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetSportEvents()
    {
        var result = await _dispatcher.QueryAsync(new BrowseSportEventsQuery());

        if (result is null)
        {
            throw new ArgumentNullException();
        }

        return Ok(result);
    }
    
}