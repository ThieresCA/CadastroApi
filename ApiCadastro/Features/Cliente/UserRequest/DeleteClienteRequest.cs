using MediatR;
using System.ComponentModel.DataAnnotations;

public class DeleteClienteRequest : IRequest<bool>
{
    [Required]
    public int Id { get; set; }
}