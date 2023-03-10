using MediatR;
using System.ComponentModel.DataAnnotations;

public class DeleteUserRequest : IRequest<bool>
{
    [Required]
    public int Id { get; set; }
}