using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCadastroUser.Features.User
{
    public class ClienteModel
    {
        //no primeiro migration isso foi utilizado para que o Identity_Insert pudesse ser feito
        [Key]
        //inserido para que o Identity seja criado automaticamente, permitindo que o construtor não precise do parametro Id
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
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

        public ClienteModel()
        {

        }
        public ClienteModel(string name, string email, DateTime birthDate, string adress, string cpf, int age)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
            Adress = adress;
            Cpf = cpf;
            Age = age;
        }

    }
}