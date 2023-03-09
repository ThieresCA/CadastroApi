using ApiCadastroUser.Data;
using ApiCadastroUser.Features.User;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
ConfigureServices(builder.Services, builder.Configuration);
var app = builder.Build();

 static void ConfigureServices(IServiceCollection services, IConfiguration Configuration)
{
    services.AddDbContext<ApiCadastroContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("ApiCadastro"), builder =>
                    builder.MigrationsAssembly("ApiCadastro")));

    services.AddScoped<UserModel>();
    services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<Program>());
}
// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
