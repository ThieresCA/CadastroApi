using MediatR;

public class UpdateUserRequest : IRequest<bool>
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public DateTime? BirthDate { get; set; }
    public string? Endereco { get; set; }
    public string? Cpf { get; set; }
    public int? Idade { get; set; }

    public UpdateUserRequest(int id)
    {
        Id = id;
    }
}