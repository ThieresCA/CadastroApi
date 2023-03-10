using ApiCadastroUser.Data;
using ApiCadastroUser.Features.User;
using MediatR;
using System.Text.RegularExpressions;

public class CreateUserHandler : IRequestHandler<CreateUserRequest, UserModel>
{
    private readonly ApiCadastroContext _dbContext;

    public CreateUserHandler(ApiCadastroContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<UserModel> Handle(CreateUserRequest request, CancellationToken cancellationToken)
    {





        var entity = new UserModel(
            name: request.Name,
            email: request.Email,
            birthDate: request.BirthDate,
            endereco: request.Endereco,
            cpf: request.Cpf,
            idade: request.Idade
        );

        string input = entity.Cpf;
        string res = Regex.Replace(input, @"[^\d]", "");
        entity.Cpf = res;

        _dbContext.Add(entity);
        await _dbContext.SaveChangesAsync(cancellationToken);

        return entity;
    }
}