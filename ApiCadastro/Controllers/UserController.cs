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
    public async Task<ActionResult<UserModel>> CreateAsync([FromBody] CreateUserRequest request, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(request, cancellationToken);
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult<int>> UpdateAsync([FromBody] UpdateUserRequest request, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(request, cancellationToken);
        return Ok(result);
    }

    [HttpGet("{Id}")]
    public async Task<ActionResult<int>> GetAsync([FromRoute] GetUserRequest request, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(request, cancellationToken);
        return Ok(result);
    }

    [HttpGet]
    public async Task<ActionResult<int>> GetAllAsync(CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new GetAllUsersRequest(), cancellationToken);
        return Ok(result);
    }

    [HttpDelete("{Id}")]
    public async Task<ActionResult<int>> DeleteAsync([FromRoute] DeleteUserRequest request, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(request, cancellationToken);
        return Ok(result);
    }
}


