using ApiCadastroUser.Features.User;
using MediatR;

public class GetAllUsersRequest : IRequest<List<UserModel>>
{
}