using ApiCadastroUser.Data;
using ApiCadastroUser.Features.User;
using MediatR;
using Microsoft.EntityFrameworkCore;

public class DeleteUserHandler : IRequestHandler<DeleteUserRequest, bool>
{
    private readonly ApiCadastroContext _dbContext;

    public DeleteUserHandler(ApiCadastroContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> Handle(DeleteUserRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var result = await _dbContext.User.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (result == null)
                return false;

            _dbContext.User.Remove(result);

            return true;

        }
        catch (System.Exception)
        {

            return false;
        }
    }
}