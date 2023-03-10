using ApiCadastroUser.Features.User;
using MediatR;
using System.ComponentModel.DataAnnotations;

public class GetClienteRequest : IRequest<ClienteModel?>
{
    [Required]
    public int Id { get; set; }


}