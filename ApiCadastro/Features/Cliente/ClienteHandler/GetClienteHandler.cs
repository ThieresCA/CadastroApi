using ApiCadastroUser.Data;
using ApiCadastroUser.Features.User;
using MediatR;
using Microsoft.EntityFrameworkCore;

public class GetClienteHandler : IRequestHandler<GetClienteRequest, ClienteModel?>
{
    private readonly ApiCadastroContext _dbContext;

    public GetClienteHandler(ApiCadastroContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<ClienteModel?> Handle(GetClienteRequest request, CancellationToken cancellationToken)
    {
        var result = await _dbContext.Cliente.FirstOrDefaultAsync(x => x.Id == request.Id);

        return result;
    }
}