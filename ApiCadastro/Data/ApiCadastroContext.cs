using ApiCadastroUser.Features.User;
using Microsoft.EntityFrameworkCore;

namespace ApiCadastroUser.Data
{
    public class ApiCadastroContext : DbContext
    {
        public ApiCadastroContext(DbContextOptions<ApiCadastroContext> options)
            : base(options)
        {
        }
        public DbSet<UserModel> User { get; set; }
    }
}