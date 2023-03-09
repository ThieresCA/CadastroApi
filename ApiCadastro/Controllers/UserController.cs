using ApiCadastroUser.Features.User;
using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class EntidadeController : ControllerBase
{
    private readonly IMediator _mediator;

    public EntidadeController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<UserModel>> CreateAsync(CreateUserRequest request, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(request, cancellationToken);
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult<int>> UpdateAsync(UpdateUserRequest request, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(request, cancellationToken);
        return Ok(result);
    }

    [HttpGet]
    public async Task<ActionResult<int>> GetAsync(GetUserRequest request, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(request, cancellationToken);
        return Ok(result);
    }

    [HttpGet]
    public async Task<ActionResult<int>> GetAllAsync(GetAllUsersRequest request, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(request, cancellationToken);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<ActionResult<int>> DeleteAsync(GetAllUsersRequest request, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(request, cancellationToken);
        return Ok(result);
    }
}


