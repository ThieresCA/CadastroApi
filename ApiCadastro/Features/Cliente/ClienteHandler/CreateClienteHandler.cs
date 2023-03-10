using ApiCadastroUser.Data;
using ApiCadastroUser.Features.User;
using MediatR;
using System.Text.RegularExpressions;

public class CreateClienteHandler : IRequestHandler<CreateClienteRequest, ClienteModel>
{
    private readonly ApiCadastroContext _dbContext;

    public CreateClienteHandler(ApiCadastroContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<ClienteModel> Handle(CreateClienteRequest request, CancellationToken cancellationToken)
    {





        var entity = new ClienteModel(
            name: request.Name,
            email: request.Email,
            birthDate: request.BirthDate,
            adress: request.Adress,
            cpf: request.Cpf,
            age: request.Age
        );

        string input = entity.Cpf;
        string res = Regex.Replace(input, @"[^\d]", "");
        entity.Cpf = res;

        _dbContext.Add(entity);
        await _dbContext.SaveChangesAsync(cancellationToken);

        return entity;
    }
}