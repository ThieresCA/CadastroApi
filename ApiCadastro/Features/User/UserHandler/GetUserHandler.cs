using ApiCadastroUser.Data;
using ApiCadastroUser.Features.User;
using MediatR;
using Microsoft.EntityFrameworkCore;

public class GetUserHandler : IRequestHandler<GetUserRequest, UserModel?>
{
    private readonly ApiCadastroContext _dbContext;

    public GetUserHandler(ApiCadastroContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<UserModel?> Handle(GetUserRequest request, CancellationToken cancellationToken)
    {
        var result = await _dbContext.User.FirstOrDefaultAsync(x => x.Id == request.Id);

        return result;
    }
}