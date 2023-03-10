using ApiCadastroUser.Features.User;
using MediatR;
using static System.Net.Mime.MediaTypeNames;

public class CreateUserRequest : IRequest<UserModel>
{
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime BirthDate { get; set; }
    public string Endereco { get; set; }
    public string Cpf { get; set; }
    public int Idade { get; set; }

    public CreateUserRequest(string name, string email, DateTime birthDate, string endereco, string cpf, int idade)
    {
        Name = name;
        Email = email;
        BirthDate = birthDate;
        Endereco = endereco;
        Cpf = cpf;
        Idade = idade;
    }
}