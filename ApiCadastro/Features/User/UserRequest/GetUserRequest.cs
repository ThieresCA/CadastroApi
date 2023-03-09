using ApiCadastroUser.Features.User;
using MediatR;

public class GetUserRequest : IRequest<UserModel?>
{
    public int Id { get; set; }
}