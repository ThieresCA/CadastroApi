using ApiCadastroUser.Features.User;
using MediatR;

public class DeleteUserRequest : IRequest<bool>
{
    public int Id { get; set; }
}