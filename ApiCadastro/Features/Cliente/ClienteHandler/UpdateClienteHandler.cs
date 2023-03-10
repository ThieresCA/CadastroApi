using ApiCadastroUser.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

public class UpdateClienteHandler : IRequestHandler<UpdateClienteRequest, bool>
{
    private readonly ApiCadastroContext _dbContext;

    public UpdateClienteHandler(ApiCadastroContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> Handle(UpdateClienteRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var result = await _dbContext.Cliente.FirstOrDefaultAsync(x => x.Id == request.Id);
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

            if (request.Cpf != null)
            {
                string input = request.Cpf;
                string res = Regex.Replace(input, @"[^\d]", "");
                result.Cpf = res;
            }

            if (request.Adress != null)
                result.Adress = request.Adress;

            if (request.Age != null)
                result.Age = request.Age.Value;

            _dbContext.Cliente.Update(result);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return true;
        }
        catch (System.Exception)
        {
            return false;
        }
    }
}