using ApiCadastroUser.Data;
using ApiCadastroUser.Features.User;
using MediatR;
using Microsoft.EntityFrameworkCore;

public class GetAllUsersHandler : IRequestHandler<GetAllUsersRequest, List<UserModel>>
{
    private readonly ApiCadastroContext _dbContext;

    public GetAllUsersHandler(ApiCadastroContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<UserModel>> Handle(GetAllUsersRequest request, CancellationToken cancellationToken)
    {
        var result = await _dbContext.User.ToListAsync();
        return result;
    }
}