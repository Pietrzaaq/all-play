using AllPlay.Application.Commands;
using AllPlay.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AllPlay.Api.Controllers;

[ApiController]
[Route("areas")]
public class AreasController : ControllerBase
{
    private readonly ISender _mediator;

    public AreasController(ISender mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateArea(CreateAreaCommand command)
    {
        await _mediator.Send(command with {Id = Guid.NewGuid()});

        return NoContent();
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetArea(Guid id)
    {
        var result = await _mediator.Send(new GetAreaQuery(id));

        if (result is null)
        {
            return NotFound();
        }

        return Ok(result);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetSportEvents()
    {
        var result = await _mediator.Send(new BrowseAreasQuery());

        if (result is null)
        {
            return NotFound();
        }

        return Ok(result);
    }
    
}