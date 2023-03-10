using ApiCadastroUser.Features.User;
using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IMediator _mediator;

    public UserController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<ClienteModel>> CreateAsync([FromBody] CreateClienteRequest request, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(request, cancellationToken);
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult<int>> UpdateAsync([FromBody] UpdateClienteRequest request, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(request, cancellationToken);
        return Ok(result);
    }

    [HttpGet("{Id}")]
    public async Task<ActionResult<int>> GetAsync([FromRoute] GetClienteRequest request, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(request, cancellationToken);
        return Ok(result);
    }

    [HttpGet]
    public async Task<ActionResult<int>> GetAllAsync(CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new GetAllClientesRequest(), cancellationToken);
        return Ok(result);
    }

    [HttpDelete("{Id}")]
    public async Task<ActionResult<int>> DeleteAsync([FromRoute] DeleteClienteRequest request, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(request, cancellationToken);
        return Ok(result);
    }
}


