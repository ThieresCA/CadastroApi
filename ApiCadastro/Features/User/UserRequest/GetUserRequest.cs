using ApiCadastroUser.Features.User;
using MediatR;
using System.ComponentModel.DataAnnotations;

public class GetUserRequest : IRequest<UserModel?>
{
    [Required]
    public int Id { get; set; }


}