using MediatR;

public class UpdateUserRequest : IRequest<bool>
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public DateTime? BirthDate { get; set; }

    public UpdateUserRequest(int id, string name, string email, DateTime birthDate)
    {
        Id = id;
        Name = name;
        Email = email;
        BirthDate = birthDate;
    }
}