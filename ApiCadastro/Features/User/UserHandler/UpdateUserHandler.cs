using ApiCadastroUser.Data;
using ApiCadastroUser.Features.User;
using MediatR;
using Microsoft.EntityFrameworkCore;

public class UpdateUserHandler : IRequestHandler<UpdateUserRequest, bool>
{
    private readonly ApiCadastroContext _dbContext;

    public UpdateUserHandler(ApiCadastroContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> Handle(UpdateUserRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var result = await _dbContext.User.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (result == null)
            {
                return false;
            }

            if (request.Name != null)
                result.Name = request.Name;

            if (request.BirthDate != null)
                result.BirthDate = request.BirthDate.Value;

            if (request.Email != null)
                result.Email = request.Email;

            _dbContext.User.Update(result);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return true;
        }
        catch (System.Exception)
        {
            return false;
        }
    }
}