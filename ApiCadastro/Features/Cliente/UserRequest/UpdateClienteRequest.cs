using MediatR;

public class UpdateClienteRequest : IRequest<bool>
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public DateTime? BirthDate { get; set; }
    public string? Adress { get; set; }
    public string? Cpf { get; set; }
    public int? Age { get; set; }

    public UpdateClienteRequest(int id)
    {
        Id = id;
    }
}