using ApiCadastroUser.Data;
using ApiCadastroUser.Features.User;
using MediatR;
using Microsoft.EntityFrameworkCore;

public class GetAllClientesHandler : IRequestHandler<GetAllClientesRequest, List<ClienteModel>>
{
    private readonly ApiCadastroContext _dbContext;

    public GetAllClientesHandler(ApiCadastroContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<ClienteModel>> Handle(GetAllClientesRequest request, CancellationToken cancellationToken)
    {
        var result = await _dbContext.Cliente.ToListAsync();
        return result;
    }
}