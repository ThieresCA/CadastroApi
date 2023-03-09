using ApiCadastroUser.Features.User;
using MediatR;

public class CreateUserRequest : IRequest<UserModel>
{
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime BirthDate { get; set; }

    public CreateUserRequest(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
}