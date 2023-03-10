using ApiCadastroUser.Features.User;
using MediatR;

public class GetAllClientesRequest : IRequest<List<ClienteModel>>
{
}