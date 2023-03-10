using ApiCadastroUser.Data;
using ApiCadastroUser.Features.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
ConfigureServices(builder.Services, builder.Configuration);
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Minha API", Version = "v1" });
});
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("v1/swagger.json", "Minha API v1");
});

app.UseAuthorization();

app.MapControllers();

app.Run();

static void ConfigureServices(IServiceCollection services, IConfiguration Configuration)
{

    services.AddDbContext<ApiCadastroContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("ApiCadastro"), builder =>
                    builder.MigrationsAssembly("ApiCadastro")));

    services.AddTransient<UserModel>();
    services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<Program>());
}