using ApiCadastroUser.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

public class DeleteClienteHandler : IRequestHandler<DeleteClienteRequest, bool>
{
    private readonly ApiCadastroContext _dbContext;

    public DeleteClienteHandler(ApiCadastroContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> Handle(DeleteClienteRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var result = await _dbContext.Cliente.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (result == null)
                return false;

            _dbContext.Cliente.Remove(result);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return true;

        }
        catch (System.Exception)
        {

            return false;
        }
    }
}