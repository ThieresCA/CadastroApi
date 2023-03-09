using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ApiCadastroUser.Features.User
{
    public class UserModel
    {
        //no primeiro migration isso foi utilizado para que o Identity_Insert pudesse ser feito
        [Key]
        //inserido para que o Identity seja criado automaticamente, permitindo que o construtor não precise do parametro Id
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        //public UserModel(string name, string email, DateTime birthDate)
        //{
        //    Name = name;
        //    Email = email;
        //    BirthDate = birthDate;
        //}

    }
}