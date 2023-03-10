using ApiCadastroUser.Features.User;
using MediatR;
using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

public class CreateClienteRequest : IRequest<ClienteModel>
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public DateTime BirthDate { get; set; }
    [Required]
    public string Adress { get; set; }
    [Required]
    public string Cpf { get; set; }
    [Required]
    public int Age { get; set; }

    public CreateClienteRequest(string name, string email, DateTime birthDate, string adress, string cpf, int age)
    {
        Name = name;
        Email = email;
        BirthDate = birthDate;
        Adress = adress;
        Cpf = cpf;
        Age = age;
    }
}